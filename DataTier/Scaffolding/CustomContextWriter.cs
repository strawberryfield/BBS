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

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Scaffolding.Internal;
using System.Diagnostics.CodeAnalysis;

namespace Casasoft.BBS.DataTier
{
    /// <summary>
    /// Inherits and extends DbContext generator
    /// </summary>
    public class CustomContextWriter : CSharpDbContextGenerator
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="providerConfigurationCodeGenerator"></param>
        /// <param name="annotationCodeGenerator"></param>
        /// <param name="cSharpHelper"></param>
        public CustomContextWriter([NotNullAttribute] IProviderConfigurationCodeGenerator providerConfigurationCodeGenerator,
            [NotNullAttribute] IAnnotationCodeGenerator annotationCodeGenerator, 
            [NotNullAttribute] ICSharpHelper cSharpHelper) : 
            base(providerConfigurationCodeGenerator, annotationCodeGenerator, cSharpHelper)
        {
        }

        /// <summary>
        /// Code writer
        /// </summary>
        /// <param name="model"></param>
        /// <param name="contextName"></param>
        /// <param name="connectionString"></param>
        /// <param name="contextNamespace"></param>
        /// <param name="modelNamespace"></param>
        /// <param name="useDataAnnotations"></param>
        /// <param name="suppressConnectionStringWarning"></param>
        /// <returns></returns>
        public override string WriteCode(IModel model, string contextName, string connectionString, string contextNamespace, string modelNamespace, bool useDataAnnotations, bool suppressConnectionStringWarning)
        {
            string code = base.WriteCode(model, contextName, 
                connectionString, contextNamespace, modelNamespace, 
                useDataAnnotations, suppressConnectionStringWarning);
            code = CustomHelpers.commentedClass(code,
                 string.Format("Model for the database '{0}'.", model.GetDatabaseName()));
            return CustomHelpers.copyrightNotice + code;
        }  
    }
}
