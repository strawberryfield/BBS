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

using Casasoft.BBS.Interfaces;
using Casasoft.BBS.Logger;
using Casasoft.BBS.UI;
using Casasoft.TCPServer;
using System;
using System.Net;

namespace Casasoft.BBS
{
    class Program
    {
        private static Server server;

        static void Main(string[] args)
        {
            server = new Server(IPAddress.Any);
            server.ClientConnected += clientConnected;
            server.ClientDisconnected += clientDisconnected;
            server.MessageReceived += clientHandleMessage;
            server.start();

            EventLogger.Write("SERVER STARTED");

            do
            {
            } while ((Console.ReadKey(true).KeyChar) != 'q');

            server.stop();
        }

        private static void clientConnected(IClient c)
        {
            EventLogger.Write("CONNECTED: #" + c.id.ToString(), c.Remote);
            c.screen = ScreenFactory.Create(c, server, "Banner");
            c.screen.Show();
        }

        private static void clientDisconnected(IClient c)
        {
            EventLogger.Write("DISCONNECTED: #" + c.id.ToString(), c.Remote);
        }

        private static void clientHandleMessage(IClient c, string msg)
        {
            c.screen.HandleMessage(msg);
        }

    }
}
