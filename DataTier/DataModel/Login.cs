using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class Login
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public DateTime DateTime { get; set; }
        public string From { get; set; }
        public bool Success { get; set; }

        public virtual User User { get; set; }
    }
}
