using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class Groups
    {
        public Groups()
        {
            UsersGroups = new HashSet<UsersGroups>();
        }

        public string Groupid { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UsersGroups> UsersGroups { get; set; }
    }
}
