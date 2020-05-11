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
using Casasoft.BBS.Interfaces;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace Casasoft.BBS.Parser
{
    public class BBSCodeTranslator
    {
        private IBBSClient client;
        private IServer server;

        public BBSCodeTranslator(IBBSClient c, IServer s)
        {
            client = c;
            server = s;
        }

        public BBSCodeResult GetProcessed(string FileName)
        {
            BBSCodeResult ret = new BBSCodeResult();

            using (StreamReader fileStream = new StreamReader(GetFile(FileName)))
            {
                AntlrInputStream inputStream = new AntlrInputStream(fileStream);
                BBSCodeLexer lexer = new BBSCodeLexer(inputStream);
                CommonTokenStream tokenStream = new CommonTokenStream(lexer);
                BBSCodeParser parser = new BBSCodeParser(tokenStream);
                BBSCodeParser.BbsCodeContentContext context = parser.bbsCodeContent();
                BBSCodeListener listener = new BBSCodeListener(client, server, FileName);
                ParseTreeWalker walker = new ParseTreeWalker();
                bool built = parser.BuildParseTree;
                walker.Walk(listener, context);
                ret = listener.Parsed;
            }
            return ret;
        }

        /// <summary>
        /// Returns complete pathname of the file
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GetFile(string data)
        {
            if (data.Length < 2) return string.Empty;
            string assets = ConfigurationManager.AppSettings.Get("assets");
            if (data[0] == '@')
            {
                NameValueCollection texts = (NameValueCollection)ConfigurationManager.GetSection("Texts");
                return Path.Combine(assets, texts[data.Substring(1)]);
            }
            else
            {
                return Path.Combine(assets, data);
            }
        }

    }
}
