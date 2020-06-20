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

using Casasoft.Fidonet;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Text;

namespace Casasoft.HudsonBase
{
    /// <summary>
    /// In-memory messagebase model
    /// </summary>
    public class Messages
    {
        public MsgIdx Index;
        public MsgHdr Headers;
        public Dictionary<int, string> Areas;
        public Dictionary<int, string> MsgBodies;

        public Messages()
        {
            NameValueCollection dirSettings = (NameValueCollection)ConfigurationManager.GetSection("HudsonBase/Dir");
            string baseDir = dirSettings["msgdir"];

            Areas = new Dictionary<int, string>();
            NameValueCollection areasList = (NameValueCollection)ConfigurationManager.GetSection("HudsonBase/Areas");
            foreach(string key in areasList)
                Areas.Add(Convert.ToInt16(key), areasList[key]);

            Index = new MsgIdx(Path.Combine(baseDir, "MSGIDX.BBS"));
            Headers = new MsgHdr(Path.Combine(baseDir, "MSGHDR.BBS"));
            MsgBodies = new Dictionary<int, string>();
            byte[] text = File.ReadAllBytes(Path.Combine(baseDir, "MSGTXT.BBS"));
            foreach(MsgHdr.MsgHdrRecord h in Headers.Data)
            {
                StringBuilder sb = new StringBuilder();
                for(int j = 0; j < h.NumBlocks; j++)
                {
                    sb.Append(FidonetHelpers.GetPascalString(text, (h.StartBlock + j) * 256));
                }
                MsgBodies.Add(h.MsgNum, sb.ToString());
            }
        }
    }
}
