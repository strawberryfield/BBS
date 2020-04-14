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
    public partial class User
    {
        public bool CheckPassword(string pwd) => Password == DbHelpers.CreateMD5(Userid + pwd);

        public void SetPassword(string pwd)
        {
            Password = DbHelpers.CreateMD5(Userid + pwd);
            LastPasswordModify = DateTime.Now;
        }

        private NameValueCollection GetSecurityOptions() => (NameValueCollection)ConfigurationManager.GetSection("Security");

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

        public bool ExpiredPassword()
        {
            int days = Convert.ToInt16(GetSecurityOptions()["PasswordExpires"]);
            if (days == 0) return false;
            if ((DateTime.Now - LastPasswordModify).TotalDays > days) return true;
            return false;
        }
    }
}
