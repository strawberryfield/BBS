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
    public class ScreenBase : IScreen
    {
        protected IClient client;
        protected IServer server;
        public IScreen Previous { get; set; }

        public ScreenBase(IClient c, IServer s) : this(c,s,null) { }

        public ScreenBase(IClient c, IServer s, IScreen prev)
        {
            client = c;
            server = s;
            Previous = prev;
        }

        public virtual void Show() { }
        public virtual void HandleMessage(string msg) { }
        public virtual void HandleChar(char ch) { }
        public virtual void ShowNext() { }

        public void Write(string s) => server.sendMessageToClient(client, s);
        public void Writeln(string s) => Write(s + "\r\n");
        public void Writeln() => Write("\r\n");
        public void LnWrite(string s) => Write("\r\n" + s);

    }
}
