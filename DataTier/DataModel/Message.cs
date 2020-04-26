using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class Message
    {
        public Message()
        {
            MessageReads = new HashSet<MessageRead>();
            MessageSeenBies = new HashSet<MessageSeenBy>();
        }

        public int Id { get; set; }
        public string Area { get; set; }
        public string MessageFrom { get; set; }
        public string MessageTo { get; set; }
        public string Subject { get; set; }
        public DateTime DateTime { get; set; }
        public string FidoId { get; set; }
        public string FidoReplyTo { get; set; }
        public int TimesRead { get; set; }
        public int OrigZone { get; set; }
        public int OrigNet { get; set; }
        public int OrigNode { get; set; }
        public int OrigPoint { get; set; }
        public int DestZone { get; set; }
        public int DestNet { get; set; }
        public int DestNode { get; set; }
        public int DestPoint { get; set; }
        public string Body { get; set; }

        public virtual MessageArea AreaNavigation { get; set; }
        public virtual ICollection<MessageRead> MessageReads { get; set; }
        public virtual ICollection<MessageSeenBy> MessageSeenBies { get; set; }
    }
}
