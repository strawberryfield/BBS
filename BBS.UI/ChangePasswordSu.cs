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
using Casasoft.BBS.Interfaces;

namespace Casasoft.BBS.UI
{
    /// <summary>
    /// Change password in superuser mode
    /// </summary>
    public class ChangePasswordSu : ChangePassword
    {
        #region constructors
        private const string defaultText = "@ChangePasswordSu";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public ChangePasswordSu(IBBSClient c, IServer s) : this(c, s, defaultText) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public ChangePasswordSu(IBBSClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="text">Text to parse and optional parameters separated by semicolon</param>
        public ChangePasswordSu(IBBSClient c, IServer s, string text) : this(c, s, text, null) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="text">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public ChangePasswordSu(IBBSClient c, IServer s, string text, IScreen prev) : base(c, s, text, prev)
        {
            status = states.WaitForUsername;
        }
        #endregion

        /// <summary>
        /// Starts dialog
        /// </summary>
        public override void Show()
        {
            base.Show(true);
            MoveTo(dataAreaStart, 1);
            LnWrite(catalog.GetString("Username") + ": ");
            status = states.WaitForUsername;
        }

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
                case states.WaitForUsername:
                    msg = msg.ToUpper();
                    if(msg == "EXIT")
                    {
                        ShowNext();
                        return;
                    }
                    using (bbsContext bbs = new bbsContext())
                        user = bbs.GetUserByUsername(msg);
                    if(user == null)
                    {
                        LnWrite(catalog.GetString("User '{0}' is not found.", msg));
                        LnWrite(catalog.GetString("Username") + ": ");
                    }
                    else
                    {
                        LnWrite(catalog.GetString("New password") + ": ");
                        client.status = EClientStatus.Authenticating;
                        status = states.WaitForNewPassword;
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
    }
}
