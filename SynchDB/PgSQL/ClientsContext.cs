using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SynchDB.PgSQL
{
    public partial class ClientsContext : DbContext
    {
        public ClientsContext()
        {
        }

        public ClientsContext(DbContextOptions<ClientsContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContractsEd> ContractsEds { get; set; }
        public virtual DbSet<ContractsLd> ContractsLds { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<TarifsEd> TarifsEds { get; set; }
        public virtual DbSet<ViewOrglist> ViewOrglists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=hyperserver;Port=5432;Database=Clients;Username=postgres;Password=312301001");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<ViewOrglist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("view_orglist");

                entity.Property(e => e.ConstractEd).HasColumnName("ConstractED");

                entity.Property(e => e.ContractLd).HasColumnName("ContractLD");

                entity.Property(e => e.DateEd)
                    .HasColumnType("date")
                    .HasColumnName("DateED");

                entity.Property(e => e.DateLd)
                    .HasColumnType("date")
                    .HasColumnName("DateLD");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Sqlguid).HasColumnName("SQLGuid");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Fio).HasColumnName("FIO");

                entity.Property(e => e.IdOrg).HasColumnName("idOrg");

                entity.Property(e => e.IsRepresentative)
                    .HasColumnName("isRepresentative")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sqlguid).HasColumnName("SQLGuid");

                entity.HasOne(d => d.IdOrgNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.IdOrg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrganizationId");
            });

            modelBuilder.Entity<ContractsEd>(entity =>
            {
                entity.ToTable("ContractsED");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IdOrg).HasColumnName("idOrg");

                entity.Property(e => e.Num).IsRequired();

                entity.HasOne(d => d.IdOrgNavigation)
                    .WithMany(p => p.ContractsEds)
                    .HasForeignKey(d => d.IdOrg)
                    .HasConstraintName("ContractsED_idOrg_fkey");
            });

            modelBuilder.Entity<ContractsLd>(entity =>
            {
                entity.ToTable("ContractsLD");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IdOrg).HasColumnName("idOrg");

                entity.Property(e => e.Num).IsRequired();

                entity.HasOne(d => d.IdOrgNavigation)
                    .WithMany(p => p.ContractsLds)
                    .HasForeignKey(d => d.IdOrg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ContractsLD_idOrg_fkey");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Alias).IsRequired();

                entity.Property(e => e.Inn).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.NameFull).IsRequired();

                entity.Property(e => e.Sqlguid).HasColumnName("SQLGuid");
            });

            modelBuilder.Entity<TarifsEd>(entity =>
            {
                entity.ToTable("TarifsED");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.DateApply).HasColumnType("date");

                entity.Property(e => e.IdOrg).HasColumnName("idOrg");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.IdOrgNavigation)
                    .WithMany(p => p.TarifsEds)
                    .HasForeignKey(d => d.IdOrg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("TarifsED_idOrg_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
