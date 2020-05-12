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
using System.Linq;
using System.Text.RegularExpressions;

namespace Casasoft.TextHelpers
{
    /// <summary>
    /// Paragraphs text alignment
    /// </summary>
    public enum TextAlign { Left, Right, Center, Both }

    /// <summary>
    /// Functions for text management
    /// </summary>
    public static class TextHelper
    {
        /// <summary>
        /// Returns the left part of a string without exception
        /// if the string is shorter then requested size
        /// </summary>
        /// <param name="s"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        static public string Truncate(string s, int size) => s.Substring(0, Math.Min(size, s.Length));

        /// <summary>
        /// returns a string composed of c repeated len times
        /// </summary>
        /// <param name="c"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        static public string HR(char c, int len) => new string(c, len);
        /// <summary>
        /// returns a string composed of c repeated 80 times
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        static public string HR(char c) => HR(c, 80);
        /// <summary>
        /// returns a string composed of '-' repeated 80 times
        /// </summary>
        /// <returns></returns>
        static public string HR() => HR('-');

        /// <summary>
        /// Left aligns the text in width columns 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        static public string LineAlign(string text, int width) => LineAlign(text, width, TextAlign.Left);
        /// <summary>
        /// Aligns the text in width columns
        /// </summary>
        /// <param name="text"></param>
        /// <param name="width"></param>
        /// <param name="align">alignment type</param>
        /// <returns></returns>
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

        /// <summary>
        /// Word wraps text in width columns 
        /// text is left aligned
        /// </summary>
        /// <param name="text"></param>
        /// <param name="width"></param>
        /// <returns>List of strings</returns>
        static public List<string> WordWrap(string text, int width) => WordWrap(text, width, TextAlign.Left);
        /// <summary>
        /// Word wraps text in width columns
        /// </summary>
        /// <param name="text"></param>
        /// <param name="width"></param>
        /// <param name="align">alignment mode</param>
        /// <returns>List of strings</returns>
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

        /// <summary>
        /// Splits a string to a list of string at newline (both Windows and Unix types)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static public List<string> SplitString(string s) =>
            Regex.Split(s.Replace("\r", ""), "\n").ToList();

        /// <summary>
        /// Tests if the string contains an url
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static public bool IsUrl(string s) => s.StartsWith("http://") || s.StartsWith("https://");
    }
}
