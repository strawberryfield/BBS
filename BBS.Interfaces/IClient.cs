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
using System.Net;

namespace Casasoft.BBS.Interfaces
{
    public enum EClientStatus
    {
        /// <summary>
        /// The client has not been
        /// authenticated yet.
        /// </summary>
        Guest = 0,
        /// <summary>
        /// The client is authenticating.
        /// </summary>
        Authenticating = 1,
        /// <summary>
        /// The client is logged in.
        /// </summary>
        LoggedIn = 2
    }

    public interface IClient
    {
        public void appendReceivedData(string dataToAppend);
        public void removeLastCharacterReceived();
        public void resetReceivedData();

        public uint id { get; set; }
        public IPEndPoint remoteAddr { get; set; }
        public DateTime connectedAt { get; set; }
        public DateTime lastActivity { get; set; }
        public EClientStatus status { get; set; }
        public string receivedData { get; set; }

        public string username { get; set; }
        public IScreen screen { get; set; }
        public string Remote { get; }
        public int screenWidth { get; set; }
        public int screenHeight { get; set; }

    }
}
