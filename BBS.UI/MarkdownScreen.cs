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
using Casasoft.BBS.Parser;
using Casasoft.TextHelpers;
using Microsoft.Toolkit.Parsers.Markdown;
using Microsoft.Toolkit.Parsers.Markdown.Blocks;
using Microsoft.Toolkit.Parsers.Markdown.Inlines;
using Microsoft.Toolkit.Parsers.Markdown.Render;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;

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
        /// Collection of configured styles
        /// </summary>
        protected NameValueCollection mdStyles;

        /// <summary>
        /// Path for relative url
        /// </summary>
        protected string basePath;

        /// <summary>
        /// link number storage
        /// </summary>
        protected int actionsCount;

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
                Uri dir = new Uri(new Uri(name), ".");                
                basePath = dir.OriginalString;
            }
            else
            {
                txt = File.ReadAllText(GetFile(name));
                basePath = Path.GetDirectoryName(name);
            }

            MarkdownDocument md = new MarkdownDocument();
            md.Parse(txt);

            mdStyles = (NameValueCollection)ConfigurationManager.GetSection("Markdown");
            foreach(var b in md.Blocks)
            {
                Text.AddRange(BlockProcessing(b, 0));
            }
            Footer.Add(string.Empty);
        }

        /// <summary>
        /// Markdown blocks processing
        /// </summary>
        /// <param name="b"></param>
        /// <param name="recursionLevel"></param>
        protected List<string> BlockProcessing(MarkdownBlock b, int recursionLevel)
        {
            string forecolor = string.Empty;
            string backcolor = string.Empty;
            string underline = string.Empty;
            int maxWidth = client.screenWidth - recursionLevel * 2;
            List<string> Text = new List<string>();
            switch (b.Type)
            {
                case MarkdownBlockType.Root:
                    break;
                case MarkdownBlockType.Paragraph:
                    string para = "";
                    foreach (var i in ((ParagraphBlock)b).Inlines)
                        para += ProcessInline(i);
                    Text.AddRange(TextHelper.WordWrap(para, maxWidth));
                    Text.Add(string.Empty);
                    break;
                case MarkdownBlockType.Quote:
                    break;
                case MarkdownBlockType.Code:
                    forecolor = ANSI.GetStyleForeColor("Code_Color", mdStyles);
                    backcolor = ANSI.GetStyleBackColor("Code_Back", mdStyles);
                    List<string> rows = TextHelper.SplitString(((CodeBlock)b).Text);
                    foreach (string s in rows)
                    {
                        Text.Add(backcolor + forecolor + ANSI.ClearCurrentLine + s + ANSI.WriteMode());
                    }
                    Text.Add(ANSI.WriteMode());
                    break;
                case MarkdownBlockType.Header:
                    HeaderBlock hb = (HeaderBlock)b;
                    Text.AddRange(ANSI.Header(hb.ToString(), hb.HeaderLevel, maxWidth));
                    break;
                case MarkdownBlockType.List:
                    ListBlock lb = (ListBlock)b;
                    string indent = new string(' ', recursionLevel * 2);
                    foreach (var li in lb.Items)
                    {
                        List<string> lir = new List<string>();
                        bool isFirst = true;
                        foreach (var lib in li.Blocks)
                            lir.AddRange(BlockProcessing(lib, recursionLevel + 1));
                        foreach (string s in lir)
                        {
                            Text.Add((isFirst ? "- " : "  ") + s);
                            isFirst = false;
                        }
                    }
                    break;
                case MarkdownBlockType.ListItemBuilder:
                    break;
                case MarkdownBlockType.HorizontalRule:
                    Text.Add(TextHelper.HR('-', maxWidth));
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
            return Text;
        }

        /// <summary>
        /// Inline processing
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        protected string ProcessInline(MarkdownInline i)
        {
            string para = string.Empty;
            switch (i.Type)
            {
                //case MarkdownInlineType.Comment:
                //    break;
                //case MarkdownInlineType.TextRun:
                //    break;
                case MarkdownInlineType.Bold:
                    para += ANSI.WriteMode(ANSICodes.Modes.Bold) +
                        i.ToString().Trim('*') + ANSI.WriteMode();
                    break;
                //case MarkdownInlineType.Italic:
                //    break;
                case MarkdownInlineType.MarkdownLink:
                    MarkdownLinkInline mitLink = (MarkdownLinkInline)i;
                    if (mitLink.Url.ToLower().EndsWith(".md"))
                    {
                        actionsCount++;
                        para += $"{mitLink.Inlines[0]}[{actionsCount}]";
                        Data.Actions.Add(actionsCount.ToString(),
                            new BBSCodeResult.Action()
                            {
                                module = "MarkdownScreen",
                                data = (mitLink.Url.StartsWith("http") ? "" : basePath) + mitLink.Url
                            });
                    }
                    else
                        para += mitLink.ToString();
                    break;
                //case MarkdownInlineType.RawHyperlink:
                //    break;
                //case MarkdownInlineType.RawSubreddit:
                //    break;
                //case MarkdownInlineType.Strikethrough:
                //    break;
                //case MarkdownInlineType.Superscript:
                //    break;
                //case MarkdownInlineType.Subscript:
                //    break;
                //case MarkdownInlineType.Code:
                //    break;
                //case MarkdownInlineType.Image:
                //    break;
                //case MarkdownInlineType.Emoji:
                //    break;
                //case MarkdownInlineType.LinkReference:
                //    break;
                default:
                    para += i.ToString();
                    break;
            }
            return para;
        }
    }
}
