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
    /// List of messages in echomail area
    /// </summary>
    public class MessagesList : ListScreenBase
    {
        #region constructors
        private const string defaultText = "@MessagesList";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public MessagesList(IBBSClient c, IServer s) : base(c, s, defaultText) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public MessagesList(IBBSClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        public MessagesList(IBBSClient c, IServer s, string txt) : this(c, s, txt, null) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public MessagesList(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev) { }
        #endregion

        /// <summary>
        /// Fills the messages area list
        /// </summary>
        protected override void AddList()
        {
            if (Params.Length < 2) return;  // There is no area filter
            string area = Params[1].Trim().ToUpper();
            string filter = Params.Length > 2 ? Params[2].Trim().ToUpper() : string.Empty;
            string fmt = "{0,5} {1,1} {2,1} {3,-30} {4}";

            using (bbsContext bbs = new bbsContext())
            {
                User user = bbs.GetUserByUsername(client.username);
                List<Message> list = bbs.GetAllMessagesInArea(area).ToList();
                foreach (Message m in list)
                {
                    Text.Add(TextHelper.Truncate(string.Format(fmt, new object[]
                    {
                    m.Id, m.IsNew(user.LastLoginDate) ? "N" : "", m.IsRead(client.username) ? "" : "U",
                    TextHelper.Truncate(m.MessageFrom, 30), m.Subject
                    }), client.screenWidth));

                    Data.Actions.Add(m.Id.ToString(), new Parser.BBSCodeResult.Action()
                    {
                        module = "MessageScreen",
                        data = string.Format("@MessageScreen;{0}", m.Id)
                    });
                }
            }
            KeyLength = 5;
        }
    }
}
