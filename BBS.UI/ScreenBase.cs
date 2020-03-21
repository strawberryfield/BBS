using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Text;

namespace Casasoft.BBS.UI
{
    public class ScreenBase : IScreen
    {
        public virtual IScreen Show() 
        {
            return null;
        }

    }
}
