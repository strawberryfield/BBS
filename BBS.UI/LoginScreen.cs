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

namespace Casasoft.BBS.UI
{
    public class LoginScreen : TextScreenBase
    {
        public LoginScreen(IClient c, IServer s) : this(c, s, "@Login") { }
        public LoginScreen(IClient c, IServer s, IScreen prev) : this(c, s, "@Login", prev) { }
        public LoginScreen(IClient c, IServer s, string text) : this(c, s, text, null) { }
        public LoginScreen(IClient c, IServer s, string text, IScreen prev) : base(c, s, text, prev)
        {
            status = states.WaitForUsername;
        }

        private enum states { WaitForUsername, WaitForPassword }
        private states status;

        public override void Show()
        {
            base.Show();
            LnWrite("Username: ");
            status = states.WaitForUsername;
        }

        private string username = string.Empty;
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
                        server.sendMessageToClient(client, "\r\nUsername or password incorrect. Please try again.");
                        server.sendMessageToClient(client, "\r\nUsername: ");
                        status = states.WaitForUsername;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
