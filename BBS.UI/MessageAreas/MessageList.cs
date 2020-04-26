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
using Casasoft.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace Casasoft.BBS.UI
{
    public class MessageList : TextScreenBase
    {
        public MessageList(IClient c, IServer s) : base(c, s, string.Empty) { }
        public MessageList(IClient c, IServer s, IScreen prev) : this(c, s, string.Empty, prev) { }
        public MessageList(IClient c, IServer s, string txt) : this(c, s, txt, null) { }
        public MessageList(IClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev)
        {
            using (bbsContext bbs = new bbsContext())
                user = bbs.GetUserByUsername(client.username);
            //            AddList();
        }

        private User user;
        private const string fmt = "{0,5} {1,1} {2,1} {3,-30} {4,-38}";

        private void formatList(List<Message> list)
        {
            Text.Clear();
            Text.Add(string.Format(fmt, new object[]
            {
                "ID", "", "", "From", "Subject"
            }));
            Text.Add(TextHelper.HR());

            foreach (Message m in list)
                Text.Add(string.Format(fmt, new object[]
                {
                    m.Id, m.IsNew(user.LastLoginDate) ? "N" : "", m.IsRead(client.username) ? "" : "U",
                    TextHelper.Truncate(m.MessageFrom, 30), TextHelper.Truncate(m.Subject, 38)
                }));
        }
    }
}
