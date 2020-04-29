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
    public class BBSCodeListener : BBSCodeParserBaseListener
    {
        public TagsDict TagsTable;
        public EntitiesDict EntitiesTable;
        public AttributesDict AttributesTable;

        private string FileName;
        private IClient Client;
        private IServer Server;

        public BBSCodeResult Parsed { get; private set; }

        private ANSICodes ANSI;
        private BBSCodeResult.Action action;
//        private string actionKey;

        public BBSCodeListener(IClient c, IServer s, string filename) : base()
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

        public override void EnterBbsCodeElement([NotNull] BBSCodeParser.BbsCodeElementContext context)
        {
            string tagName = context.children[1].GetText().Trim().ToUpper();
            Tags tag;
            if (TagsTable.TryGetValue(tagName, out tag))
            {
                Parsed.TextPush();
            }
        }

        public override void ExitBbsCodeElement([NotNull] BBSCodeParser.BbsCodeElementContext context)
        {
            string tagName = context.children[1].GetText().Trim().ToUpper();
            Tags tag;
            if (TagsTable.TryGetValue(tagName, out tag))
            {
                Attributes attr = AttributesTable.GetAttributes(tag);
                string value;
                switch (tag)
                {
                    case Tags.CLS:
                        if (attr.TryGetValue("FORECOLOR", out value)) ANSI.pushForeColor(value);
                        if (attr.TryGetValue("BACKCOLOR", out value)) ANSI.pushBackColor(value);
                        Parsed.TextConcat(ANSI.ClearScreen());
                        Parsed.TextPop(true);
                        break;
                    case Tags.BLINK:
                        textModeTag(ANSICodes.Modes.Blink);
                        break;
                    case Tags.REVERSE:
                        textModeTag(ANSICodes.Modes.Reverse);
                        break;
                    case Tags.BOLD:
                        textModeTag(ANSICodes.Modes.Bold);
                        break;
                    case Tags.UNDERLINE:
                        textModeTag(ANSICodes.Modes.Underline);
                        break;
                    case Tags.COLOR:
                        if(attr.TryGetValue("VALUE", out value))
                        {
                            ANSI.pushForeColor(value);
                            Parsed.Parsed = ANSI.WriteForeColor() + Parsed.Parsed;                            
                            ANSI.popForeColor();
                            Parsed.TextConcat(ANSI.WriteForeColor());
                        }
                        Parsed.TextPop(true);
                        break;
                    case Tags.BACKCOLOR:
                        if (attr.TryGetValue("VALUE", out value))
                        {
                            ANSI.pushBackColor(value);
                            Parsed.Parsed = ANSI.WriteBackColor() + Parsed.Parsed;
                            ANSI.popBackColor();
                            Parsed.TextConcat(ANSI.WriteBackColor());
                        }
                        Parsed.TextPop(true);
                        break;
                    case Tags.P:
                        Parsed.Parsed = string.Join('\n', TextHelper.WordWrap(Parsed.Parsed, 79).ToArray());
                        Parsed.TextPop(true);
                        break;
                    case Tags.FIGGLE:
                        value = "standard";
                        attr.TryGetValue("FONT", out value);
                        if (string.IsNullOrWhiteSpace(value)) value = "standard";
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
                    case Tags.CONNECTED:
                        Parsed.TextConcat(string.Format("{0,-30} {1,-16} {2}\r\n", "Username", "Connected", "From"));
                        Parsed.TextConcat(new string('-', 79) + "\r\n");
                        foreach (IClient c in Server.clients.Values)
                            Parsed.TextConcat(string.Format("{0,-30} {1:g} {2}\r\n",
                                string.IsNullOrWhiteSpace(c.username) ? "GUEST" : c.username, c.connectedAt, c.Remote));
                        Parsed.TextPop(true);
                        break;
                    case Tags.JOINED:
                        Parsed.TextConcat(string.Format("{0,-30} {1,-10} {2}\r\n", "Username", "Since", "From"));
                        Parsed.TextConcat(new string('-', 79) + "\r\n");
                        using (bbsContext bbs = new bbsContext())
                        {
                            foreach (var user in bbs.Users)
                                Parsed.TextConcat(string.Format("{0,-30} {1:d} {2}\r\n",
                                    user.Userid, user.Registered.Date,
                                    TextHelper.Truncate(user.City.Trim() + ", " + user.Nation, 32)));
                        }
                        Parsed.TextPop(true);
                        break;
                    case Tags.BEEP:
                        Parsed.TextConcat((char)7);
                        Parsed.TextPop(true);
                        break;
                    case Tags.HR:
                        Parsed.TextConcat(new string('-', 79));
                        Parsed.TextPop(true);
                        break;
                    default:
                        break;
                }
            }
        }

        private void textModeTag(ANSICodes.Modes mode)
        {
            ANSI.SetMode(ANSICodes.Modes.Blink);
            Parsed.Parsed = ANSI.WriteMode() + Parsed.Parsed;
            ANSI.ResetMode(ANSICodes.Modes.Blink);
            Parsed.TextConcat(ANSI.WriteMode());
            Parsed.TextPop(true);
        }

        public override void EnterBbsCodeAttribute([NotNull] BBSCodeParser.BbsCodeAttributeContext context)
        {
            string tagName = context.Parent.GetChild(1).GetText().Trim().ToUpper();
            string attributeName = context.children[0].GetText().Trim().ToUpper();
            string attributeValue = string.Empty;
            if(context.ChildCount > 2) attributeValue = context.children[2].GetText().Trim('"').Trim();

            Tags tag;
            if (TagsTable.TryGetValue(tagName, out tag))
            {
                AttributesTable.Add(tag, attributeName, attributeValue);
            }
        }

        public override void EnterBbsCodeEntity([NotNull] BBSCodeParser.BbsCodeEntityContext context)
        {
            string entityName = context.GetText().Trim().ToUpper();
            entityName = entityName.Substring(1, entityName.Length - 2);
            Parsed.TextConcat(EntitiesTable.GetValue(entityName));
        }

        public override void EnterBbsCodeChardata([NotNull] BBSCodeParser.BbsCodeChardataContext context)
        {
            Parsed.Parsed += context.GetText();
        }
    }
}
