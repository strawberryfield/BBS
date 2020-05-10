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

using Casasoft.BBS.DataTier.DataModel;
using Casasoft.BBS.DataTier;
using System;

namespace Casasoft.BBS.Logger
{
    /// <summary>
    /// Methods to write messages to error output and log table in database
    /// </summary>
    public static class EventLogger
    {
        /// <summary>
        /// Writes message to error output and log table in database
        /// </summary>
        /// <param name="message"></param>
        /// <param name="level">severity level</param>
        /// <param name="remote">client remote address</param>
        public static void Write(string message, sbyte level, string remote)
        {
            using (bbsContext db = new bbsContext())
            {
                db.Logs.Add(new Log() { Level = level, Description = message, Remote = remote });
                db.SaveChanges();
            }
            Console.Error.WriteLine("{0} {1} {2,-22} {3}",  
                new object[] { DateTime.Now, level, remote, message });
        }

        /// <summary>
        /// Writes message to error output and log table in database
        /// </summary>
        /// <param name="message"></param>
        /// <param name="level">severity level</param>
        public static void Write(string message, sbyte level) => Write(message, level, string.Empty);

        /// <summary>
        /// Writes message to error output and log table in database
        /// severity =1
        /// </summary>
        /// <param name="message"></param>
        /// <param name="remote">client remote address</param>
        public static void Write(string message, string remote) => Write(message, 1, remote);

        /// <summary>
        /// Writes message to error output and log table in database
        /// severity =1
        /// </summary>
        /// <param name="message"></param>
        public static void Write(string message) => Write(message, 1);
    }
}
