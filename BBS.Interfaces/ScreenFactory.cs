// copyright (c) 2020 Roberto Ceccarelli - CasaSoft
// http://strawberryfield.altervista.org 
// 
// This file is part of CasaSoft BBS
// 
// CasaSoft BBS is free software: 
// you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// CasaSoft BBS is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
// See the GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with CasaSoft BBS.  
// If not, see <http://www.gnu.org/licenses/>.

using System;
using System.IO;
using System.Reflection;

namespace Casasoft.BBS.Interfaces
{
    public static class ScreenFactory
    {
        public static IScreen Create(IClient c, IServer s, string module, string param, IScreen prev)
        {
            module = "Casasoft.BBS.UI." + module.Trim();
            string base_dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Assembly asm = Assembly.LoadFrom(Path.Combine(base_dir, "BBS.UI.dll"));
            Type t = asm.GetType(module);
            if (string.IsNullOrWhiteSpace(param))
            {
                if (prev == null) return (IScreen)Activator.CreateInstance(t, new object[] { c, s });
                else return (IScreen)Activator.CreateInstance(t, new object[] { c, s, prev });
            }
            else
            {
                if(prev==null) return (IScreen)Activator.CreateInstance(t, new object[] { c, s, param });
                else return (IScreen)Activator.CreateInstance(t, new object[] { c, s, param, prev });
            }
        }

        public static IScreen Create(IClient c, IServer s, string module) => Create(c, s, module, string.Empty);

        public static IScreen Create(IClient c, IServer s, string module, string param) =>
            Create(c, s, module, param, null);

        public static IScreen Create(IClient c, IServer s, string module, IScreen prev) =>
            Create(c, s, module, string.Empty, prev);

    }
}
