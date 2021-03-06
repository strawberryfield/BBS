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

using System;
using System.Net;

namespace Casasoft.BBS.Interfaces
{
    /// <summary>
    /// Current login status
    /// </summary>
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

    /// <summary>
    /// Modes of input handling
    /// </summary>
    public enum EInputMode
    {
        /// <summary>
        /// A line of text is sent to the client when return is pressed
        /// </summary>
        LineMode,
        /// <summary>
        /// Any single char is sent to the client
        /// </summary>
        CharMode,
        /// <summary>
        /// Like linemode, but echo is masked
        /// </summary>
        PasswordMode
    }

    public interface IClient
    {
        /// <summary>
        /// Appends a string to the client's last
        /// received data.
        /// </summary>
        /// <param name="dataToAppend">The data to append.</param>
        public void appendReceivedData(string dataToAppend);

        /// <summary>
        /// Removes the last character from the
        /// client's last received data.
        /// </summary>
        public void removeLastCharacterReceived();

        /// <summary>
        /// Resets the last received data.
        /// </summary>
        public void resetReceivedData();

        /// <summary>
        /// The client's identifier.
        /// </summary>
        public uint id { get; set; }
 
        /// <summary>
        /// The client's remote address.
        /// </summary>
        public IPEndPoint remoteAddr { get; set; }
        
        /// <summary>
        /// Connection timestamp
        /// </summary>
        public DateTime connectedAt { get; set; }
        
        /// <summary>
        /// last user activity timestamp
        /// </summary>
        public DateTime lastActivity { get; set; }
 
        /// <summary>
        /// The client's current status.
        /// </summary>
        public EClientStatus status { get; set; }

        /// <summary>
        /// The client's current input mode.
        /// </summary>
        public EInputMode inputMode { get; set; }

        /// <summary>
        /// The last received data from the client.
        /// </summary>
        public string receivedData { get; set; }

        /// <summary>
        /// User logged in
        /// </summary>
        public string username { get; set; }
        
        /// <summary>
        /// Formatted remote ip and port
        /// </summary>
        public string Remote { get; }        
    }
}
