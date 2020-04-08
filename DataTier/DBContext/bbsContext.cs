using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Casasoft.BBS.DataTier.DataModel;

namespace Casasoft.BBS.DataTier.DBContext
{
    public partial class bbsContext : DbContext
    {
        public bbsContext()
        {
        }

        public bbsContext(DbContextOptions<bbsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageArea> MessageAreas { get; set; }
        public virtual DbSet<MessageAreasGroup> MessageAreasGroups { get; set; }
        public virtual DbSet<MessageRead> MessagesRead { get; set; }
        public virtual DbSet<MessageSeenBy> MessagesSeenBy { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersGroup> UsersGroups { get; set; }
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
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Remote)
                    .IsRequired()
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("''")
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
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasColumnType("varchar(24)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserId_Users");
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
                    .IsRequired()
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
            });

            modelBuilder.Entity<MessageArea>(entity =>
            {
                entity.HasComment("Message Areas List");

                entity.HasIndex(e => e.Description)
                    .HasName("Description");

                entity.HasIndex(e => e.Fidoid)
                    .HasName("FIDOID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Areagroup)
                    .IsRequired()
                    .HasColumnName("AREAGROUP")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''")
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
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<MessageAreasGroup>(entity =>
            {
                entity.HasIndex(e => e.Description)
                    .HasName("Description");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
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
                    .HasConstraintName("MessageId_Messages");
            });

            modelBuilder.Entity<MessageSeenBy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MessageSeenBy");

                entity.HasComment("System that already received the message");

                entity.HasIndex(e => e.MessageId)
                    .HasName("MessageId");

                entity.HasIndex(e => e.SeenBy)
                    .HasName("SeenBy");

                entity.Property(e => e.MessageId).HasColumnType("int(11)");

                entity.Property(e => e.SeenBy)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasComment("BBS users");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LastLoginDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.LastLoginFrom)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasDefaultValueSql("'0.0.0.0'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nation)
                    .IsRequired()
                    .HasColumnName("nation")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''")
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
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Registered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'current_timestamp()'");

                entity.Property(e => e.Signature)
                    .IsRequired()
                    .HasColumnName("signature")
                    .HasColumnType("text")
                    .HasDefaultValueSql("''")
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
                    .HasName("group_groups");

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
                    .HasConstraintName("group_groups");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersGroupsLinks)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("user_users");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
