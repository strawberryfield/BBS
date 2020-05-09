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
using Casasoft.BBS.Parser;

namespace Casasoft.BBS.UI
{
    public class ScreenBase : IScreen
    {
        protected IBBSClient client;
        protected IServer server;
        protected ANSICodes ANSI;
        public IScreen Previous { get; set; }

        #region constructors
        public ScreenBase(IBBSClient c, IServer s) : this(c,s,null) { }
        public ScreenBase(IBBSClient c, IServer s, IScreen prev)
        {
            client = c;
            server = s;
            Previous = prev;
            ANSI = new ANSICodes();
        }
        #endregion

        public virtual void Show() { }
        public virtual void HandleMessage(string msg) { }
        public virtual void HandleChar(char ch) { }
        public virtual void ShowNext() { }

        protected void Write(string s) => server.sendMessageToClient(client, s);
        protected void Writeln(string s) => Write(s + "\r\n");
        protected void Writeln() => Write("\r\n");
        protected void LnWrite(string s) => Write("\r\n" + s);

        protected void MoveTo(int row, int col) => Write(ANSI.Move(col, row));

        protected void ClearLine(int row)
        {
            MoveTo(row, 1);
            Write(new string(' ', client.screenWidth));
        }
    }
}
