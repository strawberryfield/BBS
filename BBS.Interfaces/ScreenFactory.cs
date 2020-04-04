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
using System.Reflection;

namespace Casasoft.BBS.Interfaces
{
    public static class ScreenFactory
    {
        public static IScreen Create(IClient c, IServer s, string module, string param)
        {
            module = "Casasoft.BBS.UI." + module.Trim();
            Assembly asm = Assembly.LoadFrom("BBS.UI.dll");
            Type t = asm.GetType(module);
            if (string.IsNullOrWhiteSpace(param))
            {
                return (IScreen)Activator.CreateInstance(t, new object[] { c, s });
            }
            else
            {
                return (IScreen)Activator.CreateInstance(t, new object[] { c, s, param });
            }
        }

        public static IScreen Create(IClient c, IServer s, string module) => Create(c, s, module, null);
    }
}
