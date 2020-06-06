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
using System.Globalization;

namespace Casasoft.BBS.Fidonet
{
    /// <summary>
    /// Utilities for Fidonet messages
    /// </summary>
    public static class FidonetHelpers
    {
        /// <summary>
        /// Formats a datetime in SEAdog format
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        /// <remarks>
        /// Format as described in FTSC-0001 <see cref="http://ftsc.org/docs/fts-0001.016"/>
        /// <code>
        /// DateTime  = (* a character string 20 characters long *)
        ///             (* SEAdog format Mon  1 Jan 86 02:34 *)
        ///             DayOfWk " " DayOfMo " " Month " " Year " " HH ":" MM Null
        ///
        ///DayOfWk    = "Mon" | "Tue" | "Wed" | "Thu" | "Fri" | "Sat" | "Sun"
        ///DayOfMo    = " 1" | " 2" | " 3" | ... | "31"  (* blank fill *)
        /// </code>
        /// </remarks>
        static public string SEAdogFormatDatetime(DateTime dt) =>
            string.Format(CultureInfo.InvariantCulture, "{0:ddd} {1,2} {2:dd MMM yy HH:mm}", dt, dt.Day, dt );

        /// <summary>
        /// Formats a datetime in Fido format
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        /// <remarks>
        /// Format as described in FTSC-0001 <see cref="http://ftsc.org/docs/fts-0001.016"/>
        /// <code>
        /// DateTime   = (* a character string 20 characters long*)
        ///              (* 01 Jan 86  02:34:56 *)
        ///              DayOfMonth " " Month " " Year " "
        ///              " " HH ":" MM ":" SS
        ///              Null
        /// 
        /// DayOfMonth = "01" | "02" | "03" | ... | "31"   (* Fido 0 fills*)
        /// Month      = "Jan" | "Feb" | "Mar" | "Apr" | "May" | "Jun" |
        ///              "Jul" | "Aug" | "Sep" | "Oct" | "Nov" | "Dec"
        /// Year       = "01" | "02" | .. | "85" | "86" | ... | "99" | "00"
        /// HH         = "00" | .. | "23"
        /// MM         = "00" | .. | "59"
        /// SS         = "00" | .. | "59"
        /// </code>
        /// </remarks>
        static public string FidoFormatDatetime(DateTime dt) =>
            dt.ToString("dd MMM yy  HH:mm:ss", CultureInfo.InvariantCulture);

        /// <summary>
        /// Low order byte of a word
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        static public byte LowOrder(ushort w) => (byte)(w & 0xff);

        /// <summary>
        /// High order byte of a word
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        static public byte HighOrder(ushort w) => (byte)((w >> 8) & 0xff);

    }
}
