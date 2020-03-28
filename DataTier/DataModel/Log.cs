using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class Log
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public sbyte Level { get; set; }
        public string Description { get; set; }
    }
}
