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
using System.Diagnostics;

namespace Casasoft.Fidonet
{
    /// <summary>
    /// Handles a message in format suitable for packets
    /// </summary>
    /// <remarks>
    /// Format as described in FTSC-0001 <see cref="http://ftsc.org/docs/fts-0001.016"/>
    /// <code>
    ///       Offset
    ///       dec hex
    ///              .-----------------------------------------------.
    ///        0   0 |    0     |     2      |    0      |    0      |
    ///              +-----------------------+-----------------------+
    ///        2   2 | origNode (low order)  | origNode (high order) |
    ///              +-----------------------+-----------------------+
    ///        4   4 | destNode (low order)  | destNode (high order) |
    ///              +-----------------------+-----------------------+
    ///        6   6 | origNet (low order)   | origNet (high order)  |
    ///              +-----------------------+-----------------------+
    ///        8   8 | destNet (low order)   | destNet (high order)  |
    ///              +-----------------------+-----------------------+
    ///       10   A | Attribute (low order) | Attribute (high order)|
    ///              +-----------------------+-----------------------+
    ///       12   C |   cost (low order)    |   cost (high order)   |
    ///              +-----------------------+-----------------------+
    ///       14   E |                                               |
    ///              ~                    DateTime                   ~
    ///              |                    20 bytes                   |
    ///              +-----------------------+-----------------------+
    ///       34  22 |                  toUserName                   |
    ///              ~                  max 36 bytes                 ~
    ///              |                null terminated                |
    ///              +-----------------------+-----------------------+
    ///              |                 fromUserName                  |
    ///              ~                  max 36 bytes                 ~
    ///              |                null terminated                |
    ///              +-----------------------+-----------------------+
    ///              |                    subject                    |
    ///              ~                  max 72 bytes                 ~
    ///              |                null terminated                |
    ///              +-----------------------+-----------------------+
    ///              |                      text                     |
    ///              ~                    unbounded                  ~
    ///              |                 null terminated               |
    ///              `-----------------------------------------------'
    ///
    ///
    ///    Due to routing, the origin and destination net and node of a packet
    ///
    ///    are often quite different from those of the messages within it, nor
    ///    need  the origin and destination nets and nodes of the messages within
    ///    a packet be homogenous.
    ///
    ///    PakdMessage  = 02H 00H           (* message type, old type-1 obsolete*)
    ///                     origNode(* of message *)
    ///                     destNode(* of message *)
    ///                     origNet(* of message *)
    ///                     destNet(* of message *)
    ///                     AttributeWord
    ///                     cost(* in lowest unit of originator's
    ///                                          currency*)
    ///                     DateTime(* message body was last edited*)
    ///                     toUserName{36}    (* Null terminated *)
    ///                     fromUserName{36}  (* Null terminated *)
    ///                     subject{72}       (* Null terminated *)
    ///                     text{unbounded}   (* Null terminated *)
    ///
    /// </code>
    /// </remarks>
    public class PackedMessage
    {
        #region properties
        /// <summary>
        /// Fidonet address of node that creates the message
        /// </summary>
        public FidoAddress orig { get; set; }

        /// <summary>
        /// Fidonet address of destination node
        /// </summary>
        public FidoAddress dest { get; set; }

        /// <summary>
        /// Message attributes
        /// </summary>
        public MsgAttributes attr { get; set; }

        /// <summary>
        /// Cost of message
        /// </summary>
        public ushort Cost { get; set; }

        /// <summary>
        /// Sender user
        /// </summary>
        public string FromUser { get; set; }

        /// <summary>
        /// Destination user
        /// </summary>
        public string DestUser { get; set; }

        /// <summary>
        /// Date and time
        /// </summary>
        public string Timestamp { get; set; }

        /// <summary>
        /// Subject of the message
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Text of message
        /// </summary>
        public string Text { get; set; }
        #endregion

        /// <summary>
        /// Empty constructor
        /// </summary>
        public PackedMessage()
        {
            orig = new FidoAddress();
            dest = new FidoAddress();
            attr = new MsgAttributes();
            Cost = 0;
            FromUser = string.Empty;
            DestUser = string.Empty;
            Text = string.Empty;
            Timestamp = FidonetHelpers.FidoFormatDatetime(DateTime.Now);
        }

        /// <summary>
        /// build message from raw data
        /// </summary>
        /// <param name="rawdata"></param>
        public PackedMessage(byte[] rawdata) : this()
        {
            if (FidonetHelpers.GetUShort(rawdata, 0) != 2) return;

            orig.node = FidonetHelpers.GetUShort(rawdata, 2);
            dest.node = FidonetHelpers.GetUShort(rawdata, 4);
            orig.net = FidonetHelpers.GetUShort(rawdata, 6);
            dest.net = FidonetHelpers.GetUShort(rawdata, 8);
            attr = new MsgAttributes(FidonetHelpers.GetUShort(rawdata, 10));
            Cost = FidonetHelpers.GetUShort(rawdata, 12);
            Timestamp = FidonetHelpers.BytesToString(rawdata, 14, 20);

            int ptr = 34;
            DestUser = FidonetHelpers.NullTerminatedBytesToString(rawdata, ptr);
            ptr += DestUser.Length + 1;
            FromUser = FidonetHelpers.NullTerminatedBytesToString(rawdata, ptr);
            ptr += FromUser.Length + 1;
            Subject = FidonetHelpers.NullTerminatedBytesToString(rawdata, ptr);
            ptr += Subject.Length + 1;
            Text = FidonetHelpers.NullTerminatedBytesToString(rawdata, ptr);
        }
    }
}
