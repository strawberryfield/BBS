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

using Casasoft.BBS.Parser;
using Casasoft.TCPServer;
using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;

namespace Casasoft.BBS.UI
{
    public class TextScreenBase : ScreenBase
    {
        protected string[] Text;

        public TextScreenBase(Client c, Server s) : base(c, s) { }

        public void ReadText(string name)
        {
            string assets = ConfigurationManager.AppSettings.Get("assets");
            NameValueCollection texts = (NameValueCollection)ConfigurationManager.GetSection("Texts");
            string filename = Path.Combine(assets, texts[name]);
            BBSCodeTranslator translator = new BBSCodeTranslator();
            Text = Regex.Split(translator.GetProcessed(filename), "\r\n");
        }

        public override IScreen Show()
        {
            ShowText();
            return null;
        }

        protected void ShowText()
        {
            int currentLine = ShowLines(0, 24);
            bool inLoop = true;
            while (inLoop)
            {
                int k = Console.ReadKey().KeyChar;
                switch (k)
                {
                    case 'x':
                    case 'X':
                        inLoop = false;
                        break;
                    case '\r':
                        if (Text.Length > 24 && currentLine < Text.Length - 1)
                            ShowLines(currentLine - 23, 24);
                        break;
                    case ' ':
                        if (Text.Length > 24 && currentLine < Text.Length - 1)
                            ShowLines(currentLine, 24);
                        break;
                    case 'b':
                    case 'B':
                        if (Text.Length > 24 && currentLine > 23)
                        {
                            int newStart = currentLine - 48;
                            newStart = newStart < 0 ? 0 : newStart;
                            ShowLines(newStart, 24);
                        }
                        break;
                }
            }
        }


        protected int ShowLines(int start, int len)
        {
            int ret = start;
            for (; ret < start + len && ret < Text.Length; ++ret)
            {
                server.sendMessageToClient(client, Text[ret] + "\n");
            }
            return ret;
        }
    }
}
