using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class Logins
    {
        public int Id { get; set; }
        public string Userid { get; set; }
        public DateTime DateTime { get; set; }
        public string From { get; set; }

        public virtual Users User { get; set; }
    }
}
