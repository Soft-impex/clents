﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel;

#nullable disable

namespace Clients.DataContext
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
        public virtual DbSet<ViewOrgsummary> ViewOrgsummaries { get; set; }

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
                    .HasConstraintName("Contacts_idOrg_fkey");
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

                entity.Property(e => e.LicenseeLdidOrg).HasColumnName("LicenseeLDIdOrg");

                entity.HasOne(d => d.LicenseeLdidOrgNavigation)
                    .WithMany(p => p.InverseLicenseeLdidOrgNavigation)
                    .HasForeignKey(d => d.LicenseeLdidOrg)
                    .HasConstraintName("Organizations_LicenseeLDIdOrg_fkey");
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
                    .HasConstraintName("TarifsED_idOrg_fkey");
            });

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

            modelBuilder.Entity<ViewOrgsummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("view_orgsummary");

                entity.Property(e => e.ContractED).HasColumnName("contracted");

                entity.Property(e => e.ContractLd).HasColumnName("contractld");

                entity.Property(e => e.DateEd)
                    .HasColumnType("date")
                    .HasColumnName("dateed");

                entity.Property(e => e.DateLd)
                    .HasColumnType("date")
                    .HasColumnName("dateld");

                entity.Property(e => e.LicenseeOrgAlias)
                    .HasColumnName("licenseeorgalias");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Sqlguid).HasColumnName("SQLGuid");
            });

            modelBuilder.HasSequence<int>("ContractEDInfodec").StartsAt(589).IncrementsBy(1);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public enum NextContractType
        {
            [Description("ContractEDInfodec_seq")]EDInfodec, [Description("ContractEDNts_seq")]EDNts, [Description("ContractLD_seq")]LDCtm
        }
        public string GetNextContracts(NextContractType type)
        {
            using (var cmd = Database.GetDbConnection().CreateCommand())
                try
                {
                    cmd.Connection.Open();
                    switch (type)
                    {
                        case NextContractType.EDInfodec:
                            cmd.CommandText = $"SELECT NEXTVAL('ContractEDInfodec_seq')";
                            return "ЭД" + Convert.ToInt32(cmd.ExecuteScalar()) + "/" + DateTime.Now.ToString("yyMM");
                            break;
                        case NextContractType.EDNts:
                            cmd.CommandText = $"SELECT NEXTVAL('ContractEDInfodec_seq')";
                            return "ЭДН" + Convert.ToInt32(cmd.ExecuteScalar()) + "/" + DateTime.Now.ToString("yyMM");
                            break;
                        case NextContractType.LDCtm:
                            cmd.CommandText = $"SELECT NEXTVAL('ContractLD_seq')";
                            return "ЛД" + Convert.ToInt32(cmd.ExecuteScalar()) + "/" + DateTime.Now.ToString("yyMM");
                            break;
                        default:
                            return null;
                            break;
                    }
                }
                catch(SystemException ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                    return null;
                }
        }
    }
}
