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
using System.Collections.Generic;
using System.IO;

namespace Casasoft.HudsonBase
{
    /// <summary>
    /// Messages index
    /// </summary>
    public class MsgIdx
    {
        /// <summary>
        /// Message index record
        /// </summary>
        public class MsgIdxRecord
        {
            public int msgnum;
            public byte board;

            /// <summary>
            /// Empty constructor
            /// </summary>
            public MsgIdxRecord()
            {
                msgnum = 0;
                board = 0;
            }

            /// <summary>
            /// Builds record from raw data
            /// </summary>
            /// <param name="raw"></param>
            /// <param name="idx"></param>
            public MsgIdxRecord(byte[] raw, int idx)
            {
                msgnum = FidonetHelpers.GetUShort(raw, idx);
                board = raw[idx + 2];
            }
        }

        /// <summary>
        /// Data repository
        /// </summary>
        public List<MsgIdxRecord> Data;

        /// <summary>
        /// Empty constructor
        /// </summary>
        public MsgIdx()
        {
            Data = new List<MsgIdxRecord>();
        }

        /// <summary>
        /// Fills data from file
        /// </summary>
        /// <param name="filename"></param>
        public MsgIdx(string filename) : this()
        {
            byte[] raw = File.ReadAllBytes(filename);
            for (int idx = 0; idx < raw.Length; idx += 3)
                Data.Add(new MsgIdxRecord(raw, idx));
        }
    }
}
