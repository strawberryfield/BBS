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

using Casasoft.BBS.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;

namespace Casasoft.BBS.Parser
{
    /// <summary>
    /// Available tags
    /// </summary>
    public enum Entities
    {
        /// <summary>
        /// Ampersand
        /// </summary>
        AMP,
        /// <summary>
        /// Left curly bracket
        /// </summary>
        LEFTCURLY,
        /// <summary>
        /// Right curly bracket
        /// </summary>
        RIGHTCURLY,
        /// <summary>
        /// Username
        /// </summary>
        USERNAME, 
        /// <summary>
        /// Remote ip address
        /// </summary>
        REMOTE, 
        /// <summary>
        /// date and time of client connection
        /// </summary>
        CONNECTIONTIME,
        /// <summary>
        /// a with grave accent
        /// </summary>
        AGRAVE,
        /// <summary>
        /// e with grave accent
        /// </summary>
        EGRAVE,
        /// <summary>
        /// i with grave accent
        /// </summary>
        IGRAVE,
        /// <summary>
        /// o with grave accent
        /// </summary>
        OGRAVE,
        /// <summary>
        /// u with grave accent
        /// </summary>
        UGRAVE,
        /// <summary>
        /// e with acute accent
        /// </summary>
        EACUTE,
        /// <summary>
        /// Columns in the terminal
        /// </summary>
        SCREENWIDTH, 
        /// <summary>
        /// Rows in the terminal
        /// </summary>
        SCREENHEIGHT, 
        /// <summary>
        /// Terminal type id
        /// </summary>
        TERMINALTYPE
    }

    /// <summary>
    /// List of available entities
    /// </summary>
    public class EntitiesDict
    {
        private Dictionary<string, Entities> EntitiesTable;
        private Dictionary<string, string> CustomEntitiesTable;

        private IBBSClient client;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="c">Reference to the client</param>
        public EntitiesDict(IBBSClient c)
        {
            client = c;

            EntitiesTable = new Dictionary<string, Entities>();
            foreach (Entities t in Enum.GetValues(typeof(Entities)))
                EntitiesTable.Add(t.ToString().ToUpper(), t);

            CustomEntitiesTable = new Dictionary<string, string>();
            NameValueCollection config = (NameValueCollection)ConfigurationManager.GetSection("Entities");
            foreach (string key in config)
                CustomEntitiesTable.Add(key.Trim().ToUpper(), config[key]);
        }

        /// <summary>
        /// Gets entity value by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>string.Empty if the name is not found</returns>
        public string GetValue(string name)
        {
            Entities entity;
            if (EntitiesTable.TryGetValue(name, out entity)) switch (entity)
                {
                    case Entities.AMP:
                        return "&";
                    case Entities.LEFTCURLY:
                        return "{";
                    case Entities.RIGHTCURLY:
                        return "}";
                    case Entities.USERNAME:
                        return string.IsNullOrWhiteSpace(client.username) ? "GUEST" : client.username;
                    case Entities.REMOTE:
                        return client.Remote;
                    case Entities.CONNECTIONTIME:
                        return client.connectedAt.ToString("g");
                    case Entities.AGRAVE:
                        return "a'";
                    case Entities.EGRAVE:
                        return "e'";
                    case Entities.IGRAVE:
                        return "i'";
                    case Entities.OGRAVE:
                        return "o'";
                    case Entities.UGRAVE:
                        return "u'";
                    case Entities.EACUTE:
                        return "e'";
                    case Entities.SCREENWIDTH:
                        return client.screenWidth.ToString();
                    case Entities.SCREENHEIGHT:
                        return client.screenHeight.ToString();
                    case Entities.TERMINALTYPE:
                        return client.terminalType;
                    default:
                        return string.Empty;
                }
            else
            {
                string customEntity;
                if (CustomEntitiesTable.TryGetValue(name, out customEntity))
                    return customEntity;
                else
                    return string.Empty;
            }

        }
    }
}
