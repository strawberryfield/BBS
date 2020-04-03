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
using System.Net;

namespace Casasoft.TCPServer
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

    public class Client
    {
        /// <summary>
        /// The client's identifier.
        /// </summary>
        private uint id;
        /// <summary>
        /// The client's remote address.
        /// </summary>
        private IPEndPoint remoteAddr;
        /// <summary>
        /// The connection datetime.
        /// </summary>
        private DateTime connectedAt;
        /// <summary>
        /// The client's current status.
        /// </summary>
        private EClientStatus status;
        /// <summary>
        /// The last received data from the client.
        /// </summary>
        private string receivedData;
        public IScreen screen;

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
        }

        /// <summary>
        /// Gets the client identifier.
        /// </summary>
        /// <returns>Client's identifier.</returns>
        public uint getClientID()
        {
            return id;
        }

        /// <summary>
        /// Gets the remote address.
        /// </summary>
        /// <returns>Client's remote address.</returns>
        public IPEndPoint getRemoteAddress()
        {
            return remoteAddr;
        }

        /// <summary>
        /// Gets the connection time.
        /// </summary>
        /// <returns>The connection time.</returns>
        public DateTime getConnectionTime()
        {
            return connectedAt;
        }

        /// <summary>
        /// Gets the client's current status.
        /// </summary>
        /// <returns>The client's status.</returns>
        public EClientStatus getCurrentStatus()
        {
            return status;
        }

        /// <summary>
        /// Gets the client's last received data.
        /// </summary>
        /// <returns>Client's last received data.</returns>
        public string getReceivedData()
        {
            return receivedData;
        }

        /// <summary>
        /// Sets the client's current status.
        /// </summary>
        /// <param name="newStatus">The new status.</param>
        public void setStatus(EClientStatus newStatus)
        {
            this.status = newStatus;
        }

        /// <summary>
        /// Sets the client's last received data.
        /// </summary>
        /// <param name="newReceivedData">The new received data.</param>
        public void setReceivedData(string newReceivedData)
        {
            this.receivedData = newReceivedData;
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

        public string Remote { get => string.Format("{0}:{1}", remoteAddr.Address.ToString(), remoteAddr.Port); }

        public override string ToString() => string.Format("Client #{0} (From: {1}, Status: {2})", id, Remote, status);

    }
}
