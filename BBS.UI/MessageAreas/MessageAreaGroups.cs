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

namespace Casasoft.BBS.UI
{
    public class MessageAreaGroups : TextScreenBase
    {
        public MessageAreaGroups(IClient c, IServer s) : this(c, s, "@MessageAreaGroups", null) { }
        public MessageAreaGroups(IClient c, IServer s, IScreen prev) : this(c, s, "@MessageAreaGroups", prev) { }
        public MessageAreaGroups(IClient c, IServer s, string txt) : this(c, s, txt, null) { }
        public MessageAreaGroups(IClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev)
        {
            AddList();
        }

        private void AddList()
        {
            string fmt = "{0,-20} {1,-58}";
            Text.Add(string.Format(fmt, "Group", "Description"));
            Text.Add(new string('-', 79));

            using (bbsContext bbs = new bbsContext())
            {
                var list = bbs.GetAllowedMessageAreasGroup(client.username);
                foreach (MessageAreasGroup group in list)
                {
                    Text.Add(string.Format(fmt, group.Id, group.Description));
                    Data.Actions.Add(group.Id,
                        new Parser.BBSCodeResult.Action() { module = "MessageAreas", data = "@MessageAreas;" + group.Id });
                }
            }

            Text.Add(string.Empty);
            Text.Add("Select group (leave empty to return): ");
        }
    }
}
