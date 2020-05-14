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
	/// Elements of the table 'UsersGroups'.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("EntityFrameworkCore", "3.1.4")]
	public partial class UsersGroup
    {
        public UsersGroup()
        {
            MessageAreaAllowedGroupReadNavigations = new HashSet<MessageArea>();
            MessageAreaAllowedGroupWriteNavigations = new HashSet<MessageArea>();
            MessageAreasGroups = new HashSet<MessageAreasGroup>();
            UsersGroupsLinks = new HashSet<UsersGroupsLink>();
        }

        
		/// <summary>
		/// Column 'Groupid'
		/// </summary>
		/// <remarks>Original field type: varchar(30)</remarks>
		public string Groupid { get; set; }
        
		/// <summary>
		/// Column 'Description'
		/// </summary>
		/// <remarks>Original field type: varchar(200)</remarks>
		public string Description { get; set; }

        
		/// <summary>
		/// ForeignKey: MessageArea {'AllowedGroupRead'} -> UsersGroup {'Groupid'} ToDependent: MessageAreaAllowedGroupReadNavigations ToPrincipal: AllowedGroupReadNavigation
		/// </summary>
		public virtual ICollection<MessageArea> MessageAreaAllowedGroupReadNavigations { get; set; }
        
		/// <summary>
		/// ForeignKey: MessageArea {'AllowedGroupWrite'} -> UsersGroup {'Groupid'} ToDependent: MessageAreaAllowedGroupWriteNavigations ToPrincipal: AllowedGroupWriteNavigation
		/// </summary>
		public virtual ICollection<MessageArea> MessageAreaAllowedGroupWriteNavigations { get; set; }
        
		/// <summary>
		/// ForeignKey: MessageAreasGroup {'AllowedGroupId'} -> UsersGroup {'Groupid'} ToDependent: MessageAreasGroups ToPrincipal: AllowedGroup
		/// </summary>
		public virtual ICollection<MessageAreasGroup> MessageAreasGroups { get; set; }
        
		/// <summary>
		/// ForeignKey: UsersGroupsLink {'Groupid'} -> UsersGroup {'Groupid'} ToDependent: UsersGroupsLinks ToPrincipal: Group
		/// </summary>
		public virtual ICollection<UsersGroupsLink> UsersGroupsLinks { get; set; }
    }
}
