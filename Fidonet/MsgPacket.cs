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
    /// Handles a packet of messages
    /// </summary>
    /// <remarks>
    /// <para>Format as described in FTSC-0001 <see cref="http://ftsc.org/docs/fts-0001.016"/></para>
    /// See <see cref="IMsgPacket"/>
    /// </remarks>
    public class MsgPacket : IMsgPacket
    {
        #region properties
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
        public virtual FidoAddress orig { get; set; }

        /// <summary>
        /// Fidonet address of destination node
        /// </summary>
        public virtual FidoAddress dest { get; set; }

        /// <summary>
        /// Packet creation timestamp
        /// </summary>
        public virtual DateTime Timestamp { get; set; }

        /// <summary>
        /// Connections speed
        /// </summary>
        public virtual ushort Baud { get; set; }

        /// <summary>
        /// Some implementation
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// List of Messages
        /// </summary>
        public virtual List<IPackedMessage> Messages { get; set; }
        #endregion

        #region constructors
        /// <summary>
        /// Empty constructor
        /// </summary>
        public MsgPacket()
        {
            orig = new FidoAddress();
            dest = new FidoAddress();
            Timestamp = DateTime.Now;
            Baud = 64000;
            Password = string.Empty;
            Messages = new List<IPackedMessage>();
        }

        /// <summary>
        /// Parses packet from raw data
        /// </summary>
        /// <param name="rawdata"></param>
        public MsgPacket(byte[] rawdata) : this()
        {
            if (FidonetHelpers.GetUShort(rawdata, 18) != 2) return;

            orig.node = FidonetHelpers.GetUShort(rawdata, 0);
            dest.node = FidonetHelpers.GetUShort(rawdata, 2);
            orig.net = FidonetHelpers.GetUShort(rawdata, 20);
            dest.net = FidonetHelpers.GetUShort(rawdata, 22);
            orig.zone = FidonetHelpers.GetUShort(rawdata, 34);
            dest.zone = FidonetHelpers.GetUShort(rawdata, 36);
            Baud = FidonetHelpers.GetUShort(rawdata, 16);

            Timestamp = new DateTime(FidonetHelpers.GetUShort(rawdata, 4),
                FidonetHelpers.GetUShort(rawdata, 6) + 1,
                FidonetHelpers.GetUShort(rawdata, 8),
                FidonetHelpers.GetUShort(rawdata, 10),
                FidonetHelpers.GetUShort(rawdata, 12),
                FidonetHelpers.GetUShort(rawdata, 14));
            Password = FidonetHelpers.BytesToString(rawdata, 24, 8);

            // Scan messages
            int ptr = 58;
            while(FidonetHelpers.GetUShort(rawdata, ptr) == 2)
            {
                int end = ptr + 34; // skip msg header
                int zerofound = 0;
                while(zerofound < 4)
                {
                    if (rawdata[end] == 0) zerofound++;
                    end++;
                }
                byte[] msg = new byte[end - ptr];
                Array.Copy(rawdata, ptr, msg, 0, end - ptr);
                AddMessage(msg);
                ptr = end;
            }
        }
        #endregion

        /// <summary>
        /// Adds a binary packed msg to the packet
        /// </summary>
        /// <param name="msg"></param>
        public virtual void AddMessage(byte[] msg) => Messages.Add(new PackedMessage(msg));

        #region exports
        /// <summary>
        /// Packet in binary format
        /// </summary>
        public virtual byte[] Binary
        {
            get
            {
                List<byte> ret = new List<byte>();
                ret.Add(FidonetHelpers.LowOrder(orig.node));
                ret.Add(FidonetHelpers.HighOrder(orig.node));
                ret.Add(FidonetHelpers.LowOrder(dest.node));
                ret.Add(FidonetHelpers.HighOrder(dest.node));
                ret.Add(FidonetHelpers.LowOrder(Timestamp.Year));
                ret.Add(FidonetHelpers.HighOrder(Timestamp.Year));
                ret.Add(FidonetHelpers.LowOrder(Timestamp.Month - 1));
                ret.Add(FidonetHelpers.HighOrder(Timestamp.Month - 1));
                ret.Add(FidonetHelpers.LowOrder(Timestamp.Day));
                ret.Add(FidonetHelpers.HighOrder(Timestamp.Day));
                ret.Add(FidonetHelpers.LowOrder(Timestamp.Hour));
                ret.Add(FidonetHelpers.HighOrder(Timestamp.Hour));
                ret.Add(FidonetHelpers.LowOrder(Timestamp.Minute));
                ret.Add(FidonetHelpers.HighOrder(Timestamp.Minute));
                ret.Add(FidonetHelpers.LowOrder(Timestamp.Second));
                ret.Add(FidonetHelpers.HighOrder(Timestamp.Second));
                ret.Add(FidonetHelpers.LowOrder(Baud));
                ret.Add(FidonetHelpers.HighOrder(Baud));
                ret.Add(2);
                ret.Add(0);
                ret.Add(FidonetHelpers.LowOrder(orig.net));
                ret.Add(FidonetHelpers.HighOrder(orig.net));
                ret.Add(FidonetHelpers.LowOrder(dest.net));
                ret.Add(FidonetHelpers.HighOrder(dest.net));
                ret.Add(ProductCode);
                ret.Add(0);
                ret.AddRange(FidonetHelpers.ToFixedLength(Password, 8));
                ret.Add(FidonetHelpers.LowOrder(orig.zone));
                ret.Add(FidonetHelpers.HighOrder(orig.zone));
                ret.Add(FidonetHelpers.LowOrder(dest.zone));
                ret.Add(FidonetHelpers.HighOrder(dest.zone));
                ret.AddRange(FidonetHelpers.ToFixedLength(string.Empty, 20));

                foreach (IPackedMessage m in Messages) ret.AddRange(m.ByteList);

                ret.Add(0);
                ret.Add(0);
                return ret.ToArray();
            }
        }

        /// <summary>
        /// Toss the message in the message base
        /// </summary>
        /// <param name="network">Network to use</param>
        public virtual void Toss(string network)
        {
            foreach (IPackedMessage m in Messages) m.Toss(network);
        }

        #endregion
    }
}
