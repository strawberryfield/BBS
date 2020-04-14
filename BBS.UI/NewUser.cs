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
using System.Configuration;

namespace Casasoft.BBS.UI
{
    public class NewUser : TextScreenBase
    {
        public NewUser(IClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev)
        {
            status = states.WaitForUsername;
            user = new User();
        }
        public NewUser(IClient c, IServer s, string txt) : this(c, s, txt, null) { }
        public NewUser(IClient c, IServer s, IScreen prev) : this(c, s, "@NewUser", prev) { }
        public NewUser(IClient c, IServer s) : this(c, s, "@NewUser") { }

        private enum states
        {
            WaitForUsername, WaitForPassword, WaitForConfirmPassword,
            WaitForRealName, WaitForCity, WaitForNation, WaitForConfirm
        }
        private states status;
        private User user;

        public override void Show()
        {
            base.Show();
            LnWrite("Username: ");
            status = states.WaitForUsername;
        }

        private string password;
        public override void HandleMessage(string msg)
        {
            msg = msg.Trim();
            if (string.IsNullOrWhiteSpace(msg))
            {
                if (status == states.WaitForConfirm) msg = "Yes";
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
                        LnWrite("Password: ");
                        status = states.WaitForPassword;
                        client.status = EClientStatus.Authenticating;
                    }
                    else
                    {
                        LnWrite("This name is already in use. Try another.");
                        LnWrite("Username: ");
                    }
                    break;

                case states.WaitForPassword:
                    password = msg;
                    if (user.AcceptablePassword(password))
                    {
                        LnWrite("Confirm password: ");
                        status = states.WaitForConfirmPassword;
                    }
                    else
                    {
                        LnWrite("Password do not meet security criteria.");
                        LnWrite("Password: ");
                        status = states.WaitForPassword;
                    }
                    break;

                case states.WaitForConfirmPassword:
                    if (password == msg)
                    {
                        user.SetPassword(password);
                        client.status = EClientStatus.Guest;
                        LnWrite("Your real name: ");
                        status = states.WaitForRealName;
                    }
                    else
                    {
                        LnWrite("The two passwords do not match. Try again.");
                        LnWrite("Password: ");
                        status = states.WaitForPassword;
                    }
                    break;

                case states.WaitForRealName:
                    user.Realname = msg;
                    LnWrite("Your city: ");
                    status = states.WaitForCity;
                    break;

                case states.WaitForCity:
                    user.City = msg;
                    LnWrite("Your country: ");
                    status = states.WaitForNation;
                    break;

                case states.WaitForNation:
                    user.Nation = msg;
                    LnWrite("Confirm new user creation? [Yes]/No: ");
                    status = states.WaitForConfirm;
                    break;

                case states.WaitForConfirm:
                    msg = msg.ToUpper();
                    if (msg == "YES")
                    {
                        using (bbsContext bbs = new bbsContext())
                        {
                            bbs.Users.Add(user);
                            bbs.SaveChanges();
                        }
                        string m = string.Format("Created new user '{0}'", user.Userid);
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
