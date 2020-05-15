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
using System.Collections.Generic;

namespace Casasoft.BBS.DataTier.DataModel
{
    /// <summary>
	/// Elements of the table 'MessageAreas':
	/// Message Areas List
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("EntityFrameworkCore", "3.1.4")]
	public partial class MessageArea
    {
        /// <summary>
		/// Entity constructor
		/// </summary>
		public MessageArea()
        {
            Messages = new HashSet<Message>();
        }

        
		/// <summary>
		/// Column 'ID'
		/// </summary>
		/// <remarks>Original field type: varchar(20)</remarks>
		public string Id { get; set; }
        
		/// <summary>
		/// Column 'Description'
		/// </summary>
		/// <remarks>Original field type: varchar(200)</remarks>
		public string Description { get; set; }
        
		/// <summary>
		/// Column 'FIDOID'
		/// </summary>
		/// <remarks>Original field type: varchar(30)</remarks>
		public string Fidoid { get; set; }
        
		/// <summary>
		/// Column 'AREAGROUP'
		/// </summary>
		/// <remarks>Original field type: varchar(20)</remarks>
		public string Areagroup { get; set; }
        
		/// <summary>
		/// Column 'AllowedGroupRead'
		/// </summary>
		/// <remarks>Original field type: varchar(30)</remarks>
		public string AllowedGroupRead { get; set; }
        
		/// <summary>
		/// Column 'AllowedGroupWrite'
		/// </summary>
		/// <remarks>Original field type: varchar(30)</remarks>
		public string AllowedGroupWrite { get; set; }

        
		/// <summary>
		/// ForeignKey: MessageArea {'AllowedGroupRead'} -> UsersGroup {'Groupid'} ToDependent: MessageAreaAllowedGroupReadNavigations ToPrincipal: AllowedGroupReadNavigation
		/// </summary>
		public virtual UsersGroup AllowedGroupReadNavigation { get; set; }
        
		/// <summary>
		/// ForeignKey: MessageArea {'AllowedGroupWrite'} -> UsersGroup {'Groupid'} ToDependent: MessageAreaAllowedGroupWriteNavigations ToPrincipal: AllowedGroupWriteNavigation
		/// </summary>
		public virtual UsersGroup AllowedGroupWriteNavigation { get; set; }
        
		/// <summary>
		/// ForeignKey: MessageArea {'Areagroup'} -> MessageAreasGroup {'Id'} ToDependent: MessageAreas ToPrincipal: AreagroupNavigation
		/// </summary>
		public virtual MessageAreasGroup AreagroupNavigation { get; set; }
        
		/// <summary>
		/// ForeignKey: Message {'Area'} -> MessageArea {'Id'} ToDependent: Messages ToPrincipal: AreaNavigation
		/// </summary>
		public virtual ICollection<Message> Messages { get; set; }
    }
}
