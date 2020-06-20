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
using System.Globalization;

namespace Casasoft.Fidonet
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
            string.Format(CultureInfo.InvariantCulture, "{0:ddd} {1,2} {2:MMM yy HH:mm}", dt, dt.Day, dt);

        /// <summary>
        /// Gets a datetime from a SEAdog formatted string
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        static public DateTime ParseSEAdogDatetime(string ds)
        {
            DateTime ret;
            if (!DateTime.TryParseExact(ds.Trim('\0').Trim(), "ddd dd MMM yy HH:mm",
                CultureInfo.InvariantCulture,
                DateTimeStyles.AllowInnerWhite, out ret))
                ret = DateTime.MinValue;
            return ret;
        }

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
        /// Gets a datetime from a Fido formatted string
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        static public DateTime ParseFidoDatetime(string ds)
        {
            DateTime ret;
            if (!DateTime.TryParseExact(ds.Trim('\0').Trim(), "dd MMM yy  HH:mm:ss",
                CultureInfo.InvariantCulture,
                DateTimeStyles.AllowInnerWhite, out ret))
                ret = DateTime.MinValue;
            return ret;
        }

        /// <summary>
        /// Parses a datetime string
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        static public DateTime ParseDatetime(string ds)
        {
            if (char.IsLetter(ds.Trim()[0]))
                return ParseSEAdogDatetime(ds);
            else
                return ParseFidoDatetime(ds);
        }

        /// <summary>
        /// Low order byte of a word
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        static public byte LowOrder(ushort w) => (byte)(w & 0xff);

        /// <summary>
        /// Low order byte of a int
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static public byte LowOrder(int i) => (byte)(i & 0xff);

        /// <summary>
        /// High order byte of a word
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        static public byte HighOrder(ushort w) => (byte)((w >> 8) & 0xff);

        /// <summary>
        /// High order byte of a int
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static public byte HighOrder(int i) => (byte)((i >> 8) & 0xff);

        /// <summary>
        /// Gets ushort value from byte array
        /// </summary>
        /// <param name="data"></param>
        /// <param name="pointer"></param>
        /// <returns></returns>
        static public ushort GetUShort(byte[] data, int pointer) =>
            (ushort)(data[pointer] + data[pointer + 1] * 256);

        /// <summary>
        /// Gets int value from byte array
        /// </summary>
        /// <param name="data"></param>
        /// <param name="pointer"></param>
        /// <returns></returns>
        static public int GetInt(byte[] data, int pointer) =>
            GetUShort(data, pointer) + GetUShort(data, pointer + 2) * 256;

        /// <summary>
        /// Gets a Pascal-like string
        /// </summary>
        /// <remarks>
        /// First byte contains the string length
        /// </remarks>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        static public string GetPascalString(byte[] buffer, int offset) =>
            BytesToString(buffer, offset + 1, buffer[offset]);

        /// <summary>
        /// Converts a byte array to string
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        static public string BytesToString(byte[] buffer, int offset, int length)
        {
            if (buffer.Length < offset + length) length = buffer.Length - offset;
            unsafe
            {
                fixed (byte* pAscii = buffer)
                {
                    return new string((sbyte*)pAscii, offset, length);
                }
            }
        }

        /// <summary>
        /// Converts a null terminated byte array to string
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        static public string NullTerminatedBytesToString(byte[] buffer, int offset)
        {
            int end = offset;
            while (end < buffer.Length && buffer[end] != 0)
            {
                end++;
            }
            return BytesToString(buffer, offset, end - offset);
        }

        /// <summary>
        /// Converts a string to a fixed length list of bytes
        /// </summary>
        /// <param name="s"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        static public List<byte> ToFixedLength(string s, int len)
        {
            List<byte> ret = new List<byte>(len);
            for (int j = 0; j < len; j++) ret.Add(0);
            for (int j = 0; j < len && j < s.Length; j++) ret[j] = (byte)s[j];
            return ret;
        }

        /// <summary>
        /// Converts a string to a maximum length list of bytes
        /// </summary>
        /// <param name="s"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        static public List<byte> ToMaxLength(string s, int len)
        {
            List<byte> ret = new List<byte>(len);
            int retSize = Math.Min(len, s.Length);
            for (int j = 0; j < retSize; j++) ret.Add(0);
            for (int j = 0; j < retSize; j++) ret[j] = (byte)s[j];
            if (s.Length >= len) 
                ret[len - 1] = 0;
            else 
                ret.Add(0);
            return ret;
        }

        /// <summary>
        /// Converts a string to a null terminated list of bytes
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static public List<byte> ToUnbounded(string s) => ToMaxLength(s, s.Length + 1);
    }
}
