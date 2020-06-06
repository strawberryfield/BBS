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

namespace Casasoft.Fidonet
{
    /// <summary>
    /// 4D Fidonet address handler
    /// </summary>
    public class FidoAddress
    {
        /// <summary>
        /// zone
        /// </summary>
        public ushort zone { get; set; }

        /// <summary>
        /// net
        /// </summary>
        public ushort net { get; set; }

        /// <summary>
        /// node
        /// </summary>
        public ushort node { get; set; }

        /// <summary>
        /// point
        /// </summary>
        public ushort point { get; set; }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public FidoAddress()
        {
            zone = 0;
            net = 0;
            node = 0;
            point = 0;
        }

    }
}
