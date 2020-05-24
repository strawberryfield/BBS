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
	/// Elements of the table 'Users':
	/// BBS users
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("EntityFrameworkCore", "3.1.4")]
	public partial class User
    {
        /// <summary>
		/// Entity constructor
		/// </summary>
		public User()
        {
            Logins = new HashSet<Login>();
            MessageReads = new HashSet<MessageRead>();
            UsersGroupsLinks = new HashSet<UsersGroupsLink>();
        }

        
		/// <summary>
		/// Column 'userid':
		/// Nickname
		/// </summary>
		/// <remarks>Original field type: varchar(30)</remarks>
		public string Userid { get; set; }
        
		/// <summary>
		/// Column 'realname':
		/// Real name
		/// </summary>
		/// <remarks>Original field type: varchar(50)</remarks>
		public string Realname { get; set; }
        
		/// <summary>
		/// Column 'city':
		/// city of the user
		/// </summary>
		/// <remarks>Original field type: varchar(50)</remarks>
		public string City { get; set; }
        
		/// <summary>
		/// Column 'nation':
		/// nation of the user
		/// </summary>
		/// <remarks>Original field type: varchar(50)</remarks>
		public string Nation { get; set; }
        
		/// <summary>
		/// Column 'password':
		/// MD5 Hash of the password
		/// </summary>
		/// <remarks>Original field type: varchar(32)</remarks>
		public string Password { get; set; }
        
		/// <summary>
		/// Column 'status'
		/// </summary>
		/// <remarks>Original field type: varchar(1)</remarks>
		public string Status { get; set; }
        
		/// <summary>
		/// Column 'signature':
		/// signature for messages
		/// </summary>
		/// <remarks>Original field type: text</remarks>
		public string Signature { get; set; }
        
		/// <summary>
		/// Column 'LastLoginFrom'
		/// </summary>
		/// <remarks>Original field type: varchar(24)</remarks>
		public string LastLoginFrom { get; set; }
        
		/// <summary>
		/// Column 'LastLoginDate'
		/// </summary>
		/// <remarks>Original field type: datetime</remarks>
		public DateTime LastLoginDate { get; set; }
        
		/// <summary>
		/// Column 'Registered':
		/// timestamp of registration to the bbs
		/// </summary>
		/// <remarks>Original field type: datetime</remarks>
		public DateTime Registered { get; set; }
        
		/// <summary>
		/// Column 'LastPasswordModify'
		/// </summary>
		/// <remarks>Original field type: datetime</remarks>
		public DateTime LastPasswordModify { get; set; }
        
		/// <summary>
		/// Column 'email':
		/// internet email address
		/// </summary>
		/// <remarks>Original field type: varchar(100)</remarks>
		public string Email { get; set; }
        
		/// <summary>
		/// Column 'Locked':
		/// true for locked users
		/// </summary>
		/// <remarks>Original field type: </remarks>
		public bool Locked { get; set; }
        
		/// <summary>
		/// Column 'locale':
		/// user preferred locale
		/// </summary>
		/// <remarks>Original field type: varchar(5)</remarks>
		public string Locale { get; set; }

        
		/// <summary>
		/// ForeignKey: Login {'UserId'} -> User {'Userid'} ToDependent: Logins ToPrincipal: User
		/// </summary>
		public virtual ICollection<Login> Logins { get; set; }
        
		/// <summary>
		/// ForeignKey: MessageRead {'UserId'} -> User {'Userid'} ToDependent: MessageReads ToPrincipal: User
		/// </summary>
		public virtual ICollection<MessageRead> MessageReads { get; set; }
        
		/// <summary>
		/// ForeignKey: UsersGroupsLink {'Userid'} -> User {'Userid'} ToDependent: UsersGroupsLinks ToPrincipal: User
		/// </summary>
		public virtual ICollection<UsersGroupsLink> UsersGroupsLinks { get; set; }
    }
}
