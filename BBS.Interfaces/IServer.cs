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
using System.Net.Sockets;

namespace Casasoft.BBS.Interfaces
{
    public interface IServer
    {
        /// <summary>
        /// Starts the server.
        /// </summary>
        public void start();

        /// <summary>
        /// Stops the server.
        /// </summary>
        public void stop();

        /// <summary>
        /// Returns whether incoming connections
        /// are allowed.
        /// </summary>
        /// <returns>True is connections are allowed;
        /// false otherwise.</returns>
        public bool incomingConnectionsAllowed();

        /// <summary>
        /// Denies the incoming connections.
        /// </summary>
        public void denyIncomingConnections();

        /// <summary>
        /// Allows the incoming connections.
        /// </summary>
        public void allowIncomingConnections();

        /// <summary>
        /// Clears the screen for the specified
        /// client.
        /// </summary>
        /// <param name="c">The client on which
        /// to clear the screen.</param>
        public void clearClientScreen(IClient c);

        /// <summary>
        /// Sends a text message to the specified
        /// client.
        /// </summary>
        /// <param name="c">The client.</param>
        /// <param name="message">The message.</param>
        public void sendMessageToClient(IClient c, string message);

        /// <summary>
        /// Sends a message to all connected clients.
        /// </summary>
        /// <param name="message">The message.</param>
        public void sendMessageToAll(string message);

        /// <summary>
        /// Kicks the specified client from the server.
        /// </summary>
        /// <param name="client">The client.</param>
        public void kickClient(IClient client);

        /// <summary>
        /// Contains all connected clients indexed
        /// by their socket.
        /// </summary>
        public Dictionary<Socket, IClient> clients { get; }

        /// <summary>
        /// Clears the last input on terminal
        /// </summary>
        /// <param name="c"></param>
        public void ClearLastInput(IClient c);
    }
}
