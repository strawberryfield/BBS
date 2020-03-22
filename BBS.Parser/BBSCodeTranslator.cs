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

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.IO;

namespace Casasoft.BBS.Parser
{
    public class BBSCodeTranslator
    {
        public string GetProcessed(string FileName)
        {
            string ret = string.Empty;

            using (StreamReader fileStream = new StreamReader(FileName))
            {
                AntlrInputStream inputStream = new AntlrInputStream(fileStream);
                BBSCodeLexer lexer = new BBSCodeLexer(inputStream);
                CommonTokenStream tokenStream = new CommonTokenStream(lexer);
                BBSCodeParser parser = new BBSCodeParser(tokenStream);
                BBSCodeParser.BbsCodeContentContext context = parser.bbsCodeContent();
                BBSCodeListener listener = new BBSCodeListener();
                ParseTreeWalker walker = new ParseTreeWalker();
                bool built = parser.BuildParseTree;
                walker.Walk(listener, context);
                ret = listener.Parsed;
            }
            return ret;
        }
    }
}
