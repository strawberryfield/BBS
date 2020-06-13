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

namespace Casasoft.Fidonet
{
    /// <summary>
    /// Handles a message in format suitable for packets
    /// </summary>
    /// <remarks>
    /// <para>Format as described in FTSC-0001 <see cref="http://ftsc.org/docs/fts-0001.016"/></para>
    /// See <see cref="IPackedMessage"/>
    /// </remarks>
    public class PackedMessage : IPackedMessage
    {
        #region properties
        /// <summary>
        /// Fidonet address of node that creates the message
        /// </summary>
        public virtual FidoAddress orig { get; set; }

        /// <summary>
        /// Fidonet address of destination node
        /// </summary>
        public virtual FidoAddress dest { get; set; }

        /// <summary>
        /// Message attributes
        /// </summary>
        public virtual MsgAttributes attr { get; set; }

        /// <summary>
        /// Cost of message
        /// </summary>
        public virtual ushort Cost { get; set; }

        /// <summary>
        /// Sender user
        /// </summary>
        public virtual string FromUser { get; set; }

        /// <summary>
        /// Destination user
        /// </summary>
        public virtual string DestUser { get; set; }

        /// <summary>
        /// Date and time
        /// </summary>
        public virtual string Timestamp { get; set; }

        /// <summary>
        /// Subject of the message
        /// </summary>
        public virtual string Subject { get; set; }

        /// <summary>
        /// Text of message
        /// </summary>
        public virtual IMsgText Text { get; set; }
        #endregion

        #region constructors
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
            Text = new MsgText();
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
            Text = new MsgText(FidonetHelpers.NullTerminatedBytesToString(rawdata, ptr));
        }
        #endregion

        #region exports
        /// <summary>
        /// Packed message as list of bytes
        /// </summary>
        public List<byte> ByteList
        {
            get
            {
                List<byte> ret = new List<byte>();
                ret.Add(2);
                ret.Add(0);
                ret.Add(FidonetHelpers.LowOrder(orig.node));
                ret.Add(FidonetHelpers.HighOrder(orig.node));
                ret.Add(FidonetHelpers.LowOrder(dest.node));
                ret.Add(FidonetHelpers.HighOrder(dest.node));
                ret.Add(FidonetHelpers.LowOrder(orig.net));
                ret.Add(FidonetHelpers.HighOrder(orig.net));
                ret.Add(FidonetHelpers.LowOrder(dest.net));
                ret.Add(FidonetHelpers.HighOrder(dest.net));
                ret.Add(FidonetHelpers.LowOrder(attr.Binary));
                ret.Add(FidonetHelpers.HighOrder(attr.Binary));
                ret.Add(FidonetHelpers.LowOrder(Cost));
                ret.Add(FidonetHelpers.HighOrder(Cost));
                ret.AddRange(FidonetHelpers.ToFixedLength(Timestamp, 20));
                ret.AddRange(FidonetHelpers.ToMaxLength(DestUser, 36));
                ret.AddRange(FidonetHelpers.ToMaxLength(FromUser, 36));
                ret.AddRange(FidonetHelpers.ToMaxLength(Subject, 72));
                ret.AddRange(FidonetHelpers.ToUnbounded(Text.Text));
                return ret;
            }
        }

        /// <summary>
        /// Packed message in binary format
        /// </summary>
        public byte[] Binary { get => ByteList.ToArray(); }

        /// <summary>
        /// Toss the message in the message base
        /// </summary>
        /// <param name="network">Network to use</param>
        public virtual void Toss(string network) { }
        #endregion
    }
}
