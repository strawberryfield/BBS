using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class UsersGroupsLinks
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public string Groupid { get; set; }

        public virtual UsersGroups Group { get; set; }
        public virtual Users User { get; set; }
    }
}
