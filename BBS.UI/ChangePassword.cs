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
    /// <summary>
    /// Change password dialog
    /// </summary>
    public class ChangePassword : TextScreenBase
    {
        #region constructors
        private const string defaultText = "@ChangePassword";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public ChangePassword(IBBSClient c, IServer s) : this(c, s, defaultText) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public ChangePassword(IBBSClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="text">Text to parse and optional parameters separated by semicolon</param>
        public ChangePassword(IBBSClient c, IServer s, string text) : this(c, s, text, null) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="text">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public ChangePassword(IBBSClient c, IServer s, string text, IScreen prev) : base(c, s, text, prev)
        {
            status = states.WaitForOldPassword;
            using (bbsContext bbs = new bbsContext())
                user = bbs.GetUserByUsername(client.username);
        }
        #endregion

        /// <summary>
        /// list of states
        /// </summary>
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected enum states { WaitForUsername, WaitForOldPassword, WaitForNewPassword, WaitForConfirm, WaitForContinue }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        /// <summary>
        /// current loop status
        /// </summary>
        protected states status;

        /// <summary>
        /// Starts dialog
        /// </summary>
        public override void Show()
        {
            base.Show();
            MoveTo(dataAreaStart, 1);
            LnWrite("Old password: ");
            status = states.WaitForOldPassword;
            client.status = EClientStatus.Authenticating;
        }

        /// <summary>
        /// Starts dialog
        /// </summary>
        /// <param name="CalledFromChild">dummy parameter to create an override</param>
        public virtual void Show(bool CalledFromChild)
        {
            base.Show();
        }

        /// <summary>
        /// user temporary storage
        /// </summary>
        protected User user;
        /// <summary>
        /// password temporary storage
        /// </summary>
        protected string password;
        /// <summary>
        /// Dialog event loop
        /// </summary>
        /// <param name="msg"></param>
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
                    handleWaitForNewPassword(msg);
                    break;
                case states.WaitForConfirm:
                    handleWaitForConfirm(msg);
                    break;
                case states.WaitForContinue:
                    ShowNext();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// checks if password meets security criteria
        /// </summary>
        /// <param name="msg">candidate password</param>
        protected void handleWaitForNewPassword(string msg)
        {
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
        }

        /// <summary>
        /// check if retyped password match the first inserted  
        /// </summary>
        /// <param name="msg"></param>
        protected void handleWaitForConfirm(string msg)
        {
            if (password == msg)
            {
                using (bbsContext bbs = new bbsContext())
                {
                    user = bbs.GetUserByUsername(user.Userid);
                    user.SetPassword(password);
                    bbs.SaveChanges();
                }
                EventLogger.Write(
                    string.Format("Password changed successfully for user '{0}'", user.Userid), client.Remote);
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
        }
    }
}
