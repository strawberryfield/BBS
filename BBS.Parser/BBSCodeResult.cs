﻿// copyright (c) 2020 Roberto Ceccarelli - CasaSoft
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

using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Casasoft.BBS.Parser
{
    public class BBSCodeResult
    {
        public string Parsed;

        public class Action
        {
            public string module;
            public string data;

            public Action()
            {
                module = "TextScreen";
                data = string.Empty;
            }

        }

        public Dictionary<string, Action> Actions;

        public BBSCodeResult()
        {
            Parsed = string.Empty;
            Actions = new Dictionary<string, Action>();
        }

        public string[] GetRows()
        {
            return Regex.Split(Parsed, "\r\n");
        }
    }
}