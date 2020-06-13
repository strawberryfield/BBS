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
using Casasoft.Fidonet;
using Casasoft.TextHelpers;

namespace Casasoft.BBS.UI
{
    /// <summary>
    /// Shows a message
    /// </summary>
    public class MessageScreen : TextScreenBase
    {
        #region constructors
        private const string defaultText = "@MessageScreen";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public MessageScreen(IBBSClient c, IServer s) : base(c, s, defaultText) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public MessageScreen(IBBSClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        public MessageScreen(IBBSClient c, IServer s, string txt) : this(c, s, txt, null) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public MessageScreen(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev) { }
        #endregion

        /// <summary>
        /// Reads the message and the page template
        /// </summary>
        /// <param name="name">template name</param>
        protected override void ReadText(string name)
        {            
            Message msg;
            using (bbsContext bbs = new bbsContext())
            {
                msg = bbs.GetMessageById(Params[1]);
                if (bbs.SetMessageRead(msg.Id, client.username))
                {
                    msg.TimesRead++;
                    bbs.SaveChanges();
                }
            }

            base.ReadText(name);
            Data.Header = Data.Header.Replace("$msgid$", Params[1])
                .Replace("$msgdatetime$", msg.DateTime.ToString("G"))
                .Replace("$msgfrom$", msg.MessageFrom)
                .Replace("$msgto$", msg.MessageTo)
                .Replace("$msgorig$", new FidoAddress(msg.OrigZone, msg.OrigNet, msg.OrigNode, msg.OrigPoint).address4D)
                .Replace("$msgdest$", new FidoAddress(msg.DestZone, msg.DestNet, msg.DestNode, msg.DestPoint).address4D)
                .Replace("$msgsubj$", msg.Subject);
            Header = Data.GetHeaderRows();
            Text = TextHelper.SplitString(msg.Body);
        }
    }
}
