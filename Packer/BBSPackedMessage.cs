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

using Casasoft.BBS.DataTier.DataModel;
using Casasoft.Fidonet;
using Casasoft.TextHelpers;

namespace Casasoft.BBS.Packer
{
    public class BBSPackedMessage : PackedMessage
    {
        #region constructors
        /// <summary>
        /// Empty constructor
        /// </summary>
        public BBSPackedMessage() : base()
        {
        }

        /// <summary>
        /// builds message from raw data
        /// </summary>
        /// <param name="rawdata"></param>
        public BBSPackedMessage(byte[] rawdata) : base(rawdata)
        {
        }

        /// <summary>
        /// builds message from database entity
        /// </summary>
        /// <param name="m"></param>
        public BBSPackedMessage(Message m) : base()
        {
            orig = new FidoAddress(m.OrigZone, m.OrigNet, m.OrigNode, m.OrigPoint);
            dest = new FidoAddress(m.DestZone, m.DestNet, m.DestNode, m.DestPoint);
            FromUser = m.MessageFrom;
            DestUser = m.MessageTo;
            Timestamp = FidonetHelpers.FidoFormatDatetime(m.DateTime);
            Subject = m.Subject;
            Text.Area = m.Area;
            Text.MsgId = m.FidoId;
            Text.ReplyId = m.FidoReplyTo;
            Text.Lines = TextHelper.SplitString(m.Body);
        }
        #endregion

    }
}
