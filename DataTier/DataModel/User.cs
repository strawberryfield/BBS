using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class User
    {
        public User()
        {
            Logins = new HashSet<Login>();
            MessageReads = new HashSet<MessageRead>();
            UsersGroupsLinks = new HashSet<UsersGroupsLink>();
        }

        public string Userid { get; set; }
        public string Realname { get; set; }
        public string City { get; set; }
        public string Nation { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string Signature { get; set; }
        public string LastLoginFrom { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime Registered { get; set; }
        public DateTime LastPasswordModify { get; set; }
        public string Email { get; set; }
        public bool Locked { get; set; }

        public virtual ICollection<Login> Logins { get; set; }
        public virtual ICollection<MessageRead> MessageReads { get; set; }
        public virtual ICollection<UsersGroupsLink> UsersGroupsLinks { get; set; }
    }
}
