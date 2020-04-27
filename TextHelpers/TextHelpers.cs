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
using System.Collections.Generic;

namespace Casasoft.TextHelpers
{
    public static class TextHelper
    {
        static public string Truncate(string s, int size) => s.Substring(0, Math.Min(size, s.Length));

        static public string HR(char c, int len) => new string(c, len);
        static public string HR(char c) => HR(c, 79);
        static public string HR() => HR('-');

        static public List<string> WordWrap(string text, int width)
        {
            List<string> ret = new List<string>();
            if (string.IsNullOrWhiteSpace(text)) return ret;

            string[] words = text.Split(new char[] { ' ', '\t', '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries);

            string line = string.Empty;
            foreach (string w in words)
            {
                if(line.Length + w.Length +1 > width)
                {
                    ret.Add(line);
                    line = w;
                }
                else
                {
                    line += " " + w;
                }
            }
            ret.Add(line);

            return ret;
        }
    }
}
