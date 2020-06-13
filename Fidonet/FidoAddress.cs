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

namespace Casasoft.Fidonet
{
    /// <summary>
    /// 5D Fidonet address handler
    /// </summary>
    public class FidoAddress
    {
        #region fields
        /// <summary>
        /// zone
        /// </summary>
        public ushort zone { get; set; }

        /// <summary>
        /// net
        /// </summary>
        public ushort net { get; set; }

        /// <summary>
        /// node
        /// </summary>
        public ushort node { get; set; }

        /// <summary>
        /// point
        /// </summary>
        public ushort point { get; set; }

        /// <summary>
        /// domain
        /// </summary>
        public string domain { get; set; }
        #endregion

        #region constructors
        /// <summary>
        /// Empty constructor
        /// </summary>
        public FidoAddress()
        {
            zone = 0;
            net = 0;
            node = 0;
            point = 0;
            domain = string.Empty;
        }

        /// <summary>
        /// Builds object by single int elements
        /// </summary>
        /// <param name="zone"></param>
        /// <param name="net"></param>
        /// <param name="node"></param>
        /// <param name="point"></param>
        public FidoAddress(int zone, int net, int node, int point)
        {
            this.zone = (ushort)zone;
            this.net = (ushort)net;
            this.node = (ushort)node;
            this.point = (ushort)point;
        }

        /// <summary>
        /// parses address from string
        /// </summary>
        /// <param name="addr"></param>
        public FidoAddress(string addr) : this()
        {
            int sep = addr.IndexOf('@');
            if (sep >= 0)
            {
                domain = addr.Substring(sep + 1);
                addr = addr.Substring(0, sep);
            }

            sep = addr.IndexOf(':');
            if (sep >= 0)
            {
                zone = Convert.ToUInt16(addr.Substring(0, sep));
                addr = addr.Substring(sep + 1);
            }

            sep = addr.IndexOf('/');
            if (sep >= 0)
            {
                net = Convert.ToUInt16(addr.Substring(0, sep));
                addr = addr.Substring(sep + 1);
            }

            sep = addr.IndexOf('.');
            if (sep >= 0)
            {
                node = Convert.ToUInt16(addr.Substring(0, sep));
                addr = addr.Substring(sep + 1);
                point = Convert.ToUInt16(addr);
            }
            else
            {
                node = Convert.ToUInt16(addr);
            }
        }
        #endregion

        /// <summary>
        /// Formatted 4d address
        /// </summary>
        public string address4D
        {
            get =>
                (zone > 0 ? $"{zone}:" : "") +
                $"{net}/{node}" +
                (point > 0 ? $".{point}" : "");
        }

        /// <summary>
        /// Formatted 5d address
        /// </summary>
        public string address5D
        {
            get =>
                address4D +
                (string.IsNullOrWhiteSpace(domain) ? "" : $"@{domain}");
        }
    }
}
