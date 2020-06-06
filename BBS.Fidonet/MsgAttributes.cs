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

namespace Casasoft.BBS.Fidonet
{
    /// <summary>
    /// Attributes of messages
    /// </summary>
    /// <remarks>
    /// As described in FTSC-0001 <see cref="http://ftsc.org/docs/fts-0001.016"/>
    /// <code>
    ///  bit       meaning
    ///  ---       --------------------
    ///    0  +    Private
    ///    1  + s  Crash
    ///    2       Recd
    ///    3       Sent
    ///    4  +    FileAttached
    ///    5       InTransit
    ///    6       Orphan
    ///    7       KillSent
    ///    8       Local
    ///    9    s  HoldForPickup
    ///   10  +    unused
    ///   11    s  FileRequest
    ///   12  + s  ReturnReceiptRequest
    ///   13  + s  IsReturnReceipt
    ///   14  + s  AuditRequest
    ///   15    s  FileUpdateReq
    /// 
    ///         s - need not be recognized, but it's ok
    ///         + - not zeroed before packeting
    /// 
    ///Bits numbers ascend with arithmetic significance of bit position.
    /// </code>
    /// </remarks>
    public class MsgAttributes
    {
        /// <summary>
        /// Flags list
        /// </summary>
        public enum Flags
        {
            Private = 0x0001,
            Crash = 0x0002,
            Recd = 0x0004,
            Sent = 0x0008,
            FileAttached = 0x0010,
            InTransit = 0x0020,
            Orphan = 0x0040,
            KillSent = 0x0080,
            Local = 0x0100,
            HoldForPickup = 0x0200,
            unused = 0x0400,
            FileRequest = 0x0800,
            ReturnReceiptRequest = 0x1000,
            IsReturnReceipt = 0x2000,
            AuditRequest = 0x4000,
            FileUpdateReq = 0x8000
        }

        /// <summary>
        /// Binary word of flags
        /// </summary>
        public ushort Binary { get; private set; }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public MsgAttributes()
        {
            ResetAll();
        }

        /// <summary>
        /// Sets binary value
        /// </summary>
        /// <param name="w"></param>
        public MsgAttributes(ushort w)
        {
            Binary = w;
        }

        /// <summary>
        /// Resets all flags
        /// </summary>
        public void ResetAll() => Binary = 0;

        /// <summary>
        /// Sets the flag
        /// </summary>
        /// <param name="f"></param>
        public void Set(Flags f) => Binary |= (ushort)f;

        /// <summary>
        /// Resets the flag
        /// </summary>
        /// <param name="f"></param>
        public void Reset(Flags f) => Binary &= (ushort)~f;

        /// <summary>
        /// Tests if flag is set
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public bool IsSet(Flags f) => (Binary & (ushort)f) > 0;
    }
}
