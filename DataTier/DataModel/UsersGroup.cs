using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class UsersGroup
    {
        public UsersGroup()
        {
            MessageAreaAllowedGroupReadNavigations = new HashSet<MessageArea>();
            MessageAreaAllowedGroupWriteNavigations = new HashSet<MessageArea>();
            MessageAreasGroups = new HashSet<MessageAreasGroup>();
            UsersGroupsLinks = new HashSet<UsersGroupsLink>();
        }

        public string Groupid { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MessageArea> MessageAreaAllowedGroupReadNavigations { get; set; }
        public virtual ICollection<MessageArea> MessageAreaAllowedGroupWriteNavigations { get; set; }
        public virtual ICollection<MessageAreasGroup> MessageAreasGroups { get; set; }
        public virtual ICollection<UsersGroupsLink> UsersGroupsLinks { get; set; }
    }
}
