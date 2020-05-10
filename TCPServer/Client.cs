// copyright (c) 2020 Roberto Ceccarelli - CasaSoft
// http://strawberryfield.altervista.org 
//
// original work from https://gist.github.com/UngarMax/6394321573dc0791dff9
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

using Casasoft.BBS.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;

namespace Casasoft.TCPServer
{
    /// <summary>
    /// Client parameters storage
    /// </summary>
    public class Client : IBBSClient
    {
        /// <summary>
        /// The client's identifier.
        /// </summary>
        public uint id { get; set; }
        /// <summary>
        /// The client's remote address.
        /// </summary>
        public IPEndPoint remoteAddr { get; set; }
        /// <summary>
        /// The connection datetime.
        /// </summary>
        public DateTime connectedAt { get; set; }
        /// <summary>
        /// The client's current status.
        /// </summary>
        public EClientStatus status { get; set; }
        /// <summary>
        /// The last received data from the client.
        /// </summary>
        public string receivedData { get; set; }

        /// <summary>
        /// User logged in
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// Active form
        /// </summary>
        public IScreen screen { get; set; }

        /// <summary>
        /// last user activity timestamp
        /// </summary>
        public DateTime lastActivity { get; set; }

        /// <summary>
        /// Current screen columns
        /// </summary>
        public int screenWidth { get; set; }

        /// <summary>
        /// Current screen rows
        /// </summary>
        public int screenHeight { get; set; }

        /// <summary>
        /// Current terminal type
        /// </summary>
        public string terminalType { get; set; }

        /// <summary>
        /// List of terminal types avaliable on client
        /// </summary>
        public List<string> terminalTypeCapable { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="clientId">The client's identifier.</param>
        /// <param name="remoteAddress">The remote address.</param>
        public Client(uint clientId, IPEndPoint remoteAddress)
        {
            this.id = clientId;
            this.remoteAddr = remoteAddress;
            this.connectedAt = DateTime.Now;
            this.status = EClientStatus.Guest;
            this.receivedData = string.Empty;
            this.username = string.Empty;
            this.lastActivity = DateTime.Now;
            screenWidth = 80;
            screenHeight = 24;
            terminalType = string.Empty;
            terminalTypeCapable = new List<string>();
        }

        /// <summary>
        /// Appends a string to the client's last
        /// received data.
        /// </summary>
        /// <param name="dataToAppend">The data to append.</param>
        public void appendReceivedData(string dataToAppend)
        {
            this.receivedData += dataToAppend;
        }

        /// <summary>
        /// Removes the last character from the
        /// client's last received data.
        /// </summary>
        public void removeLastCharacterReceived()
        {
            receivedData = receivedData.Substring(0, receivedData.Length - 1);
        }

        /// <summary>
        /// Resets the last received data.
        /// </summary>
        public void resetReceivedData()
        {
            receivedData = string.Empty;
        }

        /// <summary>
        /// Formatted remote ip and port
        /// </summary>
        public string Remote { get => string.Format("{0}:{1}", remoteAddr.Address.ToString(), remoteAddr.Port); }

        public override string ToString() => string.Format("Client #{0} (From: {1}, Status: {2})", id, Remote, status);

        /// <summary>
        /// Tries to add unique values to the list
        /// </summary>
        /// <param name="tt">string to insert</param>
        /// <returns>true if insert is successful</returns>
        public bool TryAddTerminalType(string tt)
        {
            if (terminalTypeCapable.Contains(tt)) return false;
            terminalTypeCapable.Add(tt);
            return true;
        }
    }
}
