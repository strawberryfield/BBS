using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class UsersGroup
    {
        public UsersGroup()
        {
            UsersGroupsLinks = new HashSet<UsersGroupsLink>();
        }

        public string Groupid { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UsersGroupsLink> UsersGroupsLinks { get; set; }
    }
}
