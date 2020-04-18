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
using Casasoft.TCPServer;
using Microsoft.Extensions.Hosting;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Casasoft.BBS.Daemon
{
    public class Worker : BackgroundService
    {

        public Worker()
        {
            ServerGlobal.Server = new Server(IPAddress.Any);
            ServerGlobal.Server.ClientConnected += clientConnected;
            ServerGlobal.Server.ClientDisconnected += clientDisconnected;
            ServerGlobal.Server.MessageReceived += clientHandleMessage;
        }

        private static void clientConnected(IClient c)
        {
            EventLogger.Write("CONNECTED: #" + c.id.ToString(), c.Remote);
            c.screen = ScreenFactory.Create(c, ServerGlobal.Server, "Banner");
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

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(1000, stoppingToken);
            }
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            ServerGlobal.Server.start();
            EventLogger.Write("SERVER STARTED");
            await base.StartAsync(cancellationToken);
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            EventLogger.Write("SERVER STOPPED");
            ServerGlobal.Server.stop();
            await base.StopAsync(cancellationToken);
        }

    }
}
