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

namespace Casasoft.BBS.DataTier
{
    public class bbsUser : User
    {
        public bbsUser() : base() { }

        public bbsUser(User baseClass) : base()
        {
            var type = this.GetType();
            var properties = baseClass.GetType().GetProperties();
            foreach (var property in properties)
            {
                var propToSet = type.GetProperty(property.Name);
                if (propToSet.SetMethod != null)
                {
                    propToSet.SetValue(this, property.GetValue(baseClass));
                }
            }
        }

        public bool CheckPassword(string pwd) => Password == Helpers.CreateMD5(Userid + pwd);

        public void SetPassword(string pwd) => Password = Helpers.CreateMD5(Userid + pwd);

    }
}
