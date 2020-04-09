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
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;

namespace Casasoft.BBS.Parser
{
    public class BBSCodeListener : BBSCodeParserBaseListener
    {
        public enum Tags { UNKNOWN, CLS, BLINK, REVERSE, BOLD, UNDERLINE, COLOR, BACKCOLOR, ACTION }
        public static Dictionary<string, Tags> TagsTable;
        private Stack<Tags> tagsStack;

        private ANSICodes.Colors currentForeColor = ANSICodes.Colors.White;
        private ANSICodes.Colors currentBackColor = ANSICodes.Colors.Black;

        public string Parsed { get; private set; }

        public BBSCodeListener() : base()
        {
            Parsed = string.Empty;
            TagsTable = new Dictionary<string, Tags>();
            foreach (Tags t in Enum.GetValues(typeof(Tags)))
                TagsTable.Add(t.ToString().ToUpper(), t);

            NameValueCollection appearance = (NameValueCollection)ConfigurationManager.GetSection("Appearance");
            ANSICodes.ColorTable.TryGetValue(appearance["ForeColor"].ToUpper(), out currentForeColor);
            ANSICodes.ColorTable.TryGetValue(appearance["BackColor"].ToUpper(), out currentBackColor);
        }

        public override void EnterBbsCodeElement([NotNull] BBSCodeParser.BbsCodeElementContext context)
        {
            string tagName = context.children[1].GetText().Trim().ToUpper();
            Tags tag = Tags.UNKNOWN;
            TagsTable.TryGetValue(tagName, out tag);
            switch (tag)
            {
                case Tags.CLS:
                    break;
                case Tags.BLINK:
                    Parsed += ANSICodes.SetMode(ANSICodes.Modes.Blink);
                    break;
                case Tags.REVERSE:
                    Parsed += ANSICodes.SetMode(ANSICodes.Modes.Reverse);
                    break;
                case Tags.BOLD:
                    Parsed += ANSICodes.SetMode(ANSICodes.Modes.Bold);
                    break;
                case Tags.UNDERLINE:
                    Parsed += ANSICodes.SetMode(ANSICodes.Modes.Underline);
                    break;
                case Tags.COLOR:
                    ColorTags(context.children[2]);
                    break;
                case Tags.BACKCOLOR:
                    ColorTags(context.children[2], true);
                    break;
                case Tags.ACTION:
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
                    Parsed += ANSICodes.ClearScreen();
                    break;
                case Tags.BLINK:
                    Parsed += ANSICodes.SetMode(ANSICodes.Modes.Blink);
                    break;
                case Tags.REVERSE:
                    Parsed += ANSICodes.SetMode(ANSICodes.Modes.Reverse);
                    break;
                case Tags.BOLD:
                    Parsed += ANSICodes.SetMode(ANSICodes.Modes.Bold);
                    break;
                case Tags.UNDERLINE:
                    Parsed += ANSICodes.SetMode(ANSICodes.Modes.Underline);
                    break;
                case Tags.COLOR:
                    Parsed += ANSICodes.SetColor(currentForeColor);
                    break;
                case Tags.BACKCOLOR:
                    Parsed += ANSICodes.SetBackColor(currentBackColor);
                    break;
                case Tags.ACTION:
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
                    if (attributeName == "FORECOLOR") ColorTags(context);
                    if (attributeName == "BACKCOLOR") ColorTags(context, true);
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
                    break;
                case Tags.UNKNOWN:
                default:
                    break;
            }
        }
        private void ColorTags(IParseTree t, bool isBack = false)
        {
            string colorName = t.GetChild(2).GetText().Trim('"').Trim().ToUpper();
            if (isBack)
            {
                ANSICodes.Colors color = currentBackColor;
                ANSICodes.ColorTable.TryGetValue(colorName, out color);
                Parsed += ANSICodes.SetBackColor(color);
            }
            else
            {
                ANSICodes.Colors color = currentForeColor;
                ANSICodes.ColorTable.TryGetValue(colorName, out color);
                Parsed += ANSICodes.SetColor(color);
            }
        }

        public override void EnterBbsCodeChardata([NotNull] BBSCodeParser.BbsCodeChardataContext context)
        {
            Parsed += context.GetText();
        }
    }
}
