﻿// copyright (c) 2020 Roberto Ceccarelli - CasaSoft
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
using Casasoft.TextHelpers;

namespace Casasoft.BBS.UI
{
    /// <summary>
    /// Implements the registered users list
    /// </summary>
    public class ListUsers : ListScreenBase
    {
        #region constructors
        private const string defaultText = "@ListUsers";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public ListUsers(IBBSClient c, IServer s) : this(c, s, defaultText, null) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public ListUsers(IBBSClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        public ListUsers(IBBSClient c, IServer s, string txt) : this(c, s, txt, null) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public ListUsers(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev) { }
        #endregion

        /// <summary>
        /// Fills the registered users list
        /// </summary>
        protected override void AddList()
        {
            using (bbsContext bbs = new bbsContext())
            {
                foreach (var user in bbs.Users)
                    Text.Add(TextHelper.Truncate(string.Format("{0,-30} {1:d} {2}",
                        user.Userid, user.Registered.Date,
                        user.City.Trim() + ", " + user.Nation), client.screenWidth));
            }
        }
    }
}
