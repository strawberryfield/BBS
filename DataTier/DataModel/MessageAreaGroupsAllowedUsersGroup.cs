using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class MessageAreaGroupsAllowedUsersGroup
    {
        public int Id { get; set; }
        public string MessageAreaGroupId { get; set; }
        public string UsersGroupId { get; set; }

        public virtual MessageAreasGroup MessageAreaGroup { get; set; }
        public virtual UsersGroup UsersGroup { get; set; }
    }
}
