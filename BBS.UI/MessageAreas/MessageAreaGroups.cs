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
    public class MessageAreaGroups : ListViewerBase
    {
        #region constructors
        private const string defaultText = "@MessageAreaGroups";
        public MessageAreaGroups(IClient c, IServer s) : this(c, s, defaultText, null) { }
        public MessageAreaGroups(IClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }
        public MessageAreaGroups(IClient c, IServer s, string txt) : this(c, s, txt, null) { }
        public MessageAreaGroups(IClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev)
        {
            AddList();
        }
        #endregion

        private void AddList()
        {
            string fmt = "{0,-20} {1,3} {2}";

            using (bbsContext bbs = new bbsContext())
            {
                List<MessageAreasGroup> list = bbs.GetAllowedMessageAreasGroup(client.username).ToList();
                foreach (MessageAreasGroup group in list)
                {
                    lines.Add(TextHelper.Truncate(string.Format(fmt,
                        group.Id, group.MessageAreas.Count, group.Description), client.screenWidth));
                    Data.Actions.Add(group.Id,
                        new Parser.BBSCodeResult.Action() { module = "MessageAreas", data = "@MessageAreas;" + group.Id });
                }
            }
        }
    }
}
