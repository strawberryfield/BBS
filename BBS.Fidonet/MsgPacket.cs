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

using System;
using System.Collections.Generic;

namespace Casasoft.BBS.Fidonet
{
    /// <summary>
    /// Handles a packet of messages
    /// </summary>
    /// <remarks>
    /// Format as described in FTSC-0001 <see cref="http://ftsc.org/docs/fts-0001.016"/>
    /// <code>
    ///                                 Packet Header
    ///     Offset
    ///    dec hex
    ///               .-----------------------------------------------.
    ///         0   0 | origNode(low order)  | origNode(high order)   |
    ///               +-----------------------+-----------------------+
    ///         2   2 | destNode(low order)  | destNode(high order)   |
    ///               +-----------------------+-----------------------+
    ///         4   4 |   year(low order)    |   year(high order)     |
    ///               +-----------------------+-----------------------+
    ///         6   6 |  month(low order)    |  month(high order)     |
    ///               +-----------------------+-----------------------+
    ///         8   8 |   day(low order)     |   day(high order)      |
    ///               +-----------------------+-----------------------+
    ///        10   A |   hour(low order)    |   hour(high order)     |
    ///               +-----------------------+-----------------------+
    ///        12   C |  minute(low order)   |  minute(high order)    |
    ///               +-----------------------+-----------------------+
    ///        14   E |  second(low order)   |  second(high order)    |
    ///               +-----------------------+-----------------------+
    ///        16  10 |   baud(low order)    |   baud(high order)     |
    ///               +-----------------------+-----------------------+
    ///        18  12 |    0     |     2      |    0      |    0      |
    ///               +-----------------------+-----------------------+
    ///        20  14 | origNet(low order)   | origNet(high order)    |
    ///               +-----------------------+-----------------------+
    ///        22  16 | destNet(low order)   | destNet(high order)    |
    ///               +-----------------------+-----------------------+
    ///        24  18 |       prodCode        |       serialNo        |
    ///               +-----------------------+-----------------------+
    ///        26  1A |                                               |
    ///               |             password(some impls)              |
    ///               |                  eight bytes                  |
    ///               |                  null padded                  |
    ///               |                                               |
    ///               +-----------------------+-----------------------+
    ///        34  22 | origZone(low) (opt)  | origZone(high) (opt)   |
    ///               +-----------------------+-----------------------+
    ///        36  24 | destZone(low) (opt)  | destZone(high) (opt)   |
    ///               +-----------------------+-----------------------+
    ///        38  26 |                     fill                      |
    ///               ~                   20 bytes                    ~
    ///               |                                               |
    ///               +-----------------------+-----------------------+
    ///        58  3A |                 zero or more                  |
    ///               ~                    packed                     ~
    ///               |                   messages                    |
    ///               +-----------------------+-----------------------+
    ///               |    0     |     0      |    0     |     0      |
    ///               `-----------------------+-----------------------'
    /// 
    /// 
    ///       Packet       = PacketHeader  { PakdMessage }  00H 00H
    /// 
    /// PacketHeader =       origNode(*of packet, not of messages in packet *)
    ///                      destNode(* of packet, not of messages in packet*)
    ///                      year(* of packet creation, e.g. 1986 *)
    ///                      month(* of packet creation, 0-11 for Jan-Dec*)
    ///                      day(* of packet creation, 1-31 *)
    ///                      hour(* of packet creation, 0-23 *)
    ///                      minute(* of packet creation, 0-59 *)
    ///                      second(* of packet creation, 0-59 *)
    ///                      baud(* max baud rate of orig and dest, 0=SEA*)
    ///                      PacketType(* old type-1 packets now obsolete*)
    ///                      origNet(* of packet, not of messages in packet*)
    ///                      destNet(* of packet, not of messages in packet*)
    ///                      prodCode(* 0 for Fido, write to FTSC for others*)
    ///                      serialNo(* binary serial number (otherwise null)*)
    ///                      password(* session password  (otherwise null)   *)
    ///                      origZone(* zone of pkt sender (otherwise null)  *)
    ///                      destZone(* zone of pkt receiver (otherwise null)*)
    ///                      fill[20]
    /// 
    ///       PacketType = 02H 00H(* 01H 00H was used by Fido versions before 10
    ///                                which did not support local nets.  The packed
    ///                                message header was also different for those
    ///                                versions *)
    /// 
    ///       prodCode     = (  00H(* Fido*)
    ///                      |  ...
    ///                      |  ??H(* Please apply for new codes*)
    ///                      )
    /// </code>
    /// </remarks>
    public class MsgPacket
    {
        /// <summary>
        /// FTSC Product code <see cref="http://ftsc.org/docs/ftscprod.019"/>
        /// </summary>
        /// <remarks>
        /// reused code assigned to Casasoft ObjectMatrix
        /// </remarks>
        public const byte ProductCode = 0xab;

        /// <summary>
        /// Fidonet address of node that creates the packet
        /// </summary>
        public FidoAddress orig { get; set; }

        /// <summary>
        /// Fidonet address of destination node
        /// </summary>
        public FidoAddress dest { get; set; }

        /// <summary>
        /// Packet creation timestamp
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Connections speed
        /// </summary>
        public ushort Baud { get; set; }

        /// <summary>
        /// Some implementation
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// List of Messages
        /// </summary>
        public List<PackedMessage> Messages { get; set; }

        public MsgPacket()
        {
            orig = new FidoAddress();
            dest = new FidoAddress();
            Timestamp = DateTime.Now;
            Baud = 64000;
            Password = string.Empty;
            Messages = new List<PackedMessage>();
        }
    }
}
