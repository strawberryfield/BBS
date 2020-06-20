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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Casasoft.HudsonBase
{
    /// <summary>
    /// Messages headers
    /// </summary>
    public class MsgHdr
    {
        /// <summary>
        /// Message header record
        /// </summary>
        public class MsgHdrRecord
        {
            public int MsgNum;
            public ushort PrevReply;
            public ushort NextReply;
            public ushort TimesRead;
            public ushort StartBlock;
            public ushort NumBlocks;
            public ushort DestNet;
            public ushort DestNode;
            public ushort OrigNet;
            public ushort OrigNode;
            public byte DestZone;
            public byte OrigZone;
            public ushort Cost;
            public byte MsgAttr;
            public byte NetAttr;
            public byte Board;
            public DateTime Timestamp;
            public string WhoTo;
            public string WhoFrom;
            public string Subject;

            /// <summary>
            /// Empty constructor
            /// </summary>
            public MsgHdrRecord()
            {
                MsgNum = 0;
                PrevReply = 0;
                NextReply = 0;
                TimesRead = 0;
                StartBlock = 0;
                NumBlocks = 0;
                DestNet = 0;
                DestNode = 0;
                OrigNet = 0;
                OrigNode = 0;
                DestZone = 0;
                OrigZone = 0;
                Cost = 0;
                MsgAttr = 0;
                NetAttr = 0;
                Board = 0;
                Timestamp = DateTime.Now;
                WhoTo = string.Empty;
                WhoFrom = string.Empty;
                Subject = string.Empty;
            }

            public MsgHdrRecord(byte[] raw, int idx) : this()
            {
                MsgNum = FidonetHelpers.GetUShort(raw, idx);
                PrevReply = FidonetHelpers.GetUShort(raw, idx + 2);
                NextReply = FidonetHelpers.GetUShort(raw, idx + 4);
                TimesRead = FidonetHelpers.GetUShort(raw, idx + 6);
                StartBlock = FidonetHelpers.GetUShort(raw, idx + 8);
                NumBlocks = FidonetHelpers.GetUShort(raw, idx + 10);
                DestNet = FidonetHelpers.GetUShort(raw, idx + 12);
                DestNode = FidonetHelpers.GetUShort(raw, idx + 14);
                OrigNet = FidonetHelpers.GetUShort(raw, idx + 16);
                OrigNode = FidonetHelpers.GetUShort(raw, idx + 18);
                DestZone = raw[idx + 20];
                OrigZone = raw[idx + 21];
                Cost = FidonetHelpers.GetUShort(raw, idx + 22);
                MsgAttr = raw[idx + 24];
                NetAttr = raw[idx + 25];
                Board = raw[idx + 26];
                string time = FidonetHelpers.GetPascalString(raw, idx + 0x1b);
                string date = FidonetHelpers.GetPascalString(raw, idx + 0x21);
                if (!DateTime.TryParseExact($"{date} {time}", "MM-dd-yy HH:mm",
                    CultureInfo.InvariantCulture, DateTimeStyles.None,
                    out Timestamp))
                    Timestamp = DateTime.MinValue;
                WhoTo = FidonetHelpers.GetPascalString(raw, idx + 0x2a);
                WhoFrom = FidonetHelpers.GetPascalString(raw, idx + 0x4e);
                Subject = FidonetHelpers.GetPascalString(raw, idx + 0x72);
            }
        }

        /// <summary>
        /// Data repository
        /// </summary>
        public List<MsgHdrRecord> Data;

        /// <summary>
        /// Empty constructor
        /// </summary>
        public MsgHdr()
        {
            Data = new List<MsgHdrRecord>();
        }

        /// <summary>
        /// Fills data from file
        /// </summary>
        /// <param name="filename"></param>
        public MsgHdr(string filename) : this()
        {
            byte[] raw = File.ReadAllBytes(filename);
            for (int idx = 0; idx < raw.Length; idx += 0xbb)
                Data.Add(new MsgHdrRecord(raw, idx));
        }


    }
}
