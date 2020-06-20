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

namespace Casasoft.HudsonBase
{
    /// <summary>
    /// Handles a Hudson-base message in format suitable for packets
    /// </summary>
    /// <remarks>
    /// <para>Format as described in FTSC-0001 <see cref="http://ftsc.org/docs/fts-0001.016"/></para>
    /// See <see cref="IPackedMessage"/>
    /// </remarks>
    public class HudsonPackedMessage : PackedMessage
    {
        #region constructors
        /// <summary>
        /// Empty constructor
        /// </summary>
        public HudsonPackedMessage() : base()
        {
        }

        /// <summary>
        /// Build a packed message from Hudsonbase header and body
        /// </summary>
        /// <param name="header"></param>
        /// <param name="body"></param>
        public HudsonPackedMessage(Messages msgbase, int msgnum) : this()
        {
            MsgHdr.MsgHdrRecord header = msgbase.Headers.Data[msgnum-1];
            Text = new MsgText(msgbase.MsgBodies[msgnum]);
            Text.Area = msgbase.Areas[header.Board];
            orig = new FidoAddress(header.OrigZone, header.OrigNet, header.OrigNode, 0);
            dest = new FidoAddress(header.DestZone, header.DestNet, header.DestNode, 0);
            FromUser = header.WhoFrom;
            DestUser = header.WhoTo;
            Subject = header.Subject;
            Timestamp = FidonetHelpers.FidoFormatDatetime(header.Timestamp);
        }
        #endregion
    }
}
