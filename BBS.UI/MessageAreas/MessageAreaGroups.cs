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
    /// <summary>
    /// Implements the list of message areas groups
    /// </summary>
    public class MessageAreaGroups : ListScreenBase
    {
        #region constructors
        private const string defaultText = "@MessageAreaGroups";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public MessageAreaGroups(IBBSClient c, IServer s) : this(c, s, defaultText, null) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public MessageAreaGroups(IBBSClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        public MessageAreaGroups(IBBSClient c, IServer s, string txt) : this(c, s, txt, null) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public MessageAreaGroups(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev) { }
        #endregion

        /// <summary>
        /// Fills area groups list
        /// </summary>
        protected override void AddList()
        {
            string fmt = "{0,-20} {1,3} {2}";

            using (bbsContext bbs = new bbsContext())
            {
                List<MessageAreasGroup> list = bbs.GetAllowedMessageAreasGroup(client.username).ToList();
                foreach (MessageAreasGroup group in list)
                {
                    Text.Add(TextHelper.Truncate(string.Format(fmt,
                        group.Id, group.MessageAreas.Count, group.Description), client.screenWidth));
                    Data.Actions.Add(group.Id,
                        new Parser.BBSCodeResult.Action() { module = "MessageAreas", data = "@MessageAreas;" + group.Id });
                }
            }
        }
    }
}
