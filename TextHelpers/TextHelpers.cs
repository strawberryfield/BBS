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
    public enum TextAlign { Left, Right, Center, Both }

    public static class TextHelper
    {
        static public string Truncate(string s, int size) => s.Substring(0, Math.Min(size, s.Length));

        static public string HR(char c, int len) => new string(c, len);
        static public string HR(char c) => HR(c, 79);
        static public string HR() => HR('-');

        static public string LineAlign(string text, int width) => LineAlign(text, width, TextAlign.Left);
        static public string LineAlign(string text, int width, TextAlign align)
        {
            text = text.Trim();
            if (text.Length >= width) return text;
            switch (align)
            {
                case TextAlign.Left:
                    return text;
                case TextAlign.Right:
                    return text.PadLeft(width);
                case TextAlign.Center:
                    int leftPadding = (width - text.Length) / 2;
                    int rightPadding = width - text.Length - leftPadding;
                    return new string(' ', leftPadding) + text + new string(' ', rightPadding);
                case TextAlign.Both:
                    int missingSpaces = width - text.Length;
                    string[] words = text.Split(' ');
                    int breaks = words.Length - 1;
                    int quotient = missingSpaces / breaks;
                    int reminder = missingSpaces % breaks;
                    string ret = string.Empty;
                    for (int j = 0; j < breaks; j++)
                        ret += words[j] + new string(' ', 1 + quotient + (j < reminder ? 1 : 0));
                    return ret + words[breaks];
                default:
                    return text;
            }
        }

        static public List<string> WordWrap(string text, int width) => WordWrap(text, width, TextAlign.Left);
        static public List<string> WordWrap(string text, int width, TextAlign align)
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
                    ret.Add(LineAlign(line, width, align));
                    line = w;
                }
                else
                {
                    line += " " + w;
                }
            }
            ret.Add(LineAlign(line, width, align == TextAlign.Both ? TextAlign.Left : align));

            return ret;
        }
    }
}
