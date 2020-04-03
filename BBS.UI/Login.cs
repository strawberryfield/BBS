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
            status = states.WaitForUsername;
        }

        private enum states { WaitForUsername, WaitForPassword }
        private states status;

        public override void Show()
        {
            base.Show();
            server.sendMessageToClient(client, "\r\nUsername: ");
            status = states.WaitForUsername;
        }

        private string username = string.Empty;
        public override void HandleMessage(string msg)
        {
            switch (status)
            {
                case states.WaitForUsername:
                    username = msg.Trim().ToUpper();
                    switch (username)
                    {
                        case "GUEST":
                            client.screen = new TextScreenBase(client, server, "GuestAccess");
                            client.screen.Show();
                            break;
                        case "NEW":
                            client.screen = new TextScreenBase(client, server, "NewUser");
                            client.screen.Show();
                            break;
                        default:
                            server.sendMessageToClient(client, "\r\nPassword: ");
                            status = states.WaitForPassword;
                            break;
                    }
                    break;
                case states.WaitForPassword:        
                    break;
                default:
                    break;
            }
            
        }

        
    }


}
