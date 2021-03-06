﻿// copyright (c) 2020 Roberto Ceccarelli - CasaSoft
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
    /// <summary>
    /// Message area entity
    /// </summary>
    public partial class MessageArea
    {
        /// <summary>
        /// Total number of messages in the area
        /// </summary>
        public int MessagesCount { get => Messages.Count; }

        /// <summary>
        /// Tests if the user can read this message area
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Readable(User user) => user.HasRights(AllowedGroupRead);

        /// <summary>
        /// Tests if the user can write into this message area
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool Writable(User user) => user.HasRights(AllowedGroupWrite);

        /// <summary>
        /// Number of messages posted after the timestamp
        /// </summary>
        /// <param name="since">reference timestamp</param>
        /// <returns></returns>
        public int NewMessagesCount(DateTime since) => Messages.Where(d => d.DateTime >= since).Count();
        
        /// <summary>
        /// Number of message not already read by the user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public int UnreadMessagesCount(string username) =>
            Messages.Where(m => !m.MessageReads.Select(u => u.UserId).Contains(username)).Count();

        /// <summary>
        /// List of messages posted after the timestamp
        /// </summary>
        /// <param name="since">reference timestamp</param>
        /// <returns></returns>
        public IEnumerable<Message> NewMessages(DateTime since) => Messages.Where(m => m.DateTime >= since);

        /// <summary>
        /// List of messages not already read by the user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public IEnumerable<Message> UnreadMessages(string username) =>
            Messages.Where(m => !m.MessageReads.Select(u => u.UserId).Contains(username));
    }
} 
