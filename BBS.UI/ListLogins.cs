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
using Casasoft.TextHelpers;
using System.Linq;

namespace Casasoft.BBS.UI
{
    public class ListLogins : TextScreenBase
    {
        #region constructors
        private const string defaultText = "@ListLogins";
        public ListLogins(IBBSClient c, IServer s, string txt) : this(c, s, txt, null) { }
        public ListLogins(IBBSClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }
        public ListLogins(IBBSClient c, IServer s) : this(c, s, defaultText) { }
        public ListLogins(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev)
        {
            using (bbsContext bbs = new bbsContext())
            {
                foreach (var login in bbs.Logins.Where(l => l.UserId == client.username))
                    Text.Add(TextHelper.Truncate(string.Format("{0,-20:G} {1} {2}",
                        login.DateTime, login.Success ? "*" : " ", login.From), client.screenWidth));
            }
        }
        #endregion
    }
}
