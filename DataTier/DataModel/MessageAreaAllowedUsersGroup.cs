using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class MessageAreaAllowedUsersGroup
    {
        public int Id { get; set; }
        public string MessageAreaId { get; set; }
        public string UsersGroupId { get; set; }

        public virtual MessageArea MessageArea { get; set; }
        public virtual UsersGroup UsersGroup { get; set; }
    }
}
