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
    public enum Tags
    {
        CLS, BLINK, REVERSE, BOLD, UNDERLINE, COLOR, BACKCOLOR,
        FIGGLE, BEEP, HR, CONNECTED, JOINED, USER, P,
        ACTION
    }

    public class TagsDict
    {
        public static Dictionary<string, Tags> TagsTable { get; private set; }

        public TagsDict()
        {
            TagsTable = new Dictionary<string, Tags>();
            foreach (Tags t in Enum.GetValues(typeof(Tags)))
                TagsTable.Add(t.ToString().ToUpper(), t);
        }

        public bool TryGetValue(string tagname, out Tags tag) =>
            TagsTable.TryGetValue(tagname, out tag);
    }
}
