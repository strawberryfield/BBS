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
	/// Elements of the table 'MessageSeenBy':
	/// System that already received the message
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("EntityFrameworkCore", "3.1.4")]
	public partial class MessageSeenBy
    {
        
		/// <summary>
		/// Column 'ID'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int Id { get; set; }
        
		/// <summary>
		/// Column 'MessageId':
		/// Internal id of message
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int MessageId { get; set; }
        
		/// <summary>
		/// Column 'SeenBy':
		/// List of nodes that already saw the messase
		/// </summary>
		/// <remarks>Original field type: varchar(80)</remarks>
		public string SeenBy { get; set; }

        
		/// <summary>
		/// ForeignKey: MessageSeenBy {'MessageId'} -> Message {'Id'} ToDependent: MessageSeenBies ToPrincipal: Message ClientSetNull
		/// </summary>
		public virtual Message Message { get; set; }
    }
}
