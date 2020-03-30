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

namespace Casasoft.BBS.Parser
{
    public static class ANSICodes
    {
        public enum Colors { Black, Red, Green, Yellow, Blue, Magenta, Cyan, White }

        public enum Modes { Normal, Bold, Underline = 4, Blink, Reverse = 7 }
        public const byte ModeNormal = 0b00000000;
        public const byte ModeBold = 0b00000010;
        public const byte ModeUnderline = 0b00000100;
        public const byte ModeBlink = 0b00001000;
        public const byte ModeReverse = 0b00010000;

        public static string ModeFromBits(byte status)
        {
            string ret = SetMode();
            if ((status & ModeBold) != 0) ret += SetMode(Modes.Bold);
            if ((status & ModeUnderline) != 0) ret += SetMode(Modes.Underline);
            if ((status & ModeBlink) != 0) ret += SetMode(Modes.Blink);
            if ((status & ModeReverse) != 0) ret += SetMode(Modes.Reverse);
            return ret;
        }

        public static byte BitsFromMode(Modes m)
        {
            if (m == Modes.Bold) return ModeBold;
            if (m == Modes.Underline) return ModeUnderline;
            if (m == Modes.Blink) return ModeBlink;
            if (m == Modes.Reverse) return ModeReverse;
            return ModeNormal;
        }

        public static Dictionary<string, Colors> ColorTable;

        static ANSICodes()
        {
            ColorTable = new Dictionary<string, Colors>();
            foreach (Colors color in Enum.GetValues(typeof(Colors)))
                ColorTable.Add(color.ToString().ToUpper(), color);
        }

        public static string ClearScreen() => "\u001b[2J" + Home();

        public static string Move(byte x, byte y) => string.Format("\u001b[{0};{1}f", x, y);

        public static string Home() => Move(0, 0);

        public static string SetMode(int m) => string.Format("\u001b[{0}m", m);

        public static string SetMode() => SetMode((int)0);

        public static string SetMode(Modes m) => SetMode((int)m);

        public static string SetColor(Colors c) => SetMode((int)c + 30);

        public static string SetBackColor(Colors c) => SetMode((int)c + 40);

    }
}
