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
using NGettext;

namespace Casasoft.BBS.UI
{
    /// <summary>
    /// Form to register as a new user
    /// </summary>
    public class NewUser : TextScreenBase
    {
        #region constructors
        private const string defaultText = "@NewUser";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public NewUser(IBBSClient c, IServer s) : this(c, s, defaultText) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public NewUser(IBBSClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        public NewUser(IBBSClient c, IServer s, string txt) : this(c, s, txt, null) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public NewUser(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev)
        {
            status = states.WaitForUsername;
            user = new User();
            InitCatalog();
        }
        #endregion

        private enum states
        {
            WaitForUsername, WaitForPassword, WaitForConfirmPassword,
            WaitForRealName, WaitForCity, WaitForNation, WaitForConfirm
        }
        private states status;
        private User user;

        /// <summary>
        /// Starts new user dialog
        /// </summary>
        public override void Show()
        {
            base.Show();
            MoveTo(dataAreaStart, 1);
            LnWrite(catalog.GetString("Username") + ": ");
            status = states.WaitForUsername;
        }

        private string password;

        /// <summary>
        /// Dialog events loop
        /// </summary>
        /// <param name="msg"></param>
        public override void HandleMessage(string msg)
        {
            msg = msg.Trim();
            if (string.IsNullOrWhiteSpace(msg))
            {
                if (status == states.WaitForConfirm) msg = catalog.GetString("Yes");
                else if (status != states.WaitForUsername) return;
            }
            switch (status)
            {
                case states.WaitForUsername:
                    string username = msg.ToUpper();
                    bool success = false;
                    switch (username)
                    {
                        case "":
                            client.screen = ScreenFactory.Create(client, server, "LoginScreen");
                            client.screen.Show();
                            break;
                        case "LOGOUT":
                            client.screen = ScreenFactory.Create(client, server, "Logout");
                            client.screen.Show();
                            return;
                        case "GUEST":
                        case "NEW":
                            break;
                        default:
                            if (user.AcceptableUsername(username))
                                using (bbsContext bbs = new bbsContext())
                                {
                                    User test = bbs.GetUserByUsername(username);
                                    if (test == null) success = true;
                                }
                            break;
                    }
                    if (success)
                    {
                        user.Userid = username;
                        LnWrite(catalog.GetString("Password") + ": ");
                        status = states.WaitForPassword;
                        client.status = EClientStatus.Authenticating;
                    }
                    else
                    {
                        LnWrite(catalog.GetString("This name is already in use. Try another."));
                        LnWrite(catalog.GetString("Username") + ": ");
                    }
                    break;

                case states.WaitForPassword:
                    password = msg;
                    if (user.AcceptablePassword(password))
                    {
                        LnWrite(catalog.GetString("Confirm password") + ": ");
                        status = states.WaitForConfirmPassword;
                    }
                    else
                    {
                        LnWrite(catalog.GetString("Password do not meet security criteria."));
                        LnWrite(catalog.GetString("Password") + ": ");
                        status = states.WaitForPassword;
                    }
                    break;

                case states.WaitForConfirmPassword:
                    if (password == msg)
                    {
                        user.SetPassword(password);
                        client.status = EClientStatus.Guest;
                        LnWrite(catalog.GetString("Your real name") + ": ");
                        status = states.WaitForRealName;
                    }
                    else
                    {
                        LnWrite(catalog.GetString("The two passwords do not match. Try again."));
                        LnWrite(catalog.GetString("Password") + ": ");
                        status = states.WaitForPassword;
                    }
                    break;

                case states.WaitForRealName:
                    user.Realname = msg;
                    LnWrite(catalog.GetString("Your city") + ": ");
                    status = states.WaitForCity;
                    break;

                case states.WaitForCity:
                    user.City = msg;
                    LnWrite(catalog.GetString("Your country")+": ");
                    status = states.WaitForNation;
                    break;

                case states.WaitForNation:
                    user.Nation = msg;
                    LnWrite(catalog.GetString("Confirm new user creation? [{0}]/{1}",
                        new object[] {
                            catalog.GetString("Yes"), catalog.GetString("No")
                        }) + ": ");
                    status = states.WaitForConfirm;
                    break;

                case states.WaitForConfirm:
                    msg = msg.ToUpper();
                    if (msg == catalog.GetString("Yes").ToUpper())
                    {
                        using (bbsContext bbs = new bbsContext())
                        {
                            bbs.Users.Add(user);
                            bbs.SaveChanges();
                        }
                        string m = catalog.GetString("Created new user '{0}'", user.Userid);
                        EventLogger.Write(m, client.Remote);
                    }
                    client.screen = ScreenFactory.Create(client, server, "LoginScreen");
                    client.screen.Show();
                    break;

                default:
                    break;
            }
        }
    }
}
