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
    /// <summary>
    /// List of attributes of a tag
    /// </summary>
    public class Attributes
    {
        private Dictionary<string, string> Dict;

        /// <summary>
        /// Constructor
        /// </summary>
        public Attributes()
        {
            Dict = new Dictionary<string, string>();
        }

        /// <summary>
        /// Tries to get a value from the dictionary
        /// </summary>
        /// <param name="attrName">attribute name</param>
        /// <param name="attrValue">returned value</param>
        /// <returns>true if get is successful</returns>
        public bool TryGetValue(string attrName, out string attrValue) =>
            Dict.TryGetValue(attrName, out attrValue);

        /// <summary>
        /// Tries to add a value to the dictionary
        /// </summary>
        /// <param name="attrName">attribute name</param>
        /// <param name="attrValue">attribute value</param>
        /// <returns>true if add is successful</returns>
        public bool TryAdd(string attrName, string attrValue) =>
            Dict.TryAdd(attrName, attrValue);
    }

    /// <summary>
    /// Attributes lists for every tag
    /// </summary>
    public class AttributesDict
    {
        private Dictionary<Tags, Attributes> AttributesTable;

        /// <summary>
        /// Constructor
        /// </summary>
        public AttributesDict()
        {
            AttributesTable = new Dictionary<Tags, Attributes>();
        }

        /// <summary>
        /// Adds an attribute for a tag
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="attrName">attribute name</param>
        /// <param name="attrValue">attribute value</param>
        public void Add(Tags tag, string attrName, string attrValue)
        {
            if (!AttributesTable.ContainsKey(tag))
                AttributesTable.Add(tag, new Attributes());

            Attributes currAttrlist;
            if (!AttributesTable.TryGetValue(tag, out currAttrlist)) return;
            currAttrlist.TryAdd(attrName, attrValue);
        }

        /// <summary>
        /// Gets the attributes list for a tag
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        /// <remarks>The returned list is removed from the dictionary</remarks>
        public Attributes GetAttributes(Tags tag)
        {
            Attributes ret; 
            if (AttributesTable.TryGetValue(tag, out ret))
                AttributesTable.Remove(tag);
            return ret == null ? new Attributes() : ret;
        }
    }
}
