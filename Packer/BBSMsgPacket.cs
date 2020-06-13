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

namespace Casasoft.BBS.Packer
{
    /// <summary>
    /// Handles a packet of messages from casasoft BBS message base
    /// </summary>
    /// <remarks>
    /// <para>Format as described in FTSC-0001 <see cref="http://ftsc.org/docs/fts-0001.016"/></para>
    /// See <see cref="IMsgPacket"/>
    /// </remarks>
    public class BBSMsgPacket : MsgPacket
    {
        #region constructors
        /// <summary>
        /// Empty constructor
        /// </summary>
        public BBSMsgPacket() : base()
        {
        }

        /// <summary>
        /// Parses packet from raw data
        /// </summary>
        /// <param name="rawdata"></param>
        public BBSMsgPacket(byte[] rawdata) : base(rawdata)
        {
        }
        #endregion

        /// <summary>
        /// Adds a binary packed msg to the packet
        /// </summary>
        /// <param name="msg"></param>
        public override void AddMessage(byte[] msg) => Messages.Add(new BBSPackedMessage(msg));

    }
}
