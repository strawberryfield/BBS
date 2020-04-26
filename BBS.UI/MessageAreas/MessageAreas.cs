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
    public class MessageAreas : TextScreenBase
    {
        public MessageAreas(IClient c, IServer s) : base(c, s, "@MessageAreas") { }
        public MessageAreas(IClient c, IServer s, IScreen prev) : this(c, s, "@MessageAreas", prev) { }
        public MessageAreas(IClient c, IServer s, string txt) : this(c, s, txt, null) { }
        public MessageAreas(IClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev)
        {
            AddList();
        }

        private void AddList()
        {
            string fmt = "{0,-20} {1,4} {2,4} {3,4} {4,-43}";
            Text.Add(string.Format(fmt, new object[] {
                "Area", "Msg.", "New", "Unr.", "Description" }));
            Text.Add(TextHelper.HR());

            using (bbsContext bbs = new bbsContext())
            {
                User user = bbs.GetUserByUsername(client.username);
                List<MessageArea> list = bbs.GetMessageAllowedAreasByGroup(
                    Params.Length > 1 ? Params[1] : string.Empty, client.username).ToList();
                foreach (MessageArea area in list)
                {
                    Text.Add(string.Format(fmt, new object[] {
                        area.Id, area.MessagesCount, area.NewMessagesCount(user.LastLoginDate),
                        area.UnreadMessagesCount(user.Userid), TextHelper.Truncate(area.Description, 43) }));
                    Data.Actions.Add(area.Id,
                        new Parser.BBSCodeResult.Action()
                        {
                            module = "MessageList",
                            data = string.Format(";{0}", area.Id)
                        });
                }
            }

            Text.Add(string.Empty);
            Text.Add("Select area (leave empty to return): ");
        }
    }
}
