﻿using System;
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class MessagesSeenBy
    {
        public int Id { get; set; }
        public int MessageId { get; set; }
        public string SeenBy { get; set; }
    }
}