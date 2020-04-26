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
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Linq;

namespace Casasoft.BBS.DataTier
{
    public class bbsContext : DBContext.bbsContext
    {
        public bbsContext()
        {
        }

        public bbsContext(DbContextOptions<DBContext.bbsContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets connection string from app.config
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                string serverVersion = ConfigurationManager.ConnectionStrings["DB"].ProviderName;
                optionsBuilder.UseLazyLoadingProxies().UseMySql(connString, x => x.ServerVersion(serverVersion));
            }
        }

        #region custom methods
        public User GetUserByUsername(string username) => Users.Where(u => u.Userid == username).FirstOrDefault();

        public IQueryable<MessageArea> GetMessageAllowedAreasByGroup(string group, string username) =>
            string.IsNullOrWhiteSpace(group) ? MessageAreas :
            MessageAreas.Where(a => a.Areagroup == group.ToUpper()).Where(
                g => g.AllowedGroupRead == null
                || UsersGroupsLinks.Where(u => u.Userid == username).Select(ug => ug.Groupid).Contains(g.AllowedGroupRead));

        public IQueryable<MessageAreasGroup> GetAllowedMessageAreasGroup(string username) =>
            MessageAreasGroups.Where(
                g => g.AllowedGroupId == null
                || UsersGroupsLinks.Where(u => u.Userid == username).Select(ug => ug.Groupid).Contains(g.AllowedGroupId));
        #endregion
    }
}
