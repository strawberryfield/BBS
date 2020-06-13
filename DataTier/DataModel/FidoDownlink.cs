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
	/// Elements of the table 'FidoDownlinks':
	/// Downlinks for fido networks
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("EntityFrameworkCore", "3.1.4")]
	public partial class FidoDownlink
    {
        
		/// <summary>
		/// Column 'ID'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int Id { get; set; }
        
		/// <summary>
		/// Column 'FidoNetwork':
		/// Fido network for the downlink
		/// </summary>
		/// <remarks>Original field type: varchar(30)</remarks>
		public string FidoNetwork { get; set; }
        
		/// <summary>
		/// Column 'zone'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int Zone { get; set; }
        
		/// <summary>
		/// Column 'net'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int Net { get; set; }
        
		/// <summary>
		/// Column 'node'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int Node { get; set; }
        
		/// <summary>
		/// Column 'point'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int Point { get; set; }
        
		/// <summary>
		/// Column 'Description'
		/// </summary>
		/// <remarks>Original field type: varchar(80)</remarks>
		public string Description { get; set; }

        
		/// <summary>
		/// ForeignKey: FidoDownlink {'FidoNetwork'} -> FidoNetwork {'Id'} ToDependent: FidoDownlinks ToPrincipal: FidoNetworkNavigation
		/// </summary>
		public virtual FidoNetwork FidoNetworkNavigation { get; set; }
    }
}
