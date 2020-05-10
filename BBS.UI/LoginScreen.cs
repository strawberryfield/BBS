// copyright (c) 2020 Roberto Ceccarelli - CasaSoft
// http://strawberryfield.altervista.org 
// 
// This file is part of CasaSoft BBS
// 
// CasaSoft BBS is free software: 
// you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// CasaSoft BBS is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
// See the GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with CasaSoft BBS.  
// If not, see <http://www.gnu.org/licenses/>.

using Casasoft.BBS.DataTier;
using Casasoft.BBS.DataTier.DataModel;
using Casasoft.BBS.Interfaces;
using Casasoft.BBS.Logger;
using System;
using System.Collections.Specialized;
using System.Configuration;

namespace Casasoft.BBS.UI
{
    /// <summary>
    /// Handles user login
    /// </summary>
    public class LoginScreen : TextScreenBase
    {
        #region constructors
        private const string defaultText = "@Login";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public LoginScreen(IBBSClient c, IServer s) : this(c, s, defaultText) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public LoginScreen(IBBSClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="text">Text to parse and optional parameters separated by semicolon</param>
        public LoginScreen(IBBSClient c, IServer s, string text) : this(c, s, text, null) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="text">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public LoginScreen(IBBSClient c, IServer s, string text, IScreen prev) : base(c, s, text, prev)
        {
            status = states.WaitForUsername;
            NameValueCollection SecurityOptions = (NameValueCollection)ConfigurationManager.GetSection("Security");
            maxtries = Convert.ToInt16(SecurityOptions["MaxTries"]);
        }
        #endregion

        private enum states { WaitForUsername, WaitForPassword }
        private states status;
        private int tries = 0;
        private int maxtries;

        /// <summary>
        /// Starts the login form
        /// </summary>
        public override void Show()
        {
            base.Show();
            MoveTo(dataAreaStart, 1);
            LnWrite("Username: ");
            status = states.WaitForUsername;
            tries = 0;
        }

        private string username = string.Empty;

        /// <summary>
        /// Dialog events loop
        /// </summary>
        /// <param name="msg"></param>
        public override void HandleMessage(string msg)
        {
            switch (status)
            {
                case states.WaitForUsername:
                    username = msg.Trim().ToUpper();
                    if (username == string.Empty) break;
                    switch (username)
                    {
                        case "GUEST":
                            client.screen = ScreenFactory.Create(client, server, "TextScreen", "@GuestAccess");
                            client.screen.Show();
                            break;
                        case "NEW":
                            client.screen = ScreenFactory.Create(client, server, "NewUser");
                            client.screen.Show();
                            break;
                        case "LOGOUT":
                            client.screen = ScreenFactory.Create(client, server, "Logout");
                            client.screen.Show();
                            break;
                        default:
                            server.sendMessageToClient(client, "\r\nPassword: ");
                            status = states.WaitForPassword;
                            client.status = EClientStatus.Authenticating;
                            break;
                    }
                    break;
                case states.WaitForPassword:
                    string pwd = msg.Trim();
                    client.status = EClientStatus.Guest;

                    bool success = false;
                    using (bbsContext bbs = new bbsContext())
                    {
                        User user = bbs.GetUserByUsername(username);
                        if (user != null)
                        {
                            Login login = new Login() { UserId = username, From = client.Remote };
                            if (user.CheckPassword(pwd))
                            {
                                // successful login
                                success = true;
                                user.LastLoginDate = DateTime.Now;
                                user.LastLoginFrom = client.Remote;
                                login.Success = true;
                                bbs.Logins.Add(login);
                                try
                                {
                                    bbs.SaveChanges();
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    Console.WriteLine(e.InnerException.Message);
                                }

                                EventLogger.Write(string.Format("Successful login for user '{0}'", username),
                                    client.Remote);
                                client.status = EClientStatus.LoggedIn;
                            }
                            else
                            {
                                login.Success = false;
                                bbs.Logins.Add(login);
                                bbs.SaveChanges();
                                EventLogger.Write(string.Format("Password failed for user '{0}'", username),
                                    client.Remote);
                            }
                        }
                        else
                        {
                            EventLogger.Write(string.Format("Unknown user '{0}'", username),
                                client.Remote);
                        }
                    }

                    if (success)
                    {
                        client.username = username;
                        client.screen = ScreenFactory.Create(client, server, "TextScreen", "@LoggedIn");
                        client.screen.Show();
                    }
                    else
                    {
                        if (++tries >= maxtries)
                        {
                            client.screen = ScreenFactory.Create(client, server, "Logout");
                            client.screen.Show();
                        }
                        else
                        {
                            server.sendMessageToClient(client, "\r\nUsername or password incorrect. Please try again.");
                            server.sendMessageToClient(client, "\r\nUsername: ");
                            status = states.WaitForUsername;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
