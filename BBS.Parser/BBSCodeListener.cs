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

using Antlr4.Runtime.Misc;
using Casasoft.BBS.DataTier;
using Casasoft.BBS.DataTier.DataModel;
using Casasoft.BBS.Interfaces;
using Casasoft.BBS.Logger;
using Casasoft.TextHelpers;
using System;

namespace Casasoft.BBS.Parser
{
    /// <summary>
    /// This class provides the implementation of <see cref="IBBSCodeParserListener"/>,
    /// </summary>
    public class BBSCodeListener : BBSCodeParserBaseListener
    {
        private TagsDict TagsTable;
        private EntitiesDict EntitiesTable;
        private AttributesDict AttributesTable;

        private string FileName;
        private IBBSClient Client;
        private IServer Server;

        /// <summary>
        /// The processed data
        /// </summary>
        public BBSCodeResult Parsed { get; private set; }

        private ANSICodes ANSI;
        private BBSCodeResult.Action action;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Reference to the client</param>
        /// <param name="s">Reference to the server</param>
        /// <param name="filename">Name of the parsed file</param>
        public BBSCodeListener(IBBSClient c, IServer s, string filename) : base()
        {
            Client = c;
            Server = s;
            FileName = filename;

            Parsed = new BBSCodeResult();
            TagsTable = new TagsDict();
            EntitiesTable = new EntitiesDict(Client);
            AttributesTable = new AttributesDict();
            ANSI = new ANSICodes();
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="BBSCodeParser.bbsCodeElement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public override void EnterBbsCodeElement([NotNull] BBSCodeParser.BbsCodeElementContext context)
        {
            string tagName = context.children[1].GetText().Trim().ToUpper();
            Tags tag;
            if (TagsTable.TryGetValue(tagName, out tag))
            {
                Parsed.TextPush();
                switch (tag)
                {
                    case Tags.BLINK:
                        ANSI.SetMode(ANSICodes.Modes.Blink);
                        Parsed.TextConcat(ANSI.WriteMode());
                        break;
                    case Tags.REVERSE:
                        ANSI.SetMode(ANSICodes.Modes.Reverse);
                        Parsed.TextConcat(ANSI.WriteMode());
                        break;
                    case Tags.BOLD:
                        ANSI.SetMode(ANSICodes.Modes.Bold);
                        Parsed.TextConcat(ANSI.WriteMode());
                        break;
                    case Tags.UNDERLINE:
                        ANSI.SetMode(ANSICodes.Modes.Underline);
                        Parsed.TextConcat(ANSI.WriteMode());
                        break;
                    case Tags.HEADER:
                    case Tags.FOOTER:
                    case Tags.BODY:
                    case Tags.HIDDEN:
                        Parsed.TextClear();
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Exit a parse tree produced by <see cref="BBSCodeParser.bbsCodeElement"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public override void ExitBbsCodeElement([NotNull] BBSCodeParser.BbsCodeElementContext context)
        {
            string tagName = context.children[1].GetText().Trim().ToUpper();
            Tags tag;
            if (TagsTable.TryGetValue(tagName, out tag))
            {
                Attributes attr = AttributesTable.GetAttributes(tag);
                string value;
                string value1;
                switch (tag)
                {
                    case Tags.CLS:
                        if (attr.TryGetValue("FORECOLOR", out value)) ANSI.pushForeColor(value);
                        if (attr.TryGetValue("BACKCOLOR", out value)) ANSI.pushBackColor(value);
                        Parsed.TextConcat(ANSI.ClearScreen());
                        Parsed.TextPop(true);
                        break;
                    case Tags.BLINK:
                        ANSI.ResetMode(ANSICodes.Modes.Blink);
                        Parsed.TextConcat(ANSI.WriteMode());
                        Parsed.TextPop(true);
                        break;
                    case Tags.REVERSE:
                        ANSI.ResetMode(ANSICodes.Modes.Reverse);
                        Parsed.TextConcat(ANSI.WriteMode());
                        Parsed.TextPop(true);
                        break;
                    case Tags.BOLD:
                        ANSI.ResetMode(ANSICodes.Modes.Bold);
                        Parsed.TextConcat(ANSI.WriteMode());
                        Parsed.TextPop(true);
                        break;
                    case Tags.UNDERLINE:
                        ANSI.ResetMode(ANSICodes.Modes.Underline);
                        Parsed.TextConcat(ANSI.WriteMode());
                        Parsed.TextPop(true);
                        break;
                    case Tags.COLOR:
                        ANSI.popForeColor();
                        Parsed.TextConcat(ANSI.WriteMode());
                        Parsed.TextPop(true);
                        break;
                    case Tags.BACKCOLOR:
                        ANSI.popBackColor();
                        Parsed.TextConcat(ANSI.WriteMode());
                        Parsed.TextPop(true);
                        break;
                    case Tags.P:
                        Parsed.Parsed = string.Join('\n', TextHelper.WordWrap(Parsed.Parsed, Client.screenWidth).ToArray());
                        Parsed.TextPop(true);
                        break;
                    case Tags.MOVE:
                        if (!attr.TryGetValue("ROW", out value)) value = "0";
                        if (!attr.TryGetValue("COL", out value1)) value1 = "0";
                        Parsed.TextConcat(ANSI.Move(value1, value));
                        Parsed.TextPop(true);
                        break;
                    case Tags.FIGGLE:
                        if (!attr.TryGetValue("FONT", out value)) value = "standard";
                        try
                        {
                            Parsed.Parsed = Figgle.FiggleFonts.Lookup(value.ToLower()).Render(Parsed.Parsed);
                        }
                        catch (Exception)
                        { }
                        Parsed.TextPop(true);
                        break;
                    case Tags.ACTION:
                        action = new BBSCodeResult.Action(attr);
                        if (!string.IsNullOrWhiteSpace(action.requires))
                        {
                            if (string.IsNullOrWhiteSpace(Client.username))
                            {
                                Parsed.TextPop(true);
                                return;
                            }
                            using (bbsContext bbs = new bbsContext())
                            {
                                User user = bbs.GetUserByUsername(Client.username);
                                bool allowed = user.HasRights(action.requires);
                                Parsed.TextPop(allowed);
                                if (!allowed) return;
                            }
                        }
                        else Parsed.TextPop(true);
                        if (!Parsed.Actions.TryAdd(action.key, action))
                            EventLogger.Write(string.Format("Error adding action '{0}' in '{1}'", action.key, FileName), 0);
                        break;
                    case Tags.BEEP:
                        Parsed.TextConcat((char)7);
                        Parsed.TextPop(true);
                        break;
                    case Tags.HR:
                        Parsed.TextConcat(TextHelper.HR('-', Client.screenWidth));
                        Parsed.TextPop(true);
                        break;
                    case Tags.HEADER:
                        Parsed.Header = Parsed.Parsed;
                        Parsed.TextClear();
                        break;
                    case Tags.FOOTER:
                        Parsed.Footer = Parsed.Parsed;
                        Parsed.TextClear();
                        break;
                    case Tags.BODY:
                        Parsed.Body = Parsed.Parsed;
                        Parsed.TextClear();
                        break;
                    case Tags.HIDDEN:
                        Parsed.TextClear();
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="BBSCodeParser.bbsCodeAttribute"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public override void EnterBbsCodeAttribute([NotNull] BBSCodeParser.BbsCodeAttributeContext context)
        {
            string tagName = context.Parent.GetChild(1).GetText().Trim().ToUpper();
            string attributeName = context.children[0].GetText().Trim().ToUpper();
            string attributeValue = string.Empty;
            if(context.ChildCount > 2) attributeValue = context.children[2].GetText().Trim('"').Trim();

            Tags tag;
            if (TagsTable.TryGetValue(tagName, out tag))
            {
                switch (tag)
                {
                    case Tags.COLOR:
                        ANSI.pushForeColor(attributeValue);
                        Parsed.TextConcat(ANSI.WriteMode());
                        break;
                    case Tags.BACKCOLOR:
                        ANSI.pushBackColor(attributeValue);
                        Parsed.TextConcat(ANSI.WriteMode());
                        break;
                    default:
                        AttributesTable.Add(tag, attributeName, attributeValue);
                        break;
                }               
            }
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="BBSCodeParser.bbsCodeEntity"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public override void EnterBbsCodeEntity([NotNull] BBSCodeParser.BbsCodeEntityContext context)
        {
            string entityName = context.GetText().Trim().ToUpper();
            entityName = entityName.Substring(1, entityName.Length - 2);
            Parsed.TextConcat(EntitiesTable.GetValue(entityName));
        }

        /// <summary>
        /// Enter a parse tree produced by <see cref="BBSCodeParser.bbsCodeChardata"/>.
        /// </summary>
        /// <param name="context">The parse tree.</param>
        public override void EnterBbsCodeChardata([NotNull] BBSCodeParser.BbsCodeChardataContext context)
        {
            Parsed.Parsed += context.GetText();
        }
    }
}
