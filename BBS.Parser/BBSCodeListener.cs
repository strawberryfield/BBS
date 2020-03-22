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

namespace Casasoft.BBS.Parser
{
    public class BBSCodeListener : BBSCodeParserBaseListener
    {
        public string Parsed { get; private set; }

        public BBSCodeListener() : base()
        {
            Parsed = string.Empty;
        }

        public override void EnterBbsCodeElement([NotNull] BBSCodeParser.BbsCodeElementContext context)
        {
            string tag = context.children[1].GetText().Trim().ToUpper();
            if (tag == "CLS") Parsed += "\u001b[2J";
        }

        public override void EnterBbsCodeChardata([NotNull] BBSCodeParser.BbsCodeChardataContext context)
        {
            Parsed += context.GetText();
        }
    }
}
