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
using Casasoft.HudsonBase;
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
            Console.WriteLine("Casasoft ObjectMatrix/NET 0.1");
            Console.WriteLine("copyright (c) 2020 Roberto Ceccarelli - Casasoft\n");

            List<string> extra;

            bool shouldShowHelp = false;
            string packet = string.Empty;
            string outfile = string.Empty;
            string messagebase = "Internal";
            FidoAddress myAddress = new FidoAddress();
            FidoAddress destAddress = new FidoAddress();
            OptionSet options = new OptionSet()
            {
                { "t|toss-packet=", "Network domain to use",                n => packet = n },
                { "p|packet-for=",  "Create packet for this address",       a => destAddress = new FidoAddress(a) },
                { "a|my-address=",  "Local 5D fidonet address",             a => myAddress = new FidoAddress(a) },
                { "o|output-file=", "Output filename",                      o => outfile = o },
                { "messagebase=",   "Internal (default) or Hudson",         b => messagebase = b },
                { "h|help",         "show this message and exit",           h => shouldShowHelp = h != null },
            };

            try
            {
                extra = options.Parse(args);
            }
            catch (OptionException e)
            {
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
                toss(packet, myAddress);
                return;
            }

            if(destAddress.net != 0)
            {
                if (messagebase.ToUpper() == "HUDSON")
                    packHudson(destAddress, myAddress, outfile);
                else
                    pack(destAddress, myAddress, outfile);

                return;
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

        private static void toss(string packetFile, FidoAddress addr)
        {
            byte[] rawpkt = File.ReadAllBytes(packetFile);
            BBSMsgPacket pkt = new BBSMsgPacket(rawpkt);
            pkt.Toss(addr.domain);
        }

        private static void packHudson(FidoAddress destAddress, FidoAddress myAddress, string outfile)
        {
            Messages mb = new Messages();
            MsgPacket pkt = new MsgPacket();
            pkt.dest = destAddress;
            pkt.orig = myAddress;
            foreach (MsgHdr.MsgHdrRecord h in mb.Headers.Data)
                pkt.Messages.Add(new HudsonPackedMessage(mb, h.MsgNum));
            File.WriteAllBytes(outfile, pkt.Binary);
        }

        private static void pack(FidoAddress destAddress, FidoAddress myAddress, string outfile)
        {

        }
    }
}
