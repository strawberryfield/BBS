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
using System.Linq;

namespace Casasoft.BBS.UI
{
    public class NewUser : TextScreenBase
    {
        public NewUser(IClient c, IServer s, string txt) : base(c, s, txt)
        {
            status = states.WaitForUsername;
            user = new bbsUser();
        }

        public NewUser(IClient c, IServer s) : this(c, s, "NewUser") { }

        private enum states
        {
            WaitForUsername, WaitForPassword, WaitForConfirmPassword,
            WaitForRealName, WaitForCity, WaitForNation, WaitForConfirm
        }
        private states status;
        private bbsUser user;

        public override void Show()
        {
            base.Show();
            server.sendMessageToClient(client, "\r\nUsername: ");
            status = states.WaitForUsername;
        }

        private string password;
        public override void HandleMessage(string msg)
        {
            msg = msg.Trim();
            if (string.IsNullOrWhiteSpace(msg))
            {
                if (status == states.WaitForConfirm) msg = "Yes";
                else return;
            }
            switch (status)
            {
                case states.WaitForUsername:
                    string username = msg.ToUpper();
                    bool success = false;
                    switch (username)
                    {
                        case "GUEST":
                        case "NEW":
                            break;
                        default:
                            using (bbsContext bbs = new bbsContext())
                            {
                                User user = bbs.GetUserByUsername(username);
                                if (user == null) success = true;
                            }
                            break;
                    }
                    if (success)
                    {
                        user.Userid = username;
                        server.sendMessageToClient(client, "\r\nPassword: ");
                        status = states.WaitForPassword;
                        client.status = EClientStatus.Authenticating;
                    }
                    else
                    {
                        server.sendMessageToClient(client, "\r\nThis name is already in use. Try another.");
                        server.sendMessageToClient(client, "\r\nUsername: ");
                    }
                    break;

                case states.WaitForPassword:
                    password = msg;
                    server.sendMessageToClient(client, "\r\nConfirm password: ");
                    status = states.WaitForConfirmPassword;
                    break;

                case states.WaitForConfirmPassword:
                    if (password == msg)
                    {
                        user.SetPassword(password);
                        client.status = EClientStatus.Guest;
                        server.sendMessageToClient(client, "\r\nYour real name: ");
                        status = states.WaitForRealName;
                    }
                    else
                    {
                        server.sendMessageToClient(client, "\r\nThe two passwords do not match. Try again.");
                        server.sendMessageToClient(client, "\r\nPassword: ");
                        status = states.WaitForPassword;
                    }
                    break;

                case states.WaitForRealName:
                    user.Realname = msg;
                    server.sendMessageToClient(client, "\r\nYour city: ");
                    status = states.WaitForCity;
                    break;

                case states.WaitForCity:
                    user.City = msg;
                    server.sendMessageToClient(client, "\r\nYour country: ");
                    status = states.WaitForNation;
                    break;

                case states.WaitForNation:
                    user.Nation = msg;
                    server.sendMessageToClient(client, "\r\nConfirm new user creation? [Yes]/No: ");
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
                        client.screen = ScreenFactory.Create(client, server, "LoginScreen");
                    }
                    else
                    {
                        client.screen = ScreenFactory.Create(client, server, "LoginScreen");
                    }
                    client.screen.Show();
                    break;

                default:
                    break;
            }
        }

    }
}
