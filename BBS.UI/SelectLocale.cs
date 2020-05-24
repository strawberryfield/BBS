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

using Casasoft.BBS.DataTier;
using Casasoft.BBS.DataTier.DataModel;
using Casasoft.BBS.Interfaces;
using Casasoft.TextHelpers;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace Casasoft.BBS.UI
{
    /// <summary>
    /// Selection of locale
    /// </summary>
    class SelectLocale : ListScreenBase
    {
        #region constructors
        private const string defaultText = "@SelectLocale";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public SelectLocale(IBBSClient c, IServer s) : this(c, s, defaultText, null) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public SelectLocale(IBBSClient c, IServer s, IScreen prev) : this(c, s, defaultText, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        public SelectLocale(IBBSClient c, IServer s, string txt) : this(c, s, txt, null) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public SelectLocale(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev)
        {
            InitCatalog();
        }
        #endregion

        private Dictionary<string, string> codes;

        /// <summary>
        /// Fills the available locales list
        /// </summary>
        protected override void AddList()
        {
            string[] locales = Directory.GetDirectories(ConfigurationManager.AppSettings["locale"]);
            codes = new Dictionary<string, string>();
            foreach (string s in locales)
            {
                string desc = File.ReadAllText(Path.Combine(s, "locale.txt"));
                string code = Path.GetFileName(s);
                Text.Add(TextHelper.Truncate(string.Format("{0,-5} {1}",
                    code, desc), client.screenWidth));
                codes.Add(code.ToUpper(), code);
            }
        }

        /// <summary>
        /// Changes the local for the session and the user (if logged in)
        /// </summary>
        /// <param name="msg"></param>
        public override void HandleMessage(string msg)
        {
            base.HandleMessage(msg);
            string l;
            if(codes.TryGetValue(msg.ToUpper(), out l))
            {
                locale = l;
                if(client.status == EClientStatus.LoggedIn)
                {
                    using(bbsContext bbs = new bbsContext())
                    {
                        User user = bbs.GetUserByUsername(client.username);
                        user.Locale = locale;
                        bbs.SaveChanges();
                    }
                }
            }
        }
    }
}
