using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class Users
    {
        public Users()
        {
            Logins = new HashSet<Logins>();
            UsersGroups = new HashSet<UsersGroups>();
        }

        public string Userid { get; set; }
        public string Realname { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string Signature { get; set; }
        public string LastLoginFrom { get; set; }
        public DateTime LastLoginDate { get; set; }

        public virtual ICollection<Logins> Logins { get; set; }
        public virtual ICollection<UsersGroups> UsersGroups { get; set; }
    }
}
