using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class MessageAreasGroup
    {
        public MessageAreasGroup()
        {
            MessageAreas = new HashSet<MessageArea>();
        }

        public string Id { get; set; }
        public string Description { get; set; }
        public string AllowedGroupId { get; set; }

        public virtual UsersGroup AllowedGroup { get; set; }
        public virtual ICollection<MessageArea> MessageAreas { get; set; }
    }
}
