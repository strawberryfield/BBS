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
            await base.StartAsync(cancellationToken);
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            ServerGlobal.Server.stop();
            await base.StopAsync(cancellationToken);
        }

    }
}
