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

using Casasoft.BBS.DataTier.DataModel;
using Casasoft.BBS.DataTier.DBContext;
using System;

namespace Casasoft.BBS.Logger
{
    public static class EventLogger
    {
        private static bbsContext db;

        static EventLogger()
        {
            db = new bbsContext();
        }

        public static void Write(string message, sbyte level)
        {
            db.Log.Add(new Log() { Level = level, Description = message });
            db.SaveChanges();
            Console.Error.WriteLine("{0} {1} {2}", DateTime.Now, level, message);
        }

        public static void Write(string message)
        {
            Write(message, 0);
        }
    }
}