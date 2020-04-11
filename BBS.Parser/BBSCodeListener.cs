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
using System;
using System.Collections.Generic;

namespace Casasoft.BBS.Parser
{
    public class BBSCodeListener : BBSCodeParserBaseListener
    {
        public enum Tags { UNKNOWN, CLS, BLINK, REVERSE, BOLD, UNDERLINE, COLOR, BACKCOLOR, ACTION }
        public static Dictionary<string, Tags> TagsTable;
        private Stack<Tags> tagsStack;

        public BBSCodeResult Parsed { get; private set; }

        private ANSICodes ANSI;
        private BBSCodeResult.Action action;
        private string actionKey;

        public BBSCodeListener() : base()
        {
            Parsed = new BBSCodeResult();
            TagsTable = new Dictionary<string, Tags>();
            foreach (Tags t in Enum.GetValues(typeof(Tags)))
                TagsTable.Add(t.ToString().ToUpper(), t);

            ANSI = new ANSICodes();
        }

        public override void EnterBbsCodeElement([NotNull] BBSCodeParser.BbsCodeElementContext context)
        {
            string tagName = context.children[1].GetText().Trim().ToUpper();
            Tags tag = Tags.UNKNOWN;
            TagsTable.TryGetValue(tagName, out tag);
            switch (tag)
            {
                case Tags.CLS:
                    ANSI.ClearMode();
                    break;
                case Tags.BLINK:
                    ANSI.SetMode(ANSICodes.Modes.Blink);
                    Parsed.Parsed += ANSI.WriteMode();
                    break;
                case Tags.REVERSE:
                    ANSI.SetMode(ANSICodes.Modes.Reverse);
                    Parsed.Parsed += ANSI.WriteMode();
                    break;
                case Tags.BOLD:
                    ANSI.SetMode(ANSICodes.Modes.Bold);
                    Parsed.Parsed += ANSI.WriteMode();
                    break;
                case Tags.UNDERLINE:
                    ANSI.SetMode(ANSICodes.Modes.Underline);
                    Parsed.Parsed += ANSI.WriteMode();
                    break;
                case Tags.COLOR:
                    ANSI.pushForeColor(context.children[2].GetChild(2).GetText());
                    Parsed.Parsed += ANSI.WriteMode();
                    break;
                case Tags.BACKCOLOR:
                    ANSI.pushBackColor(context.children[2].GetChild(2).GetText());
                    Parsed.Parsed += ANSI.WriteMode();
                    break;
                case Tags.ACTION:
                    action = new BBSCodeResult.Action();
                    actionKey = string.Empty;
                    break;
                case Tags.UNKNOWN:
                default:
                    break;
            }
        }

        public override void ExitBbsCodeElement([NotNull] BBSCodeParser.BbsCodeElementContext context)
        {
            string tagName = context.children[1].GetText().Trim().ToUpper();
            Tags tag = Tags.UNKNOWN;
            TagsTable.TryGetValue(tagName, out tag);
            switch (tag)
            {
                case Tags.CLS:
                    Parsed.Parsed += ANSI.ClearScreen();
                    break;
                case Tags.BLINK:
                    ANSI.ResetMode(ANSICodes.Modes.Blink);
                    Parsed.Parsed += ANSI.WriteMode();
                    break;
                case Tags.REVERSE:
                    ANSI.ResetMode(ANSICodes.Modes.Reverse);
                    Parsed.Parsed += ANSI.WriteMode();
                    break;
                case Tags.BOLD:
                    ANSI.ResetMode(ANSICodes.Modes.Bold);
                    Parsed.Parsed += ANSI.WriteMode();
                    break;
                case Tags.UNDERLINE:
                    ANSI.ResetMode(ANSICodes.Modes.Underline);
                    Parsed.Parsed += ANSI.WriteMode();
                    break;
                case Tags.COLOR:
                    ANSI.popForeColor();
                    Parsed.Parsed += ANSI.WriteMode();
                    break;
                case Tags.BACKCOLOR:
                    ANSI.popBackColor();
                    Parsed.Parsed += ANSI.WriteMode();
                    break;
                case Tags.ACTION:
                    Parsed.Actions.Add(actionKey, action);
                    break;
                case Tags.UNKNOWN:
                default:
                    break;
            }
        }

        public override void EnterBbsCodeAttribute([NotNull] BBSCodeParser.BbsCodeAttributeContext context)
        {
            string tagName = context.Parent.GetChild(1).GetText().Trim().ToUpper();
            Tags tag = Tags.UNKNOWN;
            TagsTable.TryGetValue(tagName, out tag);
            string attributeName = context.children[0].GetText().Trim().ToUpper();
            string attributeValue = context.children[2].GetText().Trim('"').Trim();
            switch (tag)
            {
                case Tags.CLS:
                    if (attributeName == "FORECOLOR") ANSI.pushForeColor(attributeValue);
                    if (attributeName == "BACKCOLOR") ANSI.pushBackColor(attributeValue);
                    break;

                case Tags.BLINK:
                    break;
                case Tags.REVERSE:
                    break;
                case Tags.BOLD:
                    break;
                case Tags.UNDERLINE:
                    break;
                case Tags.COLOR:
                    break;
                case Tags.BACKCOLOR:
                    break;

                case Tags.ACTION:
                    switch (attributeName)
                    {
                        case "KEY":
                            actionKey = attributeValue;
                            break;
                        case "MODULE":
                            action.module = attributeValue;
                            break;
                        case "TEXT":
                            action.data = attributeValue;
                            break;
                        default:
                            break;
                    }
                    break;

                case Tags.UNKNOWN:
                default:
                    break;
            }
        }

        public override void EnterBbsCodeChardata([NotNull] BBSCodeParser.BbsCodeChardataContext context)
        {
            Parsed.Parsed += context.GetText();
        }
    }
}
