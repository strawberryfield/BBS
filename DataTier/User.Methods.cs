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
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;

namespace Casasoft.BBS.DataTier.DataModel
{
    /// <summary>
    /// User entity
    /// </summary>
    public partial class User
    {
        /// <summary>
        /// Checks a password against its saved hash
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool CheckPassword(string pwd) => Password == DbHelpers.CreateMD5(Userid + pwd);

        /// <summary>
        /// Saves the hash of a password
        /// </summary>
        /// <param name="pwd"></param>
        public void SetPassword(string pwd)
        {
            Password = DbHelpers.CreateMD5(Userid + pwd);
            LastPasswordModify = DateTime.Now;
        }

        private NameValueCollection GetSecurityOptions() => (NameValueCollection)ConfigurationManager.GetSection("Security");

        /// <summary>
        /// Checks if the username meets bbs rules
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool AcceptableUsername(string name)
        {
            bool ret = true;
            string unwanted = GetSecurityOptions()["UnwantedUsers"];
            if (!string.IsNullOrWhiteSpace(unwanted))
            {
                string[] prefixes = unwanted.ToUpper().Split(',');
                foreach (string s in prefixes)
                {
                    ret = !name.StartsWith(s.Trim());
                    if (!ret) break;
                }
            }
            return ret;
        }

        /// <summary>
        /// Checks if a paasword meets security rules
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool AcceptablePassword(string pwd)
        {
            NameValueCollection opt = GetSecurityOptions();

            if (pwd.Length < Convert.ToInt16(opt["PasswordMinLength"])) return false;
            if(opt["PasswordWantUpperLower"].ToUpper()[0] == 'Y')
            {
                if (!pwd.Any(char.IsUpper) || !pwd.Any(char.IsLower)) return false;
            }
            if (opt["PasswordWantDigit"].ToUpper()[0] == 'Y')
            {
                if (!pwd.Any(char.IsDigit)) return false;
            }
            if (opt["PasswordWantSpecial"].ToUpper()[0] == 'Y')
            {
                if (!pwd.Any(c => !char.IsLetterOrDigit(c))) return false;
            }
            return true;
        }

        /// <summary>
        /// Checks if a password is expired
        /// </summary>
        /// <returns></returns>
        public bool ExpiredPassword()
        {
            int days = Convert.ToInt16(GetSecurityOptions()["PasswordExpires"]);
            if (days == 0) return false;
            if ((DateTime.Now - LastPasswordModify).TotalDays > days) return true;
            return false;
        }

        /// <summary>
        /// Checks if user meets access restrictions
        /// </summary>
        /// <param name="required"></param>
        /// <returns></returns>
        public bool HasRights(string required)
        {
            if (string.IsNullOrWhiteSpace(required)) return true;
            string[] groupsArray = required.ToUpper().Split(',');
            foreach(string g in groupsArray)
            {
                foreach(var has in UsersGroupsLinks)
                {
                    if (has.Groupid.ToUpper() == g) return true;
                }
            }
            return false;
        }
    }
}
