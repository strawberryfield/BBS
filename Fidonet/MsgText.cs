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

using Casasoft.TextHelpers;
using System.Collections.Generic;
using System.Text;

namespace Casasoft.Fidonet
{
    /// <summary>
    /// Body of the message with echomail extensions
    /// </summary>
    /// <remarks>
    /// <see cref="http://ftsc.org/docs/fts-0004.001"/>
    /// <see cref="http://ftsc.org/docs/fts-0009.001"/>
    /// </remarks>
    public class MsgText : IMsgText
    {
        #region properties
        /// <summary>
        /// Echomail area
        /// </summary>
        /// <remarks>
        /// <see cref="IMsgText.Area"/>
        /// </remarks>
        public virtual string Area { get; set; }

        /// <summary>
        /// Echomail Tear Line
        /// </summary>
        /// <remarks>
        /// <see cref="IMsgText.Tear"/>
        /// </remarks>
        public virtual string Tear { get; set; }

        /// <summary>
        /// Origin of the message
        /// </summary>
        /// <remarks>
        /// <see cref="IMsgText.Origin"/>
        /// </remarks>
        public virtual string Origin { get; set; }

        /// <summary>
        /// Seen-by lines
        /// </summary>
        /// <remarks>
        /// <see cref="IMsgText.SeenBy"/>
        /// </remarks>
        public virtual List<string> SeenBy { get; set; }

        /// <summary>
        /// Path lines
        /// </summary>
        /// <remarks>
        /// <see cref="IMsgText.Path"/>
        /// </remarks>
        public virtual List<string> Path { get; set; }

        /// <summary>
        /// Fidonet message id
        /// </summary>
        /// <remarks>
        /// <see cref="IMsgText.MsgId"/>
        /// </remarks>
        public virtual string MsgId { get; set; }

        /// <summary>
        /// Replay to Fidonet message id
        /// </summary>
        /// <remarks>
        /// <see cref="IMsgText.ReplyId"/>
        /// </remarks>
        public virtual string ReplyId { get; set; }

        /// <summary>
        /// Main text lines
        /// </summary>
        public virtual List<string> Lines { get; set; }
        #endregion

        #region constructors
        public MsgText()
        {
            Area = string.Empty;
            Tear = string.Empty;
            Origin = string.Empty;
            SeenBy = new List<string>();
            Path = new List<string>();
            MsgId = string.Empty;
            ReplyId = string.Empty;
            Lines = new List<string>();
        }

        public MsgText(string s) : this()
        {
            Lines = TextHelper.SplitString(s);

            int f = Lines.FindIndex(s => s.StartsWith("AREA:"));
            if (f >= 0)
            {
                Area = Lines[f].Substring(5).Trim();
                Lines.RemoveAt(f);
            }

            f = Lines.FindLastIndex(s => s.StartsWith("--- "));
            if (f >= 0)
            {
                Tear = Lines[f].Substring(4).Trim();
                Lines.RemoveAt(f);
            }

            f = Lines.FindIndex(s => s.Trim().StartsWith("* Origin: "));
            if (f >= 0)
            {
                Origin = Lines[f].Trim().Substring(9).Trim();
                Lines.RemoveAt(f);
            }

            f = Lines.FindIndex(s => s.StartsWith("\u0001MSGID: "));
            if (f >= 0)
            {
                MsgId = Lines[f].Substring(7).Trim();
                Lines.RemoveAt(f);
            }

            f = Lines.FindIndex(s => s.StartsWith("\u0001REPLY: "));
            if (f >= 0)
            {
                ReplyId = Lines[f].Substring(7).Trim();
                Lines.RemoveAt(f);
            }

            f = Lines.FindIndex(s => s.StartsWith("SEEN-BY: "));
            while (f >= 0)
            {
                SeenBy.Add(Lines[f].Substring(8).Trim());
                Lines.RemoveAt(f);
                f = Lines.FindIndex(s => s.StartsWith("SEEN-BY: "));
            }

            f = Lines.FindIndex(s => s.StartsWith("\u0001PATH: "));
            while (f >= 0)
            {
                Path.Add(Lines[f].Substring(6).Trim());
                Lines.RemoveAt(f);
                f = Lines.FindIndex(s => s.StartsWith("\u0001PATH: "));
            }
        }
        #endregion

        /// <summary>
        /// Returns message body in string
        /// </summary>
        public virtual string Text
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                if (!string.IsNullOrWhiteSpace(Area)) sb.Append($"AREA:{Area}\n");
                if (!string.IsNullOrWhiteSpace(MsgId)) sb.Append($"\u0001MSGID: {MsgId}\n");
                if (!string.IsNullOrWhiteSpace(ReplyId)) sb.Append($"\u0001REPLY: {ReplyId}\n");

                foreach (string s in Lines) sb.Append(s + "\n");

                if (!string.IsNullOrWhiteSpace(Tear)) sb.Append($"--- {Tear}\n");
                if (!string.IsNullOrWhiteSpace(Origin)) sb.Append($" * Origin: {Origin}\n");

                foreach (string s in SeenBy) sb.Append($"SEEN-BY {s}\n");
                foreach (string s in Path) sb.Append($"\u0001PATH {s}\n");

                return sb.ToString();
            }
        }
    }
}
