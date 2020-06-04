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
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Casasoft.TCPServer
{
    public class Server : IServer
    {
        /// <summary>
        /// Telnet's default port.
        /// </summary>
        private int port = 23;
        /// <summary>
        /// End of line constant.
        /// </summary>
        public const string END_LINE = "\r\n";
        public const string CURSOR = " > ";

        /// <summary>
        /// Server's main socket.
        /// </summary>
        private Socket serverSocket;
        /// <summary>
        /// The IP on which to listen.
        /// </summary>
        private IPAddress ip;
        /// <summary>
        /// The default data size for received data.
        /// </summary>
        private readonly int dataSize;
        /// <summary>
        /// Contains the received data.
        /// </summary>
        private byte[] data;
        /// <summary>
        /// True for allowing incoming connections;
        /// false otherwise.
        /// </summary>
        private bool acceptIncomingConnections;
        /// <summary>
        /// Contains all connected clients indexed
        /// by their socket.
        /// </summary>
        public Dictionary<Socket, IClient> clients { get; private set; }

        public delegate void BBSConnectionEventHandler(IBBSClient c);
        /// <summary>
        /// Occurs when a client is connected.
        /// </summary>
        public event BBSConnectionEventHandler ClientConnected;
        public delegate void ConnectionEventHandler(IClient c);
        /// <summary>
        /// Occurs when a client is disconnected.
        /// </summary>
        public event ConnectionEventHandler ClientDisconnected;
        public delegate void ConnectionBlockedEventHandler(IPEndPoint endPoint);
        /// <summary>
        /// Occurs when an incoming connection is blocked.
        /// </summary>
        public event ConnectionBlockedEventHandler ConnectionBlocked;
        public delegate void MessageReceivedEventHandler(IBBSClient c, string message);
        /// <summary>
        /// Occurs when a message is received.
        /// </summary>
        public event MessageReceivedEventHandler MessageReceived;

        public delegate void ControlCharReceivedEventHandler(IBBSClient c, byte[] data, int bytesReceived);
        /// <summary>
        /// Occurs when a control character is received.
        /// </summary>
        public event ControlCharReceivedEventHandler ControlCharReceived;

        private int inactivityTimeout;

        /// <summary>
        /// Initializes a new instance of the <see cref="Server"/> class.
        /// </summary>
        /// <param name="ip">The IP on which to listen to.</param>
        /// <param name="dataSize">Data size for received data.</param>
        public Server(IPAddress ip, int dataSize = 1024)
        {
            this.ip = ip;

            this.dataSize = dataSize;
            this.data = new byte[dataSize];

            this.clients = new Dictionary<Socket, IClient>();

            this.acceptIncomingConnections = true;

            this.serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            NameValueCollection netconfig = (NameValueCollection)ConfigurationManager.GetSection("Networking");
            this.port = Convert.ToInt32(netconfig["port"]);
            this.inactivityTimeout = Convert.ToInt32(netconfig["InactivityTimeout"]);
        }

        /// <summary>
        /// Starts the server.
        /// </summary>
        public void start()
        {
            serverSocket.Bind(new IPEndPoint(ip, port));
            serverSocket.Listen(0);
            serverSocket.BeginAccept(new AsyncCallback(handleIncomingConnection), serverSocket);
        }

        /// <summary>
        /// Stops the server.
        /// </summary>
        public void stop() => serverSocket.Close();
     
        /// <summary>
        /// Returns whether incoming connections
        /// are allowed.
        /// </summary>
        /// <returns>True is connections are allowed;
        /// false otherwise.</returns>
        public bool incomingConnectionsAllowed() => acceptIncomingConnections;

        /// <summary>
        /// Denies the incoming connections.
        /// </summary>
        public void denyIncomingConnections() => acceptIncomingConnections = false;

        /// <summary>
        /// Allows the incoming connections.
        /// </summary>
        public void allowIncomingConnections() => acceptIncomingConnections = true;

        /// <summary>
        /// Clears the screen for the specified
        /// client.
        /// </summary>
        /// <param name="c">The client on which
        /// to clear the screen.</param>
        public void clearClientScreen(IClient c) => sendMessageToClient(c, "\u001B[1J\u001B[H");

        /// <summary>
        /// Sends a text message to the specified
        /// client.
        /// </summary>
        /// <param name="c">The client.</param>
        /// <param name="message">The message.</param>
        public void sendMessageToClient(IClient c, string message)
        {
            Socket clientSocket = getSocketByClient(c);
            sendMessageToSocket(clientSocket, message);
        }

        /// <summary>
        /// Sends a text message to the specified
        /// socket.
        /// </summary>
        /// <param name="s">The socket.</param>
        /// <param name="message">The message.</param>
        private void sendMessageToSocket(Socket s, string message)
        {
            byte[] data = Encoding.ASCII.GetBytes(message);
            sendBytesToSocket(s, data);
        }

        /// <summary>
        /// Sends bytes to the specified socket.
        /// </summary>
        /// <param name="s">The socket.</param>
        /// <param name="data">The bytes.</param>
        private void sendBytesToSocket(Socket s, byte[] data) =>
            s.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(sendData), s);

        /// <summary>
        /// Sends a message to all connected clients.
        /// </summary>
        /// <param name="message">The message.</param>
        public void sendMessageToAll(string message)
        {
            foreach (Socket s in clients.Keys)
            {
                try
                {
                    Client c = (Client)clients[s];

                    if (c.status == EClientStatus.LoggedIn)
                    {
                        sendMessageToSocket(s, END_LINE + message + END_LINE);
                        c.resetReceivedData();
                    }
                }

                catch
                {
                    clients.Remove(s);
                }
            }
        }

        /// <summary>
        /// Gets the client by socket.
        /// </summary>
        /// <param name="clientSocket">The client's socket.</param>
        /// <returns>If the socket is found, the client instance
        /// is returned; otherwise null is returned.</returns>
        private Client getClientBySocket(Socket clientSocket)
        {
            IClient c;

            if (!clients.TryGetValue(clientSocket, out c))
                c = null;

            return (Client)c;
        }

        /// <summary>
        /// Gets the socket by client.
        /// </summary>
        /// <param name="client">The client instance.</param>
        /// <returns>If the client is found, the socket is
        /// returned; otherwise null is returned.</returns>
        private Socket getSocketByClient(IClient client) =>
            clients.FirstOrDefault(x => x.Value.id == client.id).Key;

        /// <summary>
        /// Kicks the specified client from the server.
        /// </summary>
        /// <param name="client">The client.</param>
        public void kickClient(IClient client)
        {
            closeSocket(getSocketByClient(client));
            ClientDisconnected(client);
        }

        /// <summary>
        /// Closes the socket and removes the client from
        /// the clients list.
        /// </summary>
        /// <param name="clientSocket">The client socket.</param>
        private void closeSocket(Socket clientSocket)
        {
            clientSocket.Close();
            clients.Remove(clientSocket);
        }

        /// <summary>
        /// Handles an incoming connection.
        /// If incoming connections are allowed,
        /// the client is added to the clients list
        /// and triggers the client connected event.
        /// Else, the connection blocked event is
        /// triggered.
        /// </summary>
        private void handleIncomingConnection(IAsyncResult result)
        {
            try
            {
                Socket oldSocket = (Socket)result.AsyncState;

                if (acceptIncomingConnections)
                {
                    Socket newSocket = oldSocket.EndAccept(result);

                    uint clientID = (uint)clients.Count + 1;
                    Client client = new Client(clientID, (IPEndPoint)newSocket.RemoteEndPoint);
                    clients.Add(newSocket, client);

                    // Start negotiation
                    sendBytesToSocket(newSocket, Negotiation.Do(Negotiation.Operations.Echo));
                    sendBytesToSocket(newSocket, Negotiation.Do(Negotiation.Operations.RemoteFlowControl));
                    sendBytesToSocket(newSocket, Negotiation.Will(Negotiation.Operations.Echo));
                    sendBytesToSocket(newSocket, Negotiation.Will(Negotiation.Operations.SuppressGoAhead));
                    sendBytesToSocket(newSocket, Negotiation.Will(Negotiation.Operations.BinaryTransmission));
                    sendBytesToSocket(newSocket, Negotiation.Do(Negotiation.Operations.NegotiateAboutWindowSize));
                    sendBytesToSocket(newSocket, Negotiation.Do(Negotiation.Operations.TerminalType));

                    client.resetReceivedData();

                    ClientConnected(client);

                    serverSocket.BeginAccept(new AsyncCallback(handleIncomingConnection), serverSocket);
                }

                else
                {
                    ConnectionBlocked((IPEndPoint)oldSocket.RemoteEndPoint);
                }
            }

            catch { }
        }

        /// <summary>
        /// Sends data to a socket.
        /// </summary>
        private void sendData(IAsyncResult result)
        {
            try
            {
                Socket clientSocket = (Socket)result.AsyncState;

                clientSocket.EndSend(result);

                clientSocket.BeginReceive(data, 0, dataSize, SocketFlags.None, new AsyncCallback(receiveData), clientSocket);
            }

            catch { }
        }

        /// <summary>
        /// Receives and processes data from a socket.
        /// It triggers the message received event in
        /// case the client pressed the return key.
        /// </summary>
        private void receiveData(IAsyncResult result)
        {
            try
            {
                Socket clientSocket = (Socket)result.AsyncState;
                Client client = getClientBySocket(clientSocket);

                int bytesReceived = clientSocket.EndReceive(result);

                if (bytesReceived == 0)
                {
                    closeSocket(clientSocket);
                    ClientDisconnected(client);
                    serverSocket.BeginAccept(new AsyncCallback(handleIncomingConnection), serverSocket);
                }
                else if (data[0] == (byte)Negotiation.Tokens.IAC)
                {
                    // Negotiation
                    int offset = 0;
                    while (offset < bytesReceived)
                    {
                        Negotiation.HandleBinary(data, offset, client);
                        Negotiation.HandleWindowSize(data, offset, client);
                        if (Negotiation.ClientWillTerminalType(data, offset))
                            sendBytesToSocket(clientSocket, Negotiation.AskForTerminalType());
                        if (Negotiation.HandleTerminalType(data, offset, client))
                            sendBytesToSocket(clientSocket, Negotiation.AskForTerminalType());
                        while(++offset < bytesReceived)
                        {
                            if (data[offset] == (byte)Negotiation.Tokens.IAC) break;
                        }
                        
                    }
                    clientSocket.BeginReceive(data, 0, dataSize, SocketFlags.None, new AsyncCallback(receiveData), clientSocket);
                }
                else if (data[0] < 0xF0)
                {
                    string receivedData = client.receivedData;
                    client.lastActivity = DateTime.Now;

                    // 0x2E = '.', 0x0D = carriage return, 0x0A = new line
                    if ((data[0] == 0x2E && data[1] == 0x0D && receivedData.Length == 0) ||
                        (data[0] == 0x0D && data[1] == 0x0A) || data[0] == 0x0D || data[0] == 0x0A)
                    {
                        //sendMessageToSocket(clientSocket, "\u001B[1J\u001B[H");
                        MessageReceived(client, client.receivedData);
                        client.resetReceivedData();
                    }

                    else
                    {
                        // 0x08 => backspace character
                        if (data[0] == 0x08)
                        {
                            if (receivedData.Length > 0)
                            {
                                client.removeLastCharacterReceived();
                                sendBytesToSocket(clientSocket, new byte[] { 0x08, 0x20, 0x08 });
                            }

                            else
                                clientSocket.BeginReceive(data, 0, dataSize, SocketFlags.None, new AsyncCallback(receiveData), clientSocket);
                        }

                        // 0x7F => delete character
                        else if (data[0] == 0x7F)
                            clientSocket.BeginReceive(data, 0, dataSize, SocketFlags.None, new AsyncCallback(receiveData), clientSocket);
                        else if (data[0] < 0x20)
                            ControlCharReceived(client, data, bytesReceived);
                        else
                        {
                            client.appendReceivedData(Encoding.ASCII.GetString(data, 0, bytesReceived));

                            // Echo back the received character
                            // if client is not writing any password
                            if (client.inputMode != EInputMode.PasswordMode)
                                sendBytesToSocket(clientSocket, new byte[] { data[0] });

                            // Echo back asterisks if client is
                            // writing a password
                            else
                                sendMessageToSocket(clientSocket, "*");

                            clientSocket.BeginReceive(data, 0, dataSize, SocketFlags.None, new AsyncCallback(receiveData), clientSocket);
                        }
                    }
                }

                else
                    clientSocket.BeginReceive(data, 0, dataSize, SocketFlags.None, new AsyncCallback(receiveData), clientSocket);
            }

            catch { }
        }

        /// <summary>
        /// Clears the last input on terminal
        /// </summary>
        /// <param name="c"></param>
        public void ClearLastInput(IClient c)
        {
            Socket s = getSocketByClient(c);
            int nChar = c.receivedData.Length;
            byte[] seq = new byte[nChar *3 ];
            for(int j = 0; j < nChar; j++)
            {
                seq[j] = 0x08;
                seq[j + nChar] = 0x20;
                seq[j + nChar * 2] = 0x08;
            }
            sendBytesToSocket(s, seq);
        }

        #region watchdog
        /// <summary>
        /// Checks if is inactive for a time greater then configured
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        private bool testClientTimeout(IClient c) => (DateTime.Now - c.lastActivity).TotalSeconds > inactivityTimeout;

        /// <summary>
        /// Scans all clients and kills inactive ones
        /// </summary>
        public void clearInactiveSockets()
        {
            foreach (KeyValuePair<Socket, IClient> sc in clients)
            {
                if (testClientTimeout(sc.Value))
                {
                    ClientDisconnected(sc.Value);
                    closeSocket(sc.Key);
                }
            }
        }
        #endregion

    }

}