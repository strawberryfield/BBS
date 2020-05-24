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
using NGettext;
using System.Configuration;
using System.Globalization;

namespace Casasoft.BBS.UI
{
    /// <summary>
    /// Implements an empty base screen
    /// </summary>
    public class ScreenBase : IScreen
    {
        #region properties
        /// <summary>
        /// Reference to Telnet client
        /// </summary>
        protected IBBSClient client;

        /// <summary>
        /// Reference to Telnet server
        /// </summary>
        protected IServer server;

        /// <summary>
        /// Instance of ANSI utilities
        /// </summary>
        protected ANSICodes ANSI;
        
        /// <summary>
        /// Pointer to caller screen (if any)
        /// </summary>
        public IScreen Previous { get; set; }

        /// <summary>
        /// locale data
        /// </summary>
        protected ICatalog catalog;

        /// <summary>
        /// current locale
        /// </summary>
        protected string locale;
        #endregion

        #region constructors
        /// <summary>
        /// Constructor without link to caller
        /// </summary>
        /// <param name="c">Reference to client</param>
        /// <param name="s">Reference to server</param>
        public ScreenBase(IBBSClient c, IServer s) : this(c, s, null) { }
        
        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Reference to client</param>
        /// <param name="s">Reference to server</param>
        /// <param name="prev">Link to caller screen</param>
        public ScreenBase(IBBSClient c, IServer s, IScreen prev)
        {
            client = c;
            server = s;
            Previous = prev;
            ANSI = new ANSICodes();
            locale = string.IsNullOrWhiteSpace(c.locale) ? 
                ConfigurationManager.AppSettings["defaultLocale"] : c.locale;
        }
        #endregion

        /// <summary>
        /// loads locale data
        /// </summary>
        protected virtual void InitCatalog()
        {
            catalog = new Catalog("BBS.UI",
                ConfigurationManager.AppSettings["locale"],
                new CultureInfo(locale));
        }

        /// <summary>
        /// Empty implementation to ovverride in derived classes
        /// </summary>
        public virtual void Show() { }

        #region messages and control chars handling
        /// <summary>
        /// Empty implementation to ovverride in derived classes
        /// </summary>
        public virtual void HandleMessage(string msg) { }

        /// <summary>
        /// Launch of empty implementations of keys received handles
        /// </summary>
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

        /// <summary>
        /// Empty implementation to ovverride in derived classes
        /// </summary>
        public virtual void ShowNext() { }

        /// <summary>
        /// Empty implementation of Ctrl-C handler
        /// </summary>
        protected virtual void HandleControlC() { }

        /// <summary>
        /// Empty implementation of Tab handler
        /// </summary>
        protected virtual void HandleTab() { }

        /// <summary>
        /// Empty implementation of ESC handler
        /// </summary>
        protected virtual void HandleESC() { }

        /// <summary>
        /// Empty implementation of Cursor-Up handler
        /// </summary>
        protected virtual void HandleCursorUp() { }

        /// <summary>
        /// Empty implementation of Cursor-Down handler
        /// </summary>
        protected virtual void HandleCursorDown() { }

        /// <summary>
        /// Empty implementation of Cursor-Left handler
        /// </summary>
        protected virtual void HandleCursorLeft() { }

        /// <summary>
        /// Empty implementation of Cursor-Right handler
        /// </summary>
        protected virtual void HandleCursorRight() { }

        /// <summary>
        /// Empty implementation of Page-Up handler
        /// </summary>
        protected virtual void HandlePageUp() { }

        /// <summary>
        /// Empty implementation of Cursor-Down handler
        /// </summary>
        protected virtual void HandlePageDown() { }

        /// <summary>
        /// Empty implementation of Home handler
        /// </summary>
        protected virtual void HandleHome() { }

        /// <summary>
        /// Empty implementation of End handler
        /// </summary>
        protected virtual void HandleEnd() { }

        /// <summary>
        /// Empty implementation of F1 handler
        /// </summary>
        protected virtual void HandleF1() { }

        /// <summary>
        /// Empty implementation of F2 handler
        /// </summary>
        protected virtual void HandleF2() { }

        /// <summary>
        /// Empty implementation of F3 handler
        /// </summary>
        protected virtual void HandleF3() { }

        /// <summary>
        /// Empty implementation of F4 handler
        /// </summary>
        protected virtual void HandleF4() { }
        #endregion

        #region write
        /// <summary>
        /// Writes a string to the terminal
        /// </summary>
        /// <param name="s"></param>
        protected void Write(string s) => server.sendMessageToClient(client, s);

        /// <summary>
        /// Writes a string to the terminal follewed by a newline
        /// </summary>
        /// <param name="s"></param>
        protected void Writeln(string s) => Write(s + "\r\n");

        /// <summary>
        /// Writes a newline to the terminal
        /// </summary>
        protected void Writeln() => Write("\r\n");

        /// <summary>
        /// Writes a string to the terminal with a preceding newline
        /// </summary>
        /// <param name="s"></param>
        protected void LnWrite(string s) => Write("\r\n" + s);

        /// <summary>
        /// Moves the cursor in the terminal
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        protected void MoveTo(int row, int col) => Write(ANSI.Move(col, row));

        /// <summary>
        /// Clears a row in the terminal
        /// </summary>
        /// <param name="row"></param>
        protected void ClearLine(int row) => Write(ANSI.Move(1, row) + ANSI.ClearCurrentLine);
        #endregion
    }
}
