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
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Casasoft.BBS.DataTier.DataModel;

namespace Casasoft.BBS.DataTier.DBContext
{
    /// <summary>
	/// Model for the database 'bbs'.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("EntityFrameworkCore", "3.1.4")]
	public partial class bbsContext : DbContext
    {
        public bbsContext()
        {
        }

        public bbsContext(DbContextOptions<bbsContext> options)
            : base(options)
        {
        }

        
		/// <summary>
		/// Table 'FidoNetworks':
		/// List of fdo-style networks
		/// </summary>
		public virtual DbSet<FidoNetwork> FidoNetworks { get; set; }
        
		/// <summary>
		/// Table 'Log':
		/// Events log
		/// </summary>
		public virtual DbSet<Log> Logs { get; set; }
        
		/// <summary>
		/// Table 'Logins':
		/// Users logins
		/// </summary>
		public virtual DbSet<Login> Logins { get; set; }
        
		/// <summary>
		/// Table 'Messages':
		/// Messages
		/// </summary>
		public virtual DbSet<Message> Messages { get; set; }
        
		/// <summary>
		/// Table 'MessageAreas':
		/// Message Areas List
		/// </summary>
		public virtual DbSet<MessageArea> MessageAreas { get; set; }
        
		/// <summary>
		/// Table 'MessageAreasGroups'
		/// </summary>
		public virtual DbSet<MessageAreasGroup> MessageAreasGroups { get; set; }
        
		/// <summary>
		/// Table 'MessageRead':
		/// Flags for messages read
		/// </summary>
		public virtual DbSet<MessageRead> MessageReads { get; set; }
        
		/// <summary>
		/// Table 'MessageSeenBy':
		/// System that already received the message
		/// </summary>
		public virtual DbSet<MessageSeenBy> MessagesSeenBy { get; set; }
        
		/// <summary>
		/// Table 'Users':
		/// BBS users
		/// </summary>
		public virtual DbSet<User> Users { get; set; }
        
		/// <summary>
		/// Table 'UsersGroups':
		/// Users groups definition
		/// </summary>
		public virtual DbSet<UsersGroup> UsersGroups { get; set; }
        
		/// <summary>
		/// Table 'UsersGroupsLinks':
		/// Users groups
		/// </summary>
		public virtual DbSet<UsersGroupsLink> UsersGroupsLinks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=192.168.1.10;database=bbs;user=bbs;password=password", x => x.ServerVersion("10.3.22-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FidoNetwork>(entity =>
            {
                entity.HasComment("List of fdo-style networks");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasComment("Fido style network identifier")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("varchar(80)")
                    .HasComment("Network description")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Host)
                    .HasColumnName("host")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Net)
                    .HasColumnName("net")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Zone)
                    .HasColumnName("zone")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.HasComment("Events log");

                entity.HasIndex(e => e.DateTime)
                    .HasName("DateTime");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .HasComment("Timestamp of the event, set to current timestamp by default");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Severity level");

                entity.Property(e => e.Remote)
                    .IsRequired()
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("''")
                    .HasComment("Remote ip address and port of the client (if applicable)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasComment("Users logins");

                entity.HasIndex(e => e.DateTime)
                    .HasName("DateTime");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserId");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .HasComment("timestamp set to current timestamp by default");

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("''")
                    .HasComment("remote ip address and port of the client")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Success).HasComment("true if login was successful");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasComment("username supplied for the login")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Logins_UserId_Users");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasComment("Messages");

                entity.HasIndex(e => e.Area)
                    .HasName("Area");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Area)
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.DestNet).HasColumnType("int(11)");

                entity.Property(e => e.DestNode).HasColumnType("int(11)");

                entity.Property(e => e.DestPoint).HasColumnType("int(11)");

                entity.Property(e => e.DestZone).HasColumnType("int(11)");

                entity.Property(e => e.FidoId)
                    .IsRequired()
                    .HasColumnName("FidoID")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FidoReplyTo)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MessageFrom)
                    .IsRequired()
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MessageTo)
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrigNet).HasColumnType("int(11)");

                entity.Property(e => e.OrigNode).HasColumnType("int(11)");

                entity.Property(e => e.OrigPoint).HasColumnType("int(11)");

                entity.Property(e => e.OrigZone).HasColumnType("int(11)");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnType("varchar(72)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TimesRead).HasColumnType("int(11)");

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.Area)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("Message_Area_MessageAreas");
            });

            modelBuilder.Entity<MessageArea>(entity =>
            {
                entity.HasComment("Message Areas List");

                entity.HasIndex(e => e.AllowedGroupRead)
                    .HasName("MessageAreas_AllowedRead_UsersGroups");

                entity.HasIndex(e => e.AllowedGroupWrite)
                    .HasName("MessageAreas_AllowedWrite_UsersGroups");

                entity.HasIndex(e => e.Areagroup)
                    .HasName("MessageAreas_AreaGroupId_MessageAreasGroups");

                entity.HasIndex(e => e.Description)
                    .HasName("Description");

                entity.HasIndex(e => e.Fidoid)
                    .HasName("FIDOID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("varchar(20)")
                    .HasComment("Message area identifier")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AllowedGroupRead)
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasComment("User group needed to access this area")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AllowedGroupWrite)
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasComment("User group needed to write in this area")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Areagroup)
                    .IsRequired()
                    .HasColumnName("AREAGROUP")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasComment("Gruop that area belongs to")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fidoid)
                    .IsRequired()
                    .HasColumnName("FIDOID")
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasComment("Message area identifier for fido network")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.AllowedGroupReadNavigation)
                    .WithMany(p => p.MessageAreaAllowedGroupReadNavigations)
                    .HasForeignKey(d => d.AllowedGroupRead)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("MessageAreas_AllowedRead_UsersGroups");

                entity.HasOne(d => d.AllowedGroupWriteNavigation)
                    .WithMany(p => p.MessageAreaAllowedGroupWriteNavigations)
                    .HasForeignKey(d => d.AllowedGroupWrite)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("MessageAreas_AllowedWrite_UsersGroups");

                entity.HasOne(d => d.AreagroupNavigation)
                    .WithMany(p => p.MessageAreas)
                    .HasForeignKey(d => d.Areagroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MessageAreas_AreaGroupId_MessageAreasGroups");
            });

            modelBuilder.Entity<MessageAreasGroup>(entity =>
            {
                entity.HasIndex(e => e.AllowedGroupId)
                    .HasName("MessageAreasGroups_Allowed_UsersGroups");

                entity.HasIndex(e => e.Description)
                    .HasName("Description");

                entity.HasIndex(e => e.FidoNetwork)
                    .HasName("MessageAreasGroups_FidoNetwork_Fidonetworks");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
                    .HasComment("Areas group id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AllowedGroupId)
                    .HasColumnType("varchar(30)")
                    .HasComment("User group needed for access this group")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FidoNetwork)
                    .HasColumnType("varchar(30)")
                    .HasComment("Fido style network for exchange")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.AllowedGroup)
                    .WithMany(p => p.MessageAreasGroups)
                    .HasForeignKey(d => d.AllowedGroupId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("MessageAreasGroups_Allowed_UsersGroups");

                entity.HasOne(d => d.FidoNetworkNavigation)
                    .WithMany(p => p.MessageAreasGroups)
                    .HasForeignKey(d => d.FidoNetwork)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("MessageAreasGroups_FidoNetwork_Fidonetworks");
            });

            modelBuilder.Entity<MessageRead>(entity =>
            {
                entity.ToTable("MessageRead");

                entity.HasComment("Flags for messages read");

                entity.HasIndex(e => e.MessgeId)
                    .HasName("MessageId");

                entity.HasIndex(e => e.UserId)
                    .HasName("UserId");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MessgeId).HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Messge)
                    .WithMany(p => p.MessageReads)
                    .HasForeignKey(d => d.MessgeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MessageRead_MessageId_Messages");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MessageReads)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MessageRead_UserId_Users");
            });

            modelBuilder.Entity<MessageSeenBy>(entity =>
            {
                entity.ToTable("MessageSeenBy");

                entity.HasComment("System that already received the message");

                entity.HasIndex(e => e.MessageId)
                    .HasName("MessageId");

                entity.HasIndex(e => e.SeenBy)
                    .HasName("SeenBy");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MessageId).HasColumnType("int(11)");

                entity.Property(e => e.SeenBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.MessagesSeenBy)
                    .HasForeignKey(d => d.MessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MessageSeenBy_MsgId_Messages");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasComment("BBS users");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("varchar(30)")
                    .HasComment("Nickname")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasComment("city of the user")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''")
                    .HasComment("internet email address")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastLoginDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.LastLoginFrom)
                    .IsRequired()
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("'0.0.0.0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastPasswordModify)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasColumnName("locale")
                    .HasColumnType("varchar(5)")
                    .HasDefaultValueSql("''")
                    .HasComment("user preferred locale")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Locked).HasComment("true for locked users");

                entity.Property(e => e.Nation)
                    .IsRequired()
                    .HasColumnName("nation")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasComment("nation of the user")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(32)")
                    .HasComment("MD5 Hash of the password")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Realname)
                    .IsRequired()
                    .HasColumnName("realname")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasComment("Real name")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Registered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'")
                    .HasComment("timestamp of registration to the bbs");

                entity.Property(e => e.Signature)
                    .IsRequired()
                    .HasColumnName("signature")
                    .HasColumnType("text")
                    .HasDefaultValueSql("'\\\\''\\\\'''")
                    .HasComment("signature for messages")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<UsersGroup>(entity =>
            {
                entity.HasKey(e => e.Groupid)
                    .HasName("PRIMARY");

                entity.HasComment("Users groups definition");

                entity.Property(e => e.Groupid)
                    .HasColumnType("varchar(30)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<UsersGroupsLink>(entity =>
            {
                entity.HasComment("Users groups");

                entity.HasIndex(e => e.Groupid)
                    .HasName("UsersGroupsLinks_groupid_groups");

                entity.HasIndex(e => e.Userid)
                    .HasName("userid");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.UsersGroupsLinks)
                    .HasForeignKey(d => d.Groupid)
                    .HasConstraintName("UsersGroupsLinks_groupid_groups");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersGroupsLinks)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("UsersGroupsLinks_userid_users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
