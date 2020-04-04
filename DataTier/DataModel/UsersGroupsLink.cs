using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class UsersGroupsLink
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public string Groupid { get; set; }

        public virtual UsersGroup Group { get; set; }
        public virtual User User { get; set; }
    }
}
