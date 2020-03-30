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
using System.Collections.Specialized;
using System.Configuration;

namespace Casasoft.BBS.Parser
{
    public class BBSCodeListener : BBSCodeParserBaseListener
    {
        public enum Tags { CLS, BLINK, REVERSE, BOLD, UNDERLINE, COLOR, BACKCOLOR }

        private ANSICodes.Colors currentForeColor = ANSICodes.Colors.White;
        private ANSICodes.Colors currentBackColor = ANSICodes.Colors.Black;

        public string Parsed { get; private set; }

        public BBSCodeListener() : base()
        {
            Parsed = string.Empty;
            NameValueCollection appearance = (NameValueCollection)ConfigurationManager.GetSection("Appearance");
            ANSICodes.ColorTable.TryGetValue(appearance["ForeColor"].ToUpper(), out currentForeColor);
            ANSICodes.ColorTable.TryGetValue(appearance["BackColor"].ToUpper(), out currentBackColor);
        }

        public override void EnterBbsCodeElement([NotNull] BBSCodeParser.BbsCodeElementContext context)
        {
            string tag = context.children[1].GetText().Trim().ToUpper();
            if (tag == Tags.CLS.ToString()) Parsed += ANSICodes.ClearScreen();
            DisplayModeTags(tag);
            if (tag == Tags.COLOR.ToString()) ColorTags(context.children[2]);
            if (tag == Tags.BACKCOLOR.ToString()) ColorTags(context.children[2]);
        }

        public override void ExitBbsCodeElement([NotNull] BBSCodeParser.BbsCodeElementContext context)
        {
            string tag = context.children[1].GetText().Trim().ToUpper();
            DisplayModeTags(tag);
            if (tag == Tags.COLOR.ToString()) Parsed += ANSICodes.SetColor(currentForeColor);
            if (tag == Tags.BACKCOLOR.ToString()) Parsed += ANSICodes.SetBackColor(currentBackColor);
        }

        private void DisplayModeTags(string tag)
        {
            if (tag == Tags.REVERSE.ToString()) Parsed += ANSICodes.SetMode(ANSICodes.Modes.Reverse);
            if (tag == Tags.BLINK.ToString()) Parsed += ANSICodes.SetMode(ANSICodes.Modes.Blink);
            if (tag == Tags.BOLD.ToString()) Parsed += ANSICodes.SetMode(ANSICodes.Modes.Bold);
            if (tag == Tags.UNDERLINE.ToString()) Parsed += ANSICodes.SetMode(ANSICodes.Modes.Underline);
        }

        private void ColorTags(IParseTree t, bool isBack = false)
        {
            string colorName = t.GetChild(2).GetText().Trim('"');
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
