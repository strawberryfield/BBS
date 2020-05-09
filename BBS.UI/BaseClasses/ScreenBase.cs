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
        public ScreenBase(IBBSClient c, IServer s) : this(c, s, null) { }
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
        public virtual void HandleChar(byte[] data, int bytesReceived)
        {
            switch (data[0])
            {
                case 0x03:
                    HandleControlC();
                    break;
                case 0x09:
                    HandleTab();
                    break;
                case 0x1b:      // ESC
                    if (bytesReceived == 1) HandleESC();
                    else if (bytesReceived == 3 && data[1] == '[')
                    {
                        switch (data[2])
                        {
                            case 65:
                                HandleCursorUp();
                                break;
                            case 66:
                                HandleCursorDown();
                                break;
                            case 67:
                                HandleCursorRight();
                                break;
                            case 68:
                                HandleCursorLeft();
                                break;
                            default:
                                break;
                        }
                    }
                    else if (bytesReceived == 4 && data[1] == '[' && data[3] == 126)
                    {
                        switch (data[2])
                        {
                            case 53:
                                HandlePageUp();
                                break;
                            case 54:
                                HandlePageDown();
                                break;
                            case 49:
                                HandleHome();
                                break;
                            case 52:
                                HandleEnd();
                                break;
                            default:
                                break;
                        }
                    }
                    else if (bytesReceived == 3 && data[1] == 'O')
                    {
                        switch (data[2])
                        {
                            case 80:
                                HandleF1();
                                break;
                            case 81:
                                HandleF2();
                                break;
                            case 82:
                                HandleF3();
                                break;
                            case 83:
                                HandleF4();
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        public virtual void ShowNext() { }


        protected virtual void HandleControlC() { }
        protected virtual void HandleTab() { }
        protected virtual void HandleESC() { }
        protected virtual void HandleCursorUp() { }
        protected virtual void HandleCursorDown() { }
        protected virtual void HandleCursorLeft() { }
        protected virtual void HandleCursorRight() { }
        protected virtual void HandlePageUp() { }
        protected virtual void HandlePageDown() { }
        protected virtual void HandleHome() { }
        protected virtual void HandleEnd() { }
        protected virtual void HandleF1() { }
        protected virtual void HandleF2() { }
        protected virtual void HandleF3() { }
        protected virtual void HandleF4() { }

        protected void Write(string s) => server.sendMessageToClient(client, s);
        protected void Writeln(string s) => Write(s + "\r\n");
        protected void Writeln() => Write("\r\n");
        protected void LnWrite(string s) => Write("\r\n" + s);

        protected void MoveTo(int row, int col) => Write(ANSI.Move(col, row));

        protected void ClearLine(int row) => Write(ANSI.Move(1, row) + ANSI.ClearCurrentLine);
    }
}
