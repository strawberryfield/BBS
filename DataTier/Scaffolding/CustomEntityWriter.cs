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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Casasoft.BBS.DataTier
{
    /// <summary>
    /// Inherits and extends Entity classes generator
    /// </summary>
    public class CustomEntityWriter : CSharpEntityTypeGenerator
    {
        private ICSharpHelper _code;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="cSharpHelper"></param>
        public CustomEntityWriter([NotNullAttribute] ICSharpHelper cSharpHelper) : base(cSharpHelper)
        {
            _code = cSharpHelper;
        }

        /// <summary>
        /// Code writer
        /// </summary>
        /// <param name="type"></param>
        /// <param name="namespace"></param>
        /// <param name="useDataAnnotations"></param>
        /// <returns></returns>
        public override string WriteCode(IEntityType type, string @namespace, bool useDataAnnotations)
        {
            string code = base.WriteCode(type, @namespace, useDataAnnotations);
            code = CustomHelpers.commentedClass(code, 
                string.Format("Elements of the table '{0}'.", type.GetTableName()));

            foreach(var p in type.GetProperties())
            {
                string decl = "public " + _code.Reference(p.ClrType) + " " + p.Name;
                StringBuilder comment = new StringBuilder();
                comment.Append("\r\n\t\t/// <summary>");
                comment.Append("\r\n\t\t/// Column '" + p.GetColumnName() + "'");
                if(!string.IsNullOrWhiteSpace(p.GetComment())) comment.Append("\r\n\t\t/// " + p.GetComment());
                comment.Append("\r\n\t\t/// </summary>");
                comment.Append("\r\n\t\t/// <remarks>Original field type: " + p.GetColumnType()+ "</remarks>");
                comment.Append("\r\n\t\t" + decl);
                code = code.Replace(decl, comment.ToString());
            }

            var navi = type.GetNavigations().ToList();
            if(navi.Any())
            {
                foreach(var n in navi)
                {
                    string ntype = n.IsCollection() ?
                        $"ICollection<{n.GetTargetType().DisplayName()}>" : 
                        n.GetTargetType().DisplayName();
                    string decl = $"public virtual {ntype} {n.Name}";
                    StringBuilder comment = new StringBuilder();
                    comment.Append("\r\n\t\t/// <summary>");
                    comment.Append("\r\n\t\t/// " + n.ForeignKey);
                    comment.Append("\r\n\t\t/// </summary>");
                    comment.Append("\r\n\t\t" + decl);
                    code = code.Replace(decl, comment.ToString());
                }
            }

            return CustomHelpers.copyrightNotice + code;
        }

    }
}
