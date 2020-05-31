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
    /// <summary>
    /// Base class for lists
    /// </summary>
    public class ListScreenBase : TextScreenBase
    {
        #region constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        public ListScreenBase(IBBSClient c, IServer s) : this(c, s, string.Empty, null) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="prev">Link to caller screen</param>
        public ListScreenBase(IBBSClient c, IServer s, IScreen prev) : this(c, s, string.Empty, prev) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        public ListScreenBase(IBBSClient c, IServer s, string txt) : this(c, s, txt, null) { }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="c">Client reference</param>
        /// <param name="s">Server reference</param>
        /// <param name="txt">Text to parse and optional parameters separated by semicolon</param>
        /// <param name="prev">Link to caller screen</param>
        public ListScreenBase(IBBSClient c, IServer s, string txt, IScreen prev) : base(c, s, txt, prev)
        {
            Text.Clear();
            AddList();
        }
        #endregion

        /// <summary>
        /// Empty virtual function where data lines will be added
        /// </summary>
        protected virtual void AddList() { }

        /// <summary>
        /// Resets active section to body
        /// </summary>
        /// <returns></returns>
        protected override int Redraw()
        {
            int ret = base.Redraw();
            MarkCurrentLine();
            return ret;
        }

        /// <summary>
        /// Disables focused background
        /// </summary>
        protected void UnMarkCurrentLine()
        {
            Write(ANSI.Move(0, currentScreenLine));
            setColorLine(currentScreenLine);
            Write(ANSI.ClearCurrentLine + Text[currentLine]);
        }

        /// <summary>
        /// Disables focused background
        /// </summary>
        protected void MarkCurrentLine()
        {
            Write(ANSI.Move(0, currentScreenLine) + ANSI.WriteBackColor(FocusedBackground) +
                ANSI.ClearCurrentLine + Text[currentLine] + ANSI.WriteMode() + ANSI.RestoreCursorPosition);
        }

        #region handle moves
        /// <summary>
        /// Implements Half-Page-Down Handler
        /// </summary>
        protected override void HandleHalfPageDown()
        {
            UnMarkCurrentLine();
            base.HandleHalfPageDown();
            MarkCurrentLine();
        }

        /// <summary>
        /// Implements Half-Page-Up Handler
        /// </summary>
        protected override void HandleHalfPageUp()
        {
            UnMarkCurrentLine();
            base.HandleHalfPageUp();
            MarkCurrentLine();
        }

        /// <summary>
        /// Implements Home Handler
        /// </summary>
        protected override void HandleHome()
        {
            UnMarkCurrentLine();
            base.HandleHome();
            MarkCurrentLine();
        }

        /// <summary>
        /// Implements End Handler
        /// </summary>
        protected override void HandleEnd()
        {
            UnMarkCurrentLine();
            base.HandleEnd();
            MarkCurrentLine();
        }

        /// <summary>
        /// Implements Page-Up Handler
        /// </summary>
        protected override void HandlePageUp()
        {
            UnMarkCurrentLine();
            base.HandlePageUp();
            MarkCurrentLine();
        }

        /// <summary>
        /// Implements Page-Down Handler
        /// </summary>
        protected override void HandlePageDown()
        {
            UnMarkCurrentLine();
            base.HandlePageDown();
            MarkCurrentLine();
        }

        /// <summary>
        /// Implements Cursor Up Handler
        /// </summary>
        protected override void HandleCursorUp()
        {
            UnMarkCurrentLine();
            base.HandleCursorUp();
            MarkCurrentLine();
        }

        /// <summary>
        /// Implements Cursor Down Handler
        /// </summary>
        protected override void HandleCursorDown()
        {
            UnMarkCurrentLine();
            base.HandleCursorDown();
            MarkCurrentLine();
        }
        #endregion
    }
}
