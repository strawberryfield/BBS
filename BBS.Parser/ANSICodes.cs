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
    public class ANSICodes
    {
        public enum Colors { Black, Red, Green, Yellow, Blue, Magenta, Cyan, White }

        private Colors defaultForeColor = Colors.White;
        private Colors defaultBackColor = Colors.Black;

        private Stack<Colors> foreColorStack;
        private Stack<Colors> backColorStack;

        public Colors GetColorByName(string name, bool isBack = false)
        {
            Colors color = isBack ? defaultBackColor : defaultForeColor;
            ColorTable.TryGetValue(name.Trim('"').Trim().ToUpper(), out color);
            return color;
        }

        public enum Modes { Normal, Bold, Underline = 4, Blink, Reverse = 7 }
        public const byte ModeNormal = 0b00000000;
        public const byte ModeBold = 0b00000010;
        public const byte ModeUnderline = 0b00000100;
        public const byte ModeBlink = 0b00001000;
        public const byte ModeReverse = 0b00010000;

        public string ModeFromBits(byte status)
        {
            string ret = "0;";
            if ((status & ModeBold) != 0) ret += string.Format("{0};",(int)Modes.Bold);
            if ((status & ModeUnderline) != 0) ret += string.Format("{0};", (int)Modes.Underline);
            if ((status & ModeBlink) != 0) ret += string.Format("{0};", (int)Modes.Blink);
            if ((status & ModeReverse) != 0) ret += string.Format("{0};", (int)Modes.Reverse);
            return ret;
        }

        public byte BitsFromMode(Modes m)
        {
            if (m == Modes.Bold) return ModeBold;
            if (m == Modes.Underline) return ModeUnderline;
            if (m == Modes.Blink) return ModeBlink;
            if (m == Modes.Reverse) return ModeReverse;
            return ModeNormal;
        }

        public byte BitsFromMode(int m) => BitsFromMode((Modes)m);

        public Dictionary<string, Colors> ColorTable;
        private byte currentMode;

        public ANSICodes()
        {
            ColorTable = new Dictionary<string, Colors>();
            foreach (Colors color in Enum.GetValues(typeof(Colors)))
                ColorTable.Add(color.ToString().ToUpper(), color);
            currentMode = 0;

            NameValueCollection appearance = (NameValueCollection)ConfigurationManager.GetSection("Appearance");
            ColorTable.TryGetValue(appearance["ForeColor"].ToUpper(), out defaultForeColor);
            ColorTable.TryGetValue(appearance["BackColor"].ToUpper(), out defaultBackColor);

            foreColorStack = new Stack<Colors>();
            backColorStack = new Stack<Colors>();
            resetColorStack();
        }

        public void resetColorStack()
        {
            foreColorStack.Clear();
            foreColorStack.Push(defaultForeColor);
            backColorStack.Clear();
            backColorStack.Push(defaultBackColor);
        }

        public void pushForeColor(Colors c) => foreColorStack.Push(c);
        public void pushForeColor(string name) => pushForeColor(GetColorByName(name));
        public void pushBackColor(Colors c) => backColorStack.Push(c);
        public void pushBackColor(string name) => pushBackColor(GetColorByName(name, true));

        public Colors popForeColor() => foreColorStack.Pop();
        public Colors popBackColor() => backColorStack.Pop();

        public string ClearScreen() => WriteMode() + "\u001b[2J" + Home();

        public string Move(byte x, byte y) => string.Format("\u001b[{0};{1}f", x, y);

        public string Home() => Move(0, 0);

        public void ClearMode()
        {
            currentMode = 0;
            resetColorStack();
        }

        public void SetMode(int m) => currentMode |= BitsFromMode(m);
        public void SetMode() => SetMode((int)0);
        public void SetMode(Modes m) => SetMode((int)m);

        public void ResetMode(Modes m) => currentMode &= (byte)~BitsFromMode(m);


        public int peekForeColor() => (int)foreColorStack.Peek() + 30;
        public int peekBackColor() => (int)backColorStack.Peek() + 40;
        public string WriteMode() =>
            string.Format("\u001b[{0}{1};{2}m", ModeFromBits(currentMode),  peekForeColor(), peekBackColor());
    }
}
