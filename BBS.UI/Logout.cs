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

using Casasoft.BBS.Interfaces;
using System;
using System.Collections.Specialized;
using System.Configuration;

namespace Casasoft.BBS.UI
{
    /// <summary>
    /// Message before disconnection
    /// </summary>
    public class Logout : TextScreenBase
    {
        #region constructors
        private const string defaultText = "@Logout";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public Logout(IBBSClient c, IServer s) : this(c, s, defaultText, null) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        public Logout(IBBSClient c, IServer s, string txt) : this(c, s, txt, null) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public Logout(IBBSClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public Logout(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev) { }
        #endregion

        /// <summary>
        /// Shows the message and force disconnection
        /// </summary>
        public override void Show()
        {
            Write(ANSI.ClearScreen());
            ShowLines(Header, 0, Header.Count, 1);
            NameValueCollection netconfig = (NameValueCollection)ConfigurationManager.GetSection("Networking");
            int inactivityTimeout = Convert.ToInt32(netconfig["InactivityTimeout"]);
            client.lastActivity = DateTime.Now.AddSeconds(-(inactivityTimeout - 10));
        }
    }
}
