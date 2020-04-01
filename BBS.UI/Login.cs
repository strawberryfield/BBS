using Casasoft.TCPServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Casasoft.BBS.UI
{
    public class Login : TextScreenBase
    {
        public Login(Client c, Server s) : base(c, s)
        {
            ReadText("Login");
        }

        public override IScreen Show()
        {
            base.Show();
            server.sendMessageToClient(client, "Username: ");
            string user = client.getReceivedData();
            server.sendMessageToClient(client, "Password: ");
            string pwd = client.getReceivedData();
            return null;
        }
    }


}
