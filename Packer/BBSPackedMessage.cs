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

using Casasoft.BBS.DataTier;
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
            attr = new MsgAttributes((ushort)m.Attributes);
            Text.Area = m.Area;
            Text.MsgId = m.FidoId;
            Text.ReplyId = m.FidoReplyTo;
            Text.Tear = m.TearLine;
            Text.Origin = m.OriginLine;
            Text.Lines = TextHelper.SplitString(m.Body);
            Text.Path = m.PathLines;
            Text.SeenBy = m.SeenByLines;
        }
        #endregion

        /// <summary>
        /// Toss the message in the message base
        /// </summary>
        /// <param name="network">Network to use</param>
        public override void Toss(string network)
        {
            Message m = new Message();
            m.Area = Text.Area.ToUpper();
            m.DateTime = FidonetHelpers.ParseDatetime(Timestamp);
            m.MessageFrom = FromUser;
            m.MessageTo = DestUser;
            m.Subject = Subject;
            m.FidoId = Text.MsgId;
            m.FidoReplyTo = Text.ReplyId;
            m.TearLine = Text.Tear;
            m.OriginLine = Text.Origin;
            m.OrigZone = orig.zone;
            m.OrigNet = orig.net;
            m.OrigNode = orig.node;
            m.OrigPoint = orig.point;
            m.DestZone = dest.zone;
            m.DestNet = dest.net;
            m.DestNode = dest.node;
            m.DestPoint = dest.point;
            m.Attributes = attr.Binary;
            m.Body = string.Join('\n', Text.Lines);

            using(bbsContext db = new bbsContext())
            {
                db.Messages.Add(m);
                db.SaveChanges();
                foreach (string s in Text.SeenBy)
                    db.MessagesSeenBy.Add(new MessageSeenBy()
                    {
                        MessageId = m.Id,
                        SeenBy = s
                    });
                foreach (string s in Text.Path)
                    db.MessagePaths.Add(new MessagePath()
                    {
                        MessageId = m.Id,
                        Path = s
                    });
                db.SaveChanges();
            }
        }
    }
}
