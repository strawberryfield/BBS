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

using Casasoft.BBS.Interfaces;
using Casasoft.TextHelpers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Casasoft.BBS.UI
{
    /// <summary>
    /// Shows a raw text file
    /// </summary>
    public class RawTextScreen : TextScreenBase
    {
        #region constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public RawTextScreen(IBBSClient c, IServer s) : base(c, s) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public RawTextScreen(IBBSClient c, IServer s, IScreen prev) : base(c, s, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        public RawTextScreen(IBBSClient c, IServer s, string txt) : base(c, s, txt) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public RawTextScreen(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev) { }
        #endregion

        /// <summary>
        /// Reads the text and stores it in lists of lines
        /// </summary>
        /// <param name="name">File to load</param>
        protected override void ReadText(string name)
        {
            Data = new Parser.BBSCodeResult();
            List<string> txt;
            if (TextHelper.IsUrl(name))
            {
                WebClient webClient = new WebClient();
                txt = TextHelper.SplitString(webClient.DownloadString(name));
            }
            else
                txt = File.ReadAllLines(GetFile(name)).ToList();

            foreach(string s in txt)
            {
                if(s.Length <= client.screenWidth)
                    Text.Add(s);
                else
                    Text.AddRange(TextHelper.WordWrap(s, client.screenWidth));
            }
            Footer.Add(string.Empty);
        }

    }
}
