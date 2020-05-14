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
	/// Elements of the table 'Messages'.
	/// </summary>
	public partial class Message
    {
        public Message()
        {
            MessageReads = new HashSet<MessageRead>();
            MessageSeenBies = new HashSet<MessageSeenBy>();
        }

        
		/// <summary>
		/// Column 'ID'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int Id { get; set; }
        
		/// <summary>
		/// Column 'Area'
		/// </summary>
		/// <remarks>Original field type: varchar(20)</remarks>
		public string Area { get; set; }
        
		/// <summary>
		/// Column 'MessageFrom'
		/// </summary>
		/// <remarks>Original field type: varchar(100)</remarks>
		public string MessageFrom { get; set; }
        
		/// <summary>
		/// Column 'MessageTo'
		/// </summary>
		/// <remarks>Original field type: varchar(100)</remarks>
		public string MessageTo { get; set; }
        
		/// <summary>
		/// Column 'Subject'
		/// </summary>
		/// <remarks>Original field type: varchar(72)</remarks>
		public string Subject { get; set; }
        
		/// <summary>
		/// Column 'DateTime'
		/// </summary>
		/// <remarks>Original field type: datetime</remarks>
		public DateTime DateTime { get; set; }
        
		/// <summary>
		/// Column 'FidoID'
		/// </summary>
		/// <remarks>Original field type: varchar(50)</remarks>
		public string FidoId { get; set; }
        
		/// <summary>
		/// Column 'FidoReplyTo'
		/// </summary>
		/// <remarks>Original field type: varchar(50)</remarks>
		public string FidoReplyTo { get; set; }
        
		/// <summary>
		/// Column 'TimesRead'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int TimesRead { get; set; }
        
		/// <summary>
		/// Column 'OrigZone'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int OrigZone { get; set; }
        
		/// <summary>
		/// Column 'OrigNet'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int OrigNet { get; set; }
        
		/// <summary>
		/// Column 'OrigNode'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int OrigNode { get; set; }
        
		/// <summary>
		/// Column 'OrigPoint'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int OrigPoint { get; set; }
        
		/// <summary>
		/// Column 'DestZone'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int DestZone { get; set; }
        
		/// <summary>
		/// Column 'DestNet'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int DestNet { get; set; }
        
		/// <summary>
		/// Column 'DestNode'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int DestNode { get; set; }
        
		/// <summary>
		/// Column 'DestPoint'
		/// </summary>
		/// <remarks>Original field type: int(11)</remarks>
		public int DestPoint { get; set; }
        
		/// <summary>
		/// Column 'Body'
		/// </summary>
		/// <remarks>Original field type: text</remarks>
		public string Body { get; set; }

        
		/// <summary>
		/// ForeignKey: Message {'Area'} -> MessageArea {'Id'} ToDependent: Messages ToPrincipal: AreaNavigation
		/// </summary>
		public virtual MessageArea AreaNavigation { get; set; }
        
		/// <summary>
		/// ForeignKey: MessageRead {'MessgeId'} -> Message {'Id'} ToDependent: MessageReads ToPrincipal: Messge
		/// </summary>
		public virtual ICollection<MessageRead> MessageReads { get; set; }
        
		/// <summary>
		/// ForeignKey: MessageSeenBy {'MessageId'} -> Message {'Id'} ToDependent: MessageSeenBies ToPrincipal: Message
		/// </summary>
		public virtual ICollection<MessageSeenBy> MessageSeenBies { get; set; }
    }
}
