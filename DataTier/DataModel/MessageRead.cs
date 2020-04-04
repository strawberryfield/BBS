using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class MessageRead
    {
        public int Id { get; set; }
        public int MessgeId { get; set; }
        public string UserId { get; set; }

        public virtual Message Messge { get; set; }
    }
}
