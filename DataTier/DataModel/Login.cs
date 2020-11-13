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

#nullable disable

namespace Casasoft.BBS.DataTier.DataModel
{
    /// <summary>
	/// Elements of the table 'Logins':
	/// Users logins
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("EntityFrameworkCore", "3.1.4")]
	public partial class Login
    {
        
		/// <summary>
		/// Column 'ID'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int Id { get; set; }
        
		/// <summary>
		/// Column 'UserId':
		/// username supplied for the login
		/// </summary>
		/// <remarks>Original field type: varchar(30)</remarks>
		public string UserId { get; set; }
        
		/// <summary>
		/// Column 'DateTime':
		/// timestamp set to current timestamp by default
		/// </summary>
		/// <remarks>Original field type: datetime</remarks>
		public DateTime DateTime { get; set; }
        
		/// <summary>
		/// Column 'From':
		/// remote ip address and port of the client
		/// </summary>
		/// <remarks>Original field type: varchar(24)</remarks>
		public string From { get; set; }
        
		/// <summary>
		/// Column 'Success':
		/// true if login was successful
		/// </summary>
		/// <remarks>Original field type: </remarks>
		public bool Success { get; set; }

        
		/// <summary>
		/// ForeignKey: Login {'UserId'} -> User {'Userid'} ToDependent: Logins ToPrincipal: User ClientSetNull
		/// </summary>
		public virtual User User { get; set; }
    }
}
