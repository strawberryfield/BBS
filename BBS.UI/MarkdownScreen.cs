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

using Casasoft.BBS.Interfaces;
using Casasoft.TextHelpers;
using Microsoft.Toolkit.Parsers.Markdown;
using Microsoft.Toolkit.Parsers.Markdown.Blocks;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;

namespace Casasoft.BBS.UI
{
    /// <summary>
    /// Displays a Markdown file
    /// </summary>
    public class MarkdownScreen : TextScreenBase
    {
        #region constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public MarkdownScreen(IBBSClient c, IServer s) : base(c, s) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public MarkdownScreen(IBBSClient c, IServer s, IScreen prev) : base(c, s, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        public MarkdownScreen(IBBSClient c, IServer s, string txt) : base(c, s, txt) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public MarkdownScreen(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev) { }
        #endregion

        /// <summary>
        /// Reads the markdown file and stores it in lists of lines
        /// </summary>
        /// <param name="name">File to load</param>
        protected override void ReadText(string name)
        {
            Data = new Parser.BBSCodeResult();
            string txt;
            if (TextHelper.IsUrl(name))
            {
                WebClient webClient = new WebClient();
                txt = webClient.DownloadString(name);
            }
            else
                txt = File.ReadAllText(GetFile(name));

            MarkdownDocument md = new MarkdownDocument();
            md.Parse(txt);

            NameValueCollection mdStyles = 
                (NameValueCollection)System.Configuration.ConfigurationManager.GetSection("Markdown");
            foreach(var b in md.Blocks)
            {
                switch (b.Type)
                {
                    case MarkdownBlockType.Root:
                        break;
                    case MarkdownBlockType.Paragraph:
                        Text.AddRange(TextHelper.WordWrap(b.ToString(), client.screenWidth));
                        Text.Add(string.Empty);
                        break;
                    case MarkdownBlockType.Quote:
                        break;
                    case MarkdownBlockType.Code:
                        break;
                    case MarkdownBlockType.Header:
                        string l = string.Format("H{0}_", ((HeaderBlock)b).HeaderLevel);
                        string forecolor = mdStyles.Get(l + "Color");
                        forecolor = string.IsNullOrWhiteSpace(forecolor) ? string.Empty : ANSI.WriteForeColor(forecolor);
                        string backcolor = mdStyles.Get(l + "Back");
                        backcolor = string.IsNullOrWhiteSpace(backcolor) ? string.Empty : ANSI.WriteBackColor(backcolor);
                        string underline = mdStyles.Get(l + "Underline");
                        foreach(string s in TextHelper.WordWrap(b.ToString(), client.screenWidth))
                        {
                            Text.Add(backcolor + forecolor + ANSI.ClearCurrentLine + s);
                        }
                        if (!string.IsNullOrWhiteSpace(underline))
                            Text.Add(backcolor + forecolor + TextHelper.HR(underline[0], client.screenWidth));
                        Text.Add(ANSI.WriteMode());
                        break;
                    case MarkdownBlockType.List:
                        break;
                    case MarkdownBlockType.ListItemBuilder:
                        break;
                    case MarkdownBlockType.HorizontalRule:
                        Text.Add(TextHelper.HR('-', client.screenWidth));
                        break;
                    case MarkdownBlockType.Table:
                        break;
                    case MarkdownBlockType.LinkReference:
                        break;
                    case MarkdownBlockType.YamlHeader:
                        break;
                    default:
                        break;
                }
            }
            Footer.Add(string.Empty);
        }

    }
}
