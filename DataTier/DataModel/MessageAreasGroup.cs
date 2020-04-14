using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class MessageAreasGroup
    {
        public MessageAreasGroup()
        {
            MessageAreaGroupsAllowedUsersGroups = new HashSet<MessageAreaGroupsAllowedUsersGroup>();
            MessageAreas = new HashSet<MessageArea>();
        }

        public string Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MessageAreaGroupsAllowedUsersGroup> MessageAreaGroupsAllowedUsersGroups { get; set; }
        public virtual ICollection<MessageArea> MessageAreas { get; set; }
    }
}
