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

namespace Casasoft.BBS.UI
{
    public class ChangePassword : TextScreenBase
    {
        public ChangePassword(IClient c, IServer s) : this(c, s, "@ChangePassword") { }
        public ChangePassword(IClient c, IServer s, IScreen prev) : this(c, s, "@ChangePassword", prev) { }
        public ChangePassword(IClient c, IServer s, string text) : this(c, s, text, null) { }
        public ChangePassword(IClient c, IServer s, string text, IScreen prev) : base(c, s, text, prev)
        {
            status = states.WaitForOldPassword;
            using (bbsContext bbs = new bbsContext())
                user = bbs.GetUserByUsername(client.username);
        }

        private enum states { WaitForOldPassword, WaitForNewPassword, WaitForConfirm, WaitForContinue }
        private states status;

        public override void Show()
        {
            base.Show();
            LnWrite("Old password: ");
            status = states.WaitForOldPassword;
            client.status = EClientStatus.Authenticating;
        }

        private User user;
        private string password;
        public override void HandleMessage(string msg)
        {
            msg = msg.Trim();
            if (string.IsNullOrWhiteSpace(msg) && status != states.WaitForContinue) return;
            switch (status)
            {
                case states.WaitForOldPassword:
                    if (user.CheckPassword(msg))
                    {
                        LnWrite("New password: ");
                        status = states.WaitForNewPassword;
                    }
                    else
                    {
                        LnWrite("Password incorrect. Try again.");
                        LnWrite("Old password: ");
                    }
                    break;
                case states.WaitForNewPassword:
                    password = msg;
                    if (user.AcceptablePassword(password))
                    {
                        LnWrite("Retype password: ");
                        status = states.WaitForConfirm;
                    }
                    else
                    {
                        LnWrite("Password do not meet security criteria.");
                        LnWrite("New password: ");
                        status = states.WaitForNewPassword;
                    }
                    break;
                case states.WaitForConfirm:
                    if(password == msg)
                    {
                        using(bbsContext bbs = new bbsContext())
                        {
                            user = bbs.GetUserByUsername(client.username);
                            user.SetPassword(password);
                            bbs.SaveChanges();
                        }
                        EventLogger.Write(
                            string.Format("Password changed successfully for user '{0}'", client.username), client.Remote);
                        LnWrite("Password changed successfully.");
                        Writeln();
                        client.status = EClientStatus.LoggedIn;
                        status = states.WaitForContinue;
                    }
                    else
                    {
                        LnWrite("The two passwords do not match.");
                        LnWrite("New password: ");
                        status = states.WaitForNewPassword;
                    }
                    break;
                case states.WaitForContinue:
                    ShowNext();
                    break;
                default:
                    break;
            }
        }

    }
}
