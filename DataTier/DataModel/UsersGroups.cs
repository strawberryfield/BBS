using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class UsersGroups
    {
        public UsersGroups()
        {
            UsersGroupsLinks = new HashSet<UsersGroupsLinks>();
        }

        public string Groupid { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UsersGroupsLinks> UsersGroupsLinks { get; set; }
    }
}
