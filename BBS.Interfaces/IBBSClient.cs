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

namespace Casasoft.BBS.Interfaces
{
    public interface IBBSClient : IClient
    {
        /// <summary>
        /// Active form
        /// </summary>
        public IScreen screen { get; set; }

        /// <summary>
        /// Current screen columns
        /// </summary>
        public int screenWidth { get; set; }

        /// <summary>
        /// Current screen rows
        /// </summary>
        public int screenHeight { get; set; }

        /// <summary>
        /// Client has negotiated binary mode
        /// </summary>
        public bool BinaryMode { get; set; }

        /// <summary>
        /// Current terminal type
        /// </summary>
        public string terminalType { get; set; }

        /// <summary>
        /// List of terminal types avaliable on client
        /// </summary>
        public List<string> terminalTypeCapable { get; set; }

        /// <summary>
        /// Tries to add unique values to the list
        /// </summary>
        /// <param name="tt">string to insert</param>
        /// <returns>true if insert is successful</returns>
        public bool TryAddTerminalType(string tt);

        /// <summary>
        /// Client preferred locale
        /// </summary>
        public string locale { get; set; }
    }
}
