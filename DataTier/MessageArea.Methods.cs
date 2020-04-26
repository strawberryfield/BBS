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
using System.Linq;

namespace Casasoft.BBS.DataTier.DataModel
{
    public partial class MessageArea
    {
        public int MessagesCount { get => Messages.Count; }

        public bool Readable(User user) => user.HasRights(AllowedGroupRead);
        public bool Writable(User user) => user.HasRights(AllowedGroupWrite);

        public int NewMessagesCount(DateTime since) => Messages.Where(d => d.DateTime >= since).Count();
        public int UnreadMessagesCount(string username) =>
            Messages.Where(m => !m.MessageReads.Select(u => u.UserId).Contains(username)).Count();

        public IEnumerable<Message> NewMessages(DateTime since) => Messages.Where(m => m.DateTime >= since);

        public IEnumerable<Message> UnreadMessages(string username) =>
            Messages.Where(m => !m.MessageReads.Select(u => u.UserId).Contains(username));
    }
}
