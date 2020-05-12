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
using System.Linq;

namespace Casasoft.BBS.DataTier.DataModel
{
    /// <summary>
    /// mail message entity
    /// </summary>
    public partial class Message
    {
        /// <summary>
        /// Test if a message is posted after the datetime
        /// </summary>
        /// <param name="since">reference timestamp</param>
        /// <returns></returns>
        public bool IsNew(DateTime since) => DateTime >= since;

        /// <summary>
        /// Test if the user has already read the message
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool IsRead(string username) => MessageReads.Select(u => u.UserId).Contains(username);
    }
}
