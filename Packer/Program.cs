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

using Casasoft.Fidonet;
using Mono.Options;
using System;
using System.Collections.Generic;
using System.IO;

namespace Casasoft.BBS.Packer
{
    class Program
    {
        private static string exeName = "Packer.exe"; 

        static void Main(string[] args)
        {
            List<string> extra;

            var shouldShowHelp = false;
            var domain = string.Empty;
            var packet = string.Empty;
            OptionSet options = new OptionSet()
            {
                { "d|domain=",      "Network domain to use",                n => domain = n },
                { "t|toss-packet=", "Network domain to use",                n => packet = n },
                { "h|help",         "show this message and exit",           h => shouldShowHelp = h != null },
            };

            try
            {
                extra = options.Parse(args);
            }
            catch (OptionException e)
            {
                Console.Write($"{exeName}: ");
                Console.WriteLine(e.Message);
                Console.WriteLine($"Try `{exeName} --help' for more information.");
                return;
            }

            if (shouldShowHelp)
            {
                ShowHelp(options);
                return;
            }

            if(!string.IsNullOrWhiteSpace(packet))
            {
                toss(packet, domain);
            }
        }

        private static void ShowHelp(OptionSet p)
        {
            Console.WriteLine($"Usage: {exeName} [OPTIONS]");
            Console.WriteLine("Create or toss a fidonet messages packet");
            Console.WriteLine();
            Console.WriteLine("Options:");
            p.WriteOptionDescriptions(Console.Out);
        }

        private static void toss(string packetFile, string domain)
        {
            byte[] rawpkt = File.ReadAllBytes(packetFile);
            MsgPacket pkt = new MsgPacket(rawpkt);
        }
    }
}
