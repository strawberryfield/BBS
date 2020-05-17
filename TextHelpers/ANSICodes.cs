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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;

namespace Casasoft.BBS.Parser
{
    /// <summary>
    /// ANSI Sequences helper
    /// </summary>
    public class ANSICodes
    {
        #region colors
        /// <summary>
        /// basic coloror
        /// </summary>
        public enum Colors
        {
            Black, Red, Green, Yellow, Blue, Magenta, Cyan, LightGray,
            Gray, LightRed, LightGreen, LightYellow, LightBlue, LightMagenta, LightCyan, White
        }

        /// <summary>
        /// Default text color
        /// </summary>
        public Colors defaultForeColor { get; private set; }
        /// <summary>
        /// Default background color
        /// </summary>
        public Colors defaultBackColor { get; private set; }

        private Stack<Colors> foreColorStack;
        private Stack<Colors> backColorStack;
        private string peekForeColor() => ForeColorSeq(foreColorStack.Peek());
        private string peekBackColor() => BackColorSeq(backColorStack.Peek());
        private string ForeColorSeq(int color) {
            if (color > 7)
                return string.Format("38;5;{0}", color);
            else 
                return (color + 30).ToString();
        }
        private string BackColorSeq(int color)
        {
            if (color > 7)
                return string.Format("48;5;{0}", color);
            else
                return (color + 40).ToString();
        }
        private string ForeColorSeq(Colors color) => ForeColorSeq((int)color);
        private string BackColorSeq(Colors color) => BackColorSeq((int)color);

        /// <summary>
        /// Gets enum value from case insensitive string
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isBack">(optional) set if color is requested for background</param>
        /// <returns></returns>
        public Colors GetColorByName(string name, bool isBack = false)
        {
            Colors color;
            if (ColorTable.TryGetValue(name.Trim('"').Trim().ToUpper(), out color))
                return color;
            else
                return isBack ? defaultBackColor : defaultForeColor;
        }

        /// <summary>
        /// Contains the string to enum table
        /// </summary>
        public Dictionary<string, Colors> ColorTable;
        #endregion

        #region text modes
        /// <summary>
        /// Text modes
        /// </summary>
        public enum Modes { Normal, Bold, Underline = 4, Blink, Reverse = 7 }
        private const byte ModeNormal = 0b00000000;
        private const byte ModeBold = 0b00000010;
        private const byte ModeUnderline = 0b00000100;
        private const byte ModeBlink = 0b00001000;
        private const byte ModeReverse = 0b00010000;

        private string ModeFromBits(byte status)
        {
            string ret = "0;";
            if ((status & ModeBold) != 0) ret += string.Format("{0};", (int)Modes.Bold);
            if ((status & ModeUnderline) != 0) ret += string.Format("{0};", (int)Modes.Underline);
            if ((status & ModeBlink) != 0) ret += string.Format("{0};", (int)Modes.Blink);
            if ((status & ModeReverse) != 0) ret += string.Format("{0};", (int)Modes.Reverse);
            return ret;
        }

        private byte BitsFromMode(Modes m)
        {
            if (m == Modes.Bold) return ModeBold;
            if (m == Modes.Underline) return ModeUnderline;
            if (m == Modes.Blink) return ModeBlink;
            if (m == Modes.Reverse) return ModeReverse;
            return ModeNormal;
        }

        private byte BitsFromMode(int m) => BitsFromMode((Modes)m);

        private byte currentMode;
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public ANSICodes()
        {
            ColorTable = new Dictionary<string, Colors>();
            foreach (Colors color in Enum.GetValues(typeof(Colors)))
                ColorTable.Add(color.ToString().ToUpper(), color);
            currentMode = 0;

            Colors col;
            NameValueCollection appearance = (NameValueCollection)ConfigurationManager.GetSection("Appearance");
            defaultForeColor = ColorTable.TryGetValue(appearance["ForeColor"].ToUpper(), out col) ?
                col : Colors.White;

            defaultBackColor = ColorTable.TryGetValue(appearance["BackColor"].ToUpper(), out col) ?
                col : Colors.Black;

            foreColorStack = new Stack<Colors>();
            backColorStack = new Stack<Colors>();
            resetColorStack();
        }

        /// <summary>
        /// Resets the internal colors stacks
        /// </summary>
        public void resetColorStack()
        {
            foreColorStack.Clear();
            foreColorStack.Push(defaultForeColor);
            backColorStack.Clear();
            backColorStack.Push(defaultBackColor);
        }

        /// <summary>
        /// Push the color in the text color stack
        /// </summary>
        /// <param name="c">color by enum value</param>
        public void pushForeColor(Colors c) => foreColorStack.Push(c);
        /// <summary>
        /// Pushes the color in the text color stack
        /// </summary>
        /// <param name="name">color by name</param>
        public void pushForeColor(string name) => pushForeColor(GetColorByName(name));
        /// <summary>
        /// Pushes the color in the background color stack
        /// </summary>
        /// <param name="c">color by enum value</param>
        public void pushBackColor(Colors c) => backColorStack.Push(c);
        /// <summary>
        /// Pushes the color in the background color stack
        /// </summary>
        /// <param name="name">color by name</param>
        public void pushBackColor(string name) => pushBackColor(GetColorByName(name, true));

        /// <summary>
        /// Pops the color from the text color stack
        /// </summary>
        /// <returns></returns>
        public Colors popForeColor() => foreColorStack.Pop();
        /// <summary>
        /// Pops the color from the background color stack
        /// </summary>
        /// <returns></returns>
        public Colors popBackColor() => backColorStack.Pop();

        /// <summary>
        /// Returns the sequente to clear the screen
        /// </summary>
        /// <returns></returns>
        public string ClearScreen() => WriteMode() + "\u001b[2J" + Home();

        /// <summary>
        /// Sequence to move cursor to col /row
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public string Move(int col, int row) => string.Format("\u001b[{0};{1}f", row, col);
        /// <summary>
        /// Sequence to move cursor to col /row
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public string Move(string col, string row) => string.Format("\u001b[{0};{1}f", row, col);
        /// <summary>
        /// Sequence to move cursor to home (0,0)
        /// </summary>
        /// <returns></returns>
        public string Home() => Move(0, 0);

        /// <summary>
        /// Sequence to save cursor position on terminal
        /// </summary>
        public string SaveCursorPosition { get => "\u001b[s"; }
        /// <summary>
        /// Sequence to restore cursor position on terminal
        /// </summary>
        public string RestoreCursorPosition { get => "\u001b[u"; }

        /// <summary>
        /// Resets text modes stack
        /// </summary>
        public void ClearMode()
        {
            currentMode = 0;
            resetColorStack();
        }

        private void SetMode(int m) => currentMode |= BitsFromMode(m);
        /// <summary>
        /// Clears all text modes
        /// </summary>
        public void SetMode() => SetMode((int)0);
        /// <summary>
        /// Enables the text mode
        /// </summary>
        /// <param name="m">Text modes enum</param>
        public void SetMode(Modes m) => SetMode((int)m);
        /// <summary>
        /// Disables the text mode
        /// </summary>
        /// <param name="m">Text modes enum</param>
        public void ResetMode(Modes m) => currentMode &= (byte)~BitsFromMode(m);

        /// <summary>
        /// Returns sequence for current modes and colors
        /// </summary>
        /// <returns></returns>
        public string WriteMode() =>
            string.Format("\u001b[{0}{1};{2}m", ModeFromBits(currentMode), peekForeColor(), peekBackColor());

        /// <summary>
        /// Returns sequence for current text color
        /// </summary>
        /// <returns></returns>
        public string WriteForeColor() => string.Format("\u001b[{0}m", peekForeColor());
        /// <summary>
        /// Returns sequence for current backgroud color
        /// </summary>
        /// <returns></returns>
        public string WriteBackColor() => string.Format("\u001b[{0}m", peekBackColor());

        /// <summary>
        /// Returns sequence to select color
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public string WriteBackColor(int color) =>
            string.Format("\u001b[{0}m", BackColorSeq(color));

        /// <summary>
        /// Returns sequence to select color
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public string WriteBackColor(Colors color) => WriteBackColor((int)color);

        /// <summary>
        /// Sequence to clear current line
        /// </summary>
        public string ClearCurrentLine { get => "\u001b[2K"; }
    }
}
