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

using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;

namespace Casasoft.BBS.UI
{
    public class TextScreenBase : ScreenBase
    {
        protected string[] Text;
        protected void ReadText(string name)
        {
            string assets = ConfigurationManager.AppSettings.Get("assets");
            NameValueCollection texts = (NameValueCollection)ConfigurationManager.GetSection("Texts");
            string filename = Path.Combine(assets, texts[name]);
            Text = File.ReadAllLines(filename);
        }

        public override IScreen Show()
        {
            Console.Clear();
            ShowText();
            return null;
        }

        protected void ShowText()
        {
            int currentLine = ShowLines(0,24);
            bool inLoop = true;
            while(inLoop)
            {
                ConsoleKeyInfo k = Console.ReadKey(true);
                switch(k.KeyChar)
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
            for(;ret < start+len && ret < Text.Length; ++ret)
            {
                Console.WriteLine(Text[ret]);
            }
            return ret;
        }
    }
}
