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

namespace Casasoft.BBS.UI
{
    public class Banner : TextScreenBase
    {
        #region constructors
        private const string defaultText = "@Banner";
        public Banner(IBBSClient c, IServer s) : base(c, s, defaultText) { }
        public Banner(IBBSClient c, IServer s, string txt) : base(c, s, txt) { }
        public Banner(IBBSClient c, IServer s, IScreen prev) : base(c, s, defaultText, prev) { }
        public Banner(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev) { }
        #endregion

        public override void ShowNext()
        {
            client.screen = ScreenFactory.Create(client, server, "LoginScreen");
            client.screen.Show();
        }
    }
}
