using System;
using Casasoft.BBS.UI;

namespace Casasoft.BBS
{
    class Program
    {
        static void Main(string[] args)
        {
            IScreen screen = new Banner();
            while (screen != null)
            {
                screen = screen.Show();
            }
            screen = new Logout();
            screen.Show();
        }
    }
}
