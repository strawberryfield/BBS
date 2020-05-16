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

using Casasoft.TextHelpers;
using System.Collections.Generic;

namespace Casasoft.BBS.Parser
{
    /// <summary>
    /// Result of texts parsing
    /// </summary>
    public class BBSCodeResult
    {
        /// <summary>
        /// Current parsing result
        /// </summary>
        internal string Parsed { get; private set; }

        /// <summary>
        /// Body section parsed text
        /// </summary>
        public string Body;

        /// <summary>
        /// Header section parsed text
        /// </summary>
        public string Header;

        /// <summary>
        /// Footer section parsed text
        /// </summary>
        public string Footer;

        /// <summary>
        /// Background color of the Header
        /// </summary>
        public ANSICodes.Colors HeaderBackground { get; internal set; }

        /// <summary>
        /// Background color of the Footer
        /// </summary>
        public ANSICodes.Colors FooterBackground { get; internal set; }

        /// <summary>
        /// Alternative background color of the Body
        /// </summary>
        public ANSICodes.Colors BodyAlternateBackground { get; internal set; }

        /// <summary>
        /// Class for action's parameters
        /// </summary>
        public class Action
        {
            /// <summary>
            /// Module to activate
            /// </summary>
            public string module;
            
            /// <summary>
            /// Module parameters
            /// </summary>
            public string data;

            /// <summary>
            /// Required user group to access this action
            /// </summary>
            public string requires;
            
            /// <summary>
            /// Trigget key
            /// </summary>
            public string key;

            /// <summary>
            /// Base constructor
            /// </summary>
            public Action()
            {
                module = "TextScreen";
                data = string.Empty;
                requires = string.Empty;
                key = string.Empty;
            }

            /// <summary>
            /// Constructor from attributes
            /// </summary>
            /// <param name="attr">attributes list</param>
            public Action(Attributes attr) : this()
            {
                string value;
                if (attr.TryGetValue("MODULE", out value)) module = value;
                if (attr.TryGetValue("TEXT", out value)) data = value;
                if (attr.TryGetValue("REQUIRES", out value)) requires = value;
                if (attr.TryGetValue("KEY", out value)) key = value;
            }
        }

        /// <summary>
        /// List of available actions
        /// </summary>
        public Dictionary<string, Action> Actions { get; private set; }
        private Stack<string> tagsTextStack;

        /// <summary>
        /// Constructor
        /// </summary>
        public BBSCodeResult()
        {
            Parsed = string.Empty;
            Body = string.Empty;
            Header = string.Empty;
            Footer = string.Empty;
            Actions = new Dictionary<string, Action>();
            tagsTextStack = new Stack<string>();
        }


        /// <summary>
        /// Returns the rows of the body
        /// </summary>
        /// <returns></returns>
        public List<string> GetRows() => TextHelper.SplitString(Body);

        /// <summary>
        /// Returns the rows of the header
        /// </summary>
        /// <returns></returns>
        public List<string> GetHeaderRows() => TextHelper.SplitString(Header);

        /// <summary>
        /// Returns the rows of the footer
        /// </summary>
        /// <returns></returns>
        public List<string> GetFooterRows() => TextHelper.SplitString(Footer);

        /// <summary>
        /// Clears the current parsed text
        /// </summary>
        public void TextClear()
        {
            Parsed = string.Empty;
            tagsTextStack.Clear();
        }

        /// <summary>
        /// First assignation of parsed text
        /// </summary>
        /// <param name="s"></param>
        public void TextAssign(string s) => Parsed = s;

        /// <summary>
        /// Concat parsed text
        /// </summary>
        /// <param name="s"></param>
        public void TextConcat(string s) => Parsed += s;

        /// <summary>
        /// Concat parsed text
        /// </summary>
        /// <param name="s"></param>
        public void TextConcat(char c) => Parsed += c;

        /// <summary>
        /// Pushes text to the internal stack
        /// </summary>
        public void TextPush()
        {
            tagsTextStack.Push(Parsed);
            Parsed = string.Empty;
        }

        /// <summary>
        /// Pops text from the internal text
        /// </summary>
        /// <param name="concat"></param>
        public void TextPop(bool concat) => 
            Parsed = tagsTextStack.Pop() + (concat ? Parsed : string.Empty);
        
    }
}
