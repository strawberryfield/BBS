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

using System.Collections.Generic;

namespace Casasoft.BBS.Parser
{
    public class Attributes
    {
        public Dictionary<string, string> Dict;

        public Attributes()
        {
            Dict = new Dictionary<string, string>();
        }

        public bool TryGetValue(string attrName, out string attrValue) =>
            Dict.TryGetValue(attrName, out attrValue);

        public bool TryAdd(string attrName, string attrValue) =>
            Dict.TryAdd(attrName, attrValue);
    }

    public class AttributesDict
    {
        public Dictionary<Tags, Attributes> AttributesTable { get; private set; }

        public AttributesDict()
        {
            AttributesTable = new Dictionary<Tags, Attributes>();
        }

        public void Add(Tags tag, string attrName, string attrValue)
        {
            if (!AttributesTable.ContainsKey(tag))
                AttributesTable.Add(tag, new Attributes());

            Attributes currAttrlist;
            if (!AttributesTable.TryGetValue(tag, out currAttrlist)) return;
            currAttrlist.TryAdd(attrName, attrValue);
        }

        public Attributes GetAttributes(Tags tag)
        {
            Attributes ret = new Attributes();
            if (AttributesTable.TryGetValue(tag, out ret))
                AttributesTable.Remove(tag);
            return ret;
        }
    }
}
