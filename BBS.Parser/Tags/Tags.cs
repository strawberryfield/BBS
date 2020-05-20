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
    /// <summary>
    /// Available tags
    /// </summary>
    public enum Tags
    {
        /// <summary>
        /// Defines the header section
        /// </summary>
        HEADER,
        /// <summary>
        /// Defines the footer section
        /// </summary>
        FOOTER,
        /// <summary>
        /// Defines the body section
        /// </summary>
        BODY,
        /// <summary>
        /// Defines an hidden section
        /// </summary>
        HIDDEN,
        /// <summary>
        /// Clears the screen
        /// </summary>
        CLS, 
        /// <summary>
        /// Sets blink mode for the text
        /// </summary>
        BLINK,
        /// <summary>
        /// Sets reverse mode for the text
        /// </summary>
        REVERSE,
        /// <summary>
        /// Sets bold mode for the text
        /// </summary>
        BOLD,
        /// <summary>
        /// Sets underline mode for the text
        /// </summary>
        UNDERLINE,
        /// <summary>
        /// Sets the color for the text
        /// </summary>
        COLOR,
        /// <summary>
        /// Sets the color for the background
        /// </summary>
        BACKCOLOR,
        /// <summary>
        /// Writes text with giant characters
        /// </summary>
        FIGGLE, 
        /// <summary>
        /// Sounds on the terminal
        /// </summary>
        BEEP, 
        /// <summary>
        /// Draws a row
        /// </summary>
        HR, 
        /// <summary>
        /// Defines a paragraph
        /// </summary>
        P,
        /// <summary>
        /// Defines Header level 1
        /// </summary>
        H1,
        /// <summary>
        /// Defines Header level 2
        /// </summary>
        H2,
        /// <summary>
        /// Defines Header level 3
        /// </summary>
        H3,
        /// <summary>
        /// Defines Header level 4
        /// </summary>
        H4,
        /// <summary>
        /// Move cursor on terminal
        /// </summary>
        MOVE,
        /// <summary>
        /// Defines a <see cref="BBSCodeResult.Action"/>
        /// </summary>
        ACTION
    }

    /// <summary>
    /// Dictionary of the tags
    /// </summary>
    public class TagsDict
    {
        private static Dictionary<string, Tags> TagsTable; 

        /// <summary>
        /// Constructor
        /// </summary>
        public TagsDict()
        {
            TagsTable = new Dictionary<string, Tags>();
            foreach (Tags t in Enum.GetValues(typeof(Tags)))
                TagsTable.Add(t.ToString().ToUpper(), t);
        }

        /// <summary>
        /// Tries to get a tag by its name
        /// </summary>
        /// <param name="tagname"></param>
        /// <param name="tag"></param>
        /// <returns>True if tag is found</returns>
        public bool TryGetValue(string tagname, out Tags tag) =>
            TagsTable.TryGetValue(tagname, out tag);
    }
}
