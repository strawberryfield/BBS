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
    /// Implements the list of message areas
    /// </summary>
    public class MessageAreas : ListScreenBase
    {
        #region constructors
        private const string defaultText = "@MessageAreas";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public MessageAreas(IBBSClient c, IServer s) : base(c, s, defaultText) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public MessageAreas(IBBSClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        public MessageAreas(IBBSClient c, IServer s, string txt) : this(c, s, txt, null) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public MessageAreas(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev) { }
        #endregion

        /// <summary>
        /// Fills the messages area list
        /// </summary>
        protected override void AddList()
        {
            string fmt = "{0,-20} {1,4} {2,4} {3,4} {4}";

            using (bbsContext bbs = new bbsContext())
            {
                User user = bbs.GetUserByUsername(client.username);
                List<MessageArea> list = bbs.GetMessageAllowedAreasByGroup(
                    Params.Length > 1 ? Params[1] : string.Empty, client.username).ToList();
                foreach (MessageArea area in list)
                {
                    Text.Add(TextHelper.Truncate(string.Format(fmt, new object[] {
                        area.Id, area.MessagesCount, area.NewMessagesCount(user.LastLoginDate),
                        area.UnreadMessagesCount(user.Userid), area.Description }), client.screenWidth));
                    Data.Actions.Add(area.Id,
                        new Parser.BBSCodeResult.Action()
                        {
                            module = "MessagesList",
                            data = string.Format("@MessagesList;{0}", area.Id)
                        });
                }
            }
            KeyLength = 20;
        }
    }
}
