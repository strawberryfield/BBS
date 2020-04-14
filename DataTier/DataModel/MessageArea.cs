using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class MessageArea
    {
        public MessageArea()
        {
            MessageAreaAllowedUsersGroups = new HashSet<MessageAreaAllowedUsersGroup>();
        }

        public string Id { get; set; }
        public string Description { get; set; }
        public string Fidoid { get; set; }
        public string Areagroup { get; set; }

        public virtual MessageAreasGroup AreagroupNavigation { get; set; }
        public virtual ICollection<MessageAreaAllowedUsersGroup> MessageAreaAllowedUsersGroups { get; set; }
    }
}
