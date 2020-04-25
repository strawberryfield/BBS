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

using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Casasoft.BBS.Parser
{
    public class BBSCodeResult
    {
        public string Parsed;

        public class Action
        {
            public string module;
            public string data;
            public string requires;

            public Action()
            {
                module = "TextScreen";
                data = string.Empty;
                requires = string.Empty;
            }
        }

        public Dictionary<string, Action> Actions;
        private Stack<string> tagsTextStack;

        public BBSCodeResult()
        {
            Parsed = string.Empty;
            Actions = new Dictionary<string, Action>();
            tagsTextStack = new Stack<string>();
        }

        public List<string> GetRows() => Regex.Split(Parsed.Replace("\r", ""), "\n").ToList();

        public void TextClear()
        {
            Parsed = string.Empty;
            tagsTextStack.Clear();
        }

        public void TextConcat(string s) => Parsed += s;
        public void TextConcat(char c) => Parsed += c;

        public void TextPush()
        {
            tagsTextStack.Push(Parsed);
            Parsed = string.Empty;
        }

        public void TextPop(bool concat) => Parsed = tagsTextStack.Pop() + (concat ? Parsed : string.Empty);
        
    }
}
