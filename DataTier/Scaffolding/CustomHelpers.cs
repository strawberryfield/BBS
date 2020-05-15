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

namespace Casasoft.BBS.DataTier
{
    /// <summary>
    /// Common strings for db scaffolding customization
    /// </summary>
    public static class CustomHelpers
    {
        /// <summary>
        /// copyright notice to add at the top of the file
        /// </summary>
        public static string copyrightNotice = @"// copyright (c) 2020 Roberto Ceccarelli - CasaSoft
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

";

        /// <summary>
        /// class declaration
        /// </summary>
        public static string ppc = "public partial class";

        /// <summary>
        /// Generated code attribute
        /// </summary>
        public static string generatedCodeAttribute =
            "[System.CodeDom.Compiler.GeneratedCodeAttribute(\"EntityFrameworkCore\", \"3.1.4\")]";

        /// <summary>
        /// Class summary comment
        /// </summary>
        public static string classSummary = "/// <summary>\r\n\t/// {0}\r\n\t/// </summary>\r\n\t" +
            generatedCodeAttribute + "\r\n\t" + ppc;

        /// <summary>
        /// Adds comment to class declaration
        /// </summary>
        /// <param name="code">uncommented code</param>
        /// <param name="comment">comment to the class</param>
        /// <param name="note">additional comment</param>
        /// <returns></returns>
        public static string commentedClass(string code, string comment, string note) =>
           code.Replace(ppc, string.Format(classSummary,
               comment + (string.IsNullOrWhiteSpace(note) ? string.Empty : ":\r\n\t/// " + note)));
    }
}
