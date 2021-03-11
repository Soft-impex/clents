using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
#nullable disable

namespace SynchDB.MSQL
{
    public partial class clients_siContext : DbContext
    {
        public clients_siContext()
        {
        }

        public clients_siContext(DbContextOptions<clients_siContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContractList> ContractLists { get; set; }
        public virtual DbSet<DogovorCtm> DogovorCtms { get; set; }
        public virtual DbSet<DogovorEd> DogovorEds { get; set; }
        public virtual DbSet<DogovorLd> DogovorLds { get; set; }
        public virtual DbSet<Ecp> Ecps { get; set; }
        public virtual DbSet<EcpControl> EcpControls { get; set; }
        public virtual DbSet<EcpNew> EcpNews { get; set; }
        public virtual DbSet<EcpTemp> EcpTemps { get; set; }
        public virtual DbSet<EcpVladelec> EcpVladelecs { get; set; }
        public virtual DbSet<EcpWork> EcpWorks { get; set; }
        public virtual DbSet<Fpsu> Fpsus { get; set; }
        public virtual DbSet<IdGnivc> IdGnivcs { get; set; }
        public virtual DbSet<IdT> IdTs { get; set; }
        public virtual DbSet<InfOperator> InfOperators { get; set; }
        public virtual DbSet<InfOperatorService> InfOperatorServices { get; set; }
        public virtual DbSet<InfOperatorsList> InfOperatorsLists { get; set; }
        public virtual DbSet<KktCash> KktCashes { get; set; }
        public virtual DbSet<KktFiscal> KktFiscals { get; set; }
        public virtual DbSet<KktHistory> KktHistories { get; set; }
        public virtual DbSet<KktHistoryAction> KktHistoryActions { get; set; }
        public virtual DbSet<KktLk> KktLks { get; set; }
        public virtual DbSet<KktOfd> KktOfds { get; set; }
        public virtual DbSet<KktRepair> KktRepairs { get; set; }
        public virtual DbSet<KktReport> KktReports { get; set; }
        public virtual DbSet<KktService> KktServices { get; set; }
        public virtual DbSet<LoginEcpControl> LoginEcpControls { get; set; }
        public virtual DbSet<LoginsAdmin> LoginsAdmins { get; set; }
        public virtual DbSet<ManualFiscal> ManualFiscals { get; set; }
        public virtual DbSet<ManualKktname> ManualKktnames { get; set; }
        public virtual DbSet<ManualOfd> ManualOfds { get; set; }
        public virtual DbSet<ManualOfdtarif> ManualOfdtarifs { get; set; }
        public virtual DbSet<ManualScopeEcp> ManualScopeEcps { get; set; }
        public virtual DbSet<ManualUc> ManualUcs { get; set; }
        public virtual DbSet<ManualWorker> ManualWorkers { get; set; }
        public virtual DbSet<OnlineCashCheque> OnlineCashCheques { get; set; }
        public virtual DbSet<OnlineCashGood> OnlineCashGoods { get; set; }
        public virtual DbSet<OnlineCashReport> OnlineCashReports { get; set; }
        public virtual DbSet<OrgNote> OrgNotes { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<RateList> RateLists { get; set; }
        public virtual DbSet<RemoteControl> RemoteControls { get; set; }
        public virtual DbSet<SelectOrgTask> SelectOrgTasks { get; set; }
        public virtual DbSet<SelectOrgTmp> SelectOrgTmps { get; set; }
        public virtual DbSet<Ssl> Ssls { get; set; }
        public virtual DbSet<SslBlock> SslBlocks { get; set; }
        public virtual DbSet<SslMegr> SslMegrs { get; set; }
        public virtual DbSet<SslNew> SslNews { get; set; }
        public virtual DbSet<SslcontrolAlert> SslcontrolAlerts { get; set; }
        public virtual DbSet<StUser> StUsers { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Tr1> Tr1s { get; set; }
        public virtual DbSet<TriggerOrderPaymentTable> TriggerOrderPaymentTables { get; set; }
        public virtual DbSet<Uk> Uks { get; set; }
        public virtual DbSet<WorksClient> WorksClients { get; set; }
        public virtual DbSet<ZayavkaNew> ZayavkaNews { get; set; }
        public virtual DbSet<ZayavkaPerechen> ZayavkaPerechens { get; set; }
        public virtual DbSet<ZayavkaUC> ZayavkaUCs { get; set; }
        public virtual DbSet<ZayavkaUCAlert> ZayavkaUCAlerts { get; set; }
        public virtual DbSet<ZayavkarUcBin> ZayavkarUcBins { get; set; }


        public virtual DbSet<ViewLicenseeLDRelation> ViewLicenseeLDRelation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.172.172.120;Database=clients_si;User Id=anik;Password=312301001;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contacts");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Fio)
                    .IsUnicode(false)
                    .HasColumnName("fio");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Mail)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Phone1)
                    .IsUnicode(false)
                    .HasColumnName("phone1");

                entity.Property(e => e.Phone2)
                    .IsUnicode(false)
                    .HasColumnName("phone2");

                entity.Property(e => e.Post)
                    .IsUnicode(false)
                    .HasColumnName("post");

                entity.Property(e => e.Predstavitel).HasColumnName("predstavitel");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<ContractList>(entity =>
            {
                entity.ToTable("ContractList");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("idOrg");

                entity.Property(e => e.Num)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DogovorCtm>(entity =>
            {
                entity.ToTable("Dogovor_CTM");

                entity.HasIndex(e => e.IdOrg, "IX_idOrg")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idOrg");

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INN");

                entity.Property(e => e.OrgName).IsUnicode(false);

                entity.Property(e => e.RailYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeProgram)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VedYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DogovorEd>(entity =>
            {
                entity.ToTable("dogovor_ED");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateGenerate)
                    .HasColumnType("datetime")
                    .HasColumnName("dateGenerate");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.NumPril)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("numPril");

                entity.Property(e => e.Theme)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("theme");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("year");
            });

            modelBuilder.Entity<DogovorLd>(entity =>
            {
                entity.ToTable("dogovor_ld");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Num)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("num");

                entity.Property(e => e.NumPril).HasColumnName("num_pril");

                entity.Property(e => e.Theme)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("theme");

                entity.Property(e => e.TypeDoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type_doc");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<Ecp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ecp");

                entity.Property(e => e.ChSrok).HasColumnName("ch_srok");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Nositel)
                    .IsUnicode(false)
                    .HasColumnName("nositel");

                entity.Property(e => e.Note1)
                    .IsUnicode(false)
                    .HasColumnName("note1");

                entity.Property(e => e.Note2)
                    .IsUnicode(false)
                    .HasColumnName("note2");

                entity.Property(e => e.Num)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("num");

                entity.Property(e => e.NumSer)
                    .IsUnicode(false)
                    .HasColumnName("num_ser");

                entity.Property(e => e.Pass)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.Poluchena)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("poluchena");

                entity.Property(e => e.Srok)
                    .HasColumnType("datetime")
                    .HasColumnName("srok");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UserEcp)
                    .IsUnicode(false)
                    .HasColumnName("user_ecp");

                entity.Property(e => e.ZayavkaNum)
                    .IsUnicode(false)
                    .HasColumnName("zayavka_num");
            });

            modelBuilder.Entity<EcpControl>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EcpControl");

                entity.Property(e => e.Day).HasColumnName("day");

                entity.Property(e => e.Fio)
                    .IsUnicode(false)
                    .HasColumnName("FIO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdEcp).HasColumnName("idEcp");

                entity.Property(e => e.IdOrg).HasColumnName("idOrg");

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.OrgName)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("org_name");

                entity.Property(e => e.Phone1)
                    .IsUnicode(false)
                    .HasColumnName("phone1");

                entity.Property(e => e.Phone2)
                    .IsUnicode(false)
                    .HasColumnName("phone2");

                entity.Property(e => e.Srok)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("srok");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UserEcp)
                    .IsUnicode(false)
                    .HasColumnName("user_ecp");
            });

            modelBuilder.Entity<EcpNew>(entity =>
            {
                entity.ToTable("ecp_new");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Blok).HasColumnName("blok");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Nositel)
                    .IsUnicode(false)
                    .HasColumnName("nositel");

                entity.Property(e => e.Note1)
                    .IsUnicode(false)
                    .HasColumnName("note1");

                entity.Property(e => e.Note2)
                    .IsUnicode(false)
                    .HasColumnName("note2");

                entity.Property(e => e.Num)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("num");

                entity.Property(e => e.NumSer)
                    .IsUnicode(false)
                    .HasColumnName("num_ser");

                entity.Property(e => e.Pass)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.Srok)
                    .IsUnicode(false)
                    .HasColumnName("srok");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UserEcp)
                    .IsUnicode(false)
                    .HasColumnName("user_ecp");
            });

            modelBuilder.Entity<EcpTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ecp_temp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Nositel)
                    .IsUnicode(false)
                    .HasColumnName("nositel");

                entity.Property(e => e.Note1)
                    .IsUnicode(false)
                    .HasColumnName("note1");

                entity.Property(e => e.Num)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("num");

                entity.Property(e => e.UserEcp)
                    .IsUnicode(false)
                    .HasColumnName("user_ecp");
            });

            modelBuilder.Entity<EcpVladelec>(entity =>
            {
                entity.ToTable("ecp_vladelec");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("fio");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Mail)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Phone)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Post)
                    .IsUnicode(false)
                    .HasColumnName("post");
            });

            modelBuilder.Entity<EcpWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EcpWork");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdEcp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idEcp");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fpsu>(entity =>
            {
                entity.ToTable("fpsu");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Adres)
                    .IsUnicode(false)
                    .HasColumnName("adres");

                entity.Property(e => e.Host)
                    .IsUnicode(false)
                    .HasColumnName("host");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.NastrDate)
                    .IsUnicode(false)
                    .HasColumnName("nastr_date");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Note1)
                    .IsUnicode(false)
                    .HasColumnName("note1");

                entity.Property(e => e.Performed)
                    .IsUnicode(false)
                    .HasColumnName("performed");

                entity.Property(e => e.Pin1)
                    .IsUnicode(false)
                    .HasColumnName("pin1");

                entity.Property(e => e.Pin2)
                    .IsUnicode(false)
                    .HasColumnName("pin2");

                entity.Property(e => e.Puk1)
                    .IsUnicode(false)
                    .HasColumnName("puk1");

                entity.Property(e => e.Puk2)
                    .IsUnicode(false)
                    .HasColumnName("puk2");

                entity.Property(e => e.RegNum)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("reg_num");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasColumnName("status");

                entity.Property(e => e.UserDec)
                    .IsUnicode(false)
                    .HasColumnName("user_dec");
            });

            modelBuilder.Entity<IdGnivc>(entity =>
            {
                entity.ToTable("id_gnivc");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AdressOtprav)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("adress_otprav");

                entity.Property(e => e.IdDecl)
                    .IsUnicode(false)
                    .HasColumnName("id_decl");

                entity.Property(e => e.IdOrg)
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Operator)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("operator");

                entity.Property(e => e.Pass)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<IdT>(entity =>
            {
                entity.ToTable("id_t");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Data)
                    .IsUnicode(false)
                    .HasColumnName("data");

                entity.Property(e => e.IdDec)
                    .IsUnicode(false)
                    .HasColumnName("id_dec");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.MailCustoms)
                    .IsUnicode(false)
                    .HasColumnName("mail_customs");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Pass)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.UserDec)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("user_dec");
            });

            modelBuilder.Entity<InfOperator>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("inf_operator");

                entity.Property(e => e.Dolgnost)
                    .IsUnicode(false)
                    .HasColumnName("dolgnost");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("fio");

                entity.Property(e => e.Foto)
                    .HasColumnType("image")
                    .HasColumnName("foto");

                entity.Property(e => e.Icq)
                    .IsUnicode(false)
                    .HasColumnName("icq");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdOperator)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_operator");

                entity.Property(e => e.Mail)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Otvetstvennost)
                    .IsUnicode(false)
                    .HasColumnName("otvetstvennost");

                entity.Property(e => e.PhoneMobil1)
                    .IsUnicode(false)
                    .HasColumnName("phone_mobil1");

                entity.Property(e => e.PhoneMobil2)
                    .IsUnicode(false)
                    .HasColumnName("phone_mobil2");

                entity.Property(e => e.PhoneWork1)
                    .IsUnicode(false)
                    .HasColumnName("phone_work1");

                entity.Property(e => e.PhoneWork2)
                    .IsUnicode(false)
                    .HasColumnName("phone_work2");

                entity.Property(e => e.Sip)
                    .IsUnicode(false)
                    .HasColumnName("sip");

                entity.Property(e => e.Skype)
                    .IsUnicode(false)
                    .HasColumnName("skype");
            });

            modelBuilder.Entity<InfOperatorService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("inf_operator_service");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdOperator)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_operator");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.Path)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("path");

                entity.Property(e => e.TypePay)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InfOperatorsList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("inf_operators_list");

                entity.Property(e => e.DogovorPony)
                    .IsUnicode(false)
                    .HasColumnName("dogovor_PONY");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MethodDostavki)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("method_dostavki");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.PostAdres)
                    .IsUnicode(false)
                    .HasColumnName("post_adres");
            });

            modelBuilder.Entity<KktCash>(entity =>
            {
                entity.ToTable("kkt_Cash");

                entity.HasIndex(e => e.IdOrg, "IX_kkt_Cash");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateShop).HasColumnType("date");

                entity.Property(e => e.Ffd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FFD");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idOrg");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Nds20)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NDS20");

                entity.Property(e => e.Place).IsUnicode(false);

                entity.Property(e => e.PlaceShop).IsUnicode(false);

                entity.Property(e => e.Rnm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RNM");

                entity.Property(e => e.ServiceTarif)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Zn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ZN");
            });

            modelBuilder.Entity<KktFiscal>(entity =>
            {
                entity.ToTable("kkt_fiscal");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateBy).HasColumnType("date");

                entity.Property(e => e.DateRegistration).HasColumnType("date");

                entity.Property(e => e.IdCash)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idCash");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idOrg");

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.Num)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KktHistory>(entity =>
            {
                entity.ToTable("kkt_history");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateChange).HasColumnType("datetime");

                entity.Property(e => e.IdCash)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idCash");

                entity.Property(e => e.IdOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idOrg");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KktHistoryAction>(entity =>
            {
                entity.ToTable("kkt_history_actions");

                entity.HasIndex(e => e.IdHistory, "IX_kkt_history_actions");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Action)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdHistory)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idHistory");

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KktLk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("kkt_LK");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCash)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idCash");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idOrg");

                entity.Property(e => e.Lkecp).HasColumnName("LKEcp");

                entity.Property(e => e.Lkhttp)
                    .IsUnicode(false)
                    .HasColumnName("LKHttp");

                entity.Property(e => e.Lklogin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LKLogin");

                entity.Property(e => e.Lkpass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LKPass");

                entity.Property(e => e.Lktype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LKType");

                entity.Property(e => e.Note).HasColumnType("text");
            });

            modelBuilder.Entity<KktOfd>(entity =>
            {
                entity.ToTable("kkt_ofd");

                entity.HasIndex(e => e.IdCash, "IX_kkt_ofd");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateActivate).HasColumnType("date");

                entity.Property(e => e.DateBy).HasColumnType("date");

                entity.Property(e => e.IdCash)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idCash");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idOrg");

                entity.Property(e => e.Operator)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tarif)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KktRepair>(entity =>
            {
                entity.ToTable("kkt_repair");

                entity.HasIndex(e => e.IdCash, "IX_kkt_repair");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IdCash)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idCash");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idOrg");

                entity.Property(e => e.Note).HasColumnType("text");
            });

            modelBuilder.Entity<KktReport>(entity =>
            {
                entity.ToTable("kkt_Report");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdParent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idParent");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KktService>(entity =>
            {
                entity.ToTable("kkt_service");

                entity.HasIndex(e => e.IdCash, "IX_kkt_service");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IdCash)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idCash");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idOrg");

                entity.Property(e => e.Note).HasColumnType("text");
            });

            modelBuilder.Entity<LoginEcpControl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LoginEcpControl");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Ssl).HasColumnName("SSL");
            });

            modelBuilder.Entity<LoginsAdmin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("logins_admin");

                entity.Property(e => e.UserAdmin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_admin");
            });

            modelBuilder.Entity<ManualFiscal>(entity =>
            {
                entity.ToTable("ManualFiscal");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<ManualKktname>(entity =>
            {
                entity.ToTable("ManualKKTName");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<ManualOfd>(entity =>
            {
                entity.ToTable("ManualOFD");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<ManualOfdtarif>(entity =>
            {
                entity.ToTable("ManualOFDTarif");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<ManualScopeEcp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ManualScopeECP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManualUc>(entity =>
            {
                entity.ToTable("ManualUC");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<ManualWorker>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<OnlineCashCheque>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DatePrint).HasColumnType("date");

                entity.Property(e => e.IdCashReport)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idCashReport");

                entity.Property(e => e.IdOrder)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idOrder");
            });

            modelBuilder.Entity<OnlineCashGood>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.GoodName).HasColumnType("text");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCheque)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idCheque");

                entity.Property(e => e.Price).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Sum).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<OnlineCashReport>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.DateStop).HasColumnType("date");

                entity.Property(e => e.KassirFio)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KassirFIO");

                entity.Property(e => e.KassirInn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("KassirINN");

                entity.Property(e => e.SumAll).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<OrgNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("org_note");

                entity.Property(e => e.AdressFact)
                    .IsUnicode(false)
                    .HasColumnName("adress_fact");

                entity.Property(e => e.AdressFactIndex)
                    .IsUnicode(false)
                    .HasColumnName("adress_fact_index");

                entity.Property(e => e.AdressUrid)
                    .IsUnicode(false)
                    .HasColumnName("adress_urid");

                entity.Property(e => e.AdressUridIndex)
                    .IsUnicode(false)
                    .HasColumnName("adress_urid_index");

                entity.Property(e => e.Bank)
                    .IsUnicode(false)
                    .HasColumnName("bank");

                entity.Property(e => e.Bik)
                    .IsUnicode(false)
                    .HasColumnName("bik");

                entity.Property(e => e.CorrespondenceAdres)
                    .IsUnicode(false)
                    .HasColumnName("correspondence_adres");

                entity.Property(e => e.CorrespondenceMail)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("correspondence_mail");

                entity.Property(e => e.CorrespondenceType)
                    .IsUnicode(false)
                    .HasColumnName("correspondence_type");

                entity.Property(e => e.CryptoPro)
                    .IsUnicode(false)
                    .HasColumnName("crypto_pro");

                entity.Property(e => e.Director)
                    .IsUnicode(false)
                    .HasColumnName("director");

                entity.Property(e => e.Dolgnost)
                    .IsUnicode(false)
                    .HasColumnName("dolgnost");

                entity.Property(e => e.GuidOrg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("guid_org");

                entity.Property(e => e.Inn)
                    .IsUnicode(false)
                    .HasColumnName("inn");

                entity.Property(e => e.KolKanalov).HasColumnName("kol_kanalov");

                entity.Property(e => e.KorShet)
                    .IsUnicode(false)
                    .HasColumnName("kor_shet");

                entity.Property(e => e.Kpp)
                    .IsUnicode(false)
                    .HasColumnName("kpp");

                entity.Property(e => e.LegalForm)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("legal_form");

                entity.Property(e => e.Mail)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Ogrn)
                    .IsUnicode(false)
                    .HasColumnName("ogrn");

                entity.Property(e => e.OrgNameOriginal)
                    .IsUnicode(false)
                    .HasColumnName("org_name_original");

                entity.Property(e => e.Polnomochia)
                    .IsUnicode(false)
                    .HasColumnName("polnomochia");

                entity.Property(e => e.RShet)
                    .IsUnicode(false)
                    .HasColumnName("r_shet");

                entity.Property(e => e.StrahNum)
                    .IsUnicode(false)
                    .HasColumnName("strah_num");

                entity.Property(e => e.Tel)
                    .IsUnicode(false)
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("organizations");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Contract)
                    .IsUnicode(false)
                    .HasColumnName("contract");

                entity.Property(e => e.ContractLd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("contract_ld");

                entity.Property(e => e.Contractor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractorLd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContractorLD");

                entity.Property(e => e.CspLicensee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("csp_licensee");

                entity.Property(e => e.Date)
                    .IsUnicode(false)
                    .HasColumnName("date");

                entity.Property(e => e.DateLd)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("date_ld");

                entity.Property(e => e.Diadok).HasColumnName("diadok");

                entity.Property(e => e.LdBlock).HasColumnName("ld_block");

                entity.Property(e => e.LdBlockWho)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ld_block_who");

                entity.Property(e => e.LdOrgName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ld_org_name");

                entity.Property(e => e.Licensee)
                    .IsUnicode(false)
                    .HasColumnName("licensee");

                entity.Property(e => e.Operator)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("operator");

                entity.Property(e => e.OrgName)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("org_name");

                entity.Property(e => e.Rate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("rate");

                entity.Property(e => e.RespresentativeRegion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sbis).HasColumnName("sbis");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusWork).HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusWorkEd)
                    .HasColumnName("StatusWorkED")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusWorkLd)
                    .HasColumnName("StatusWorkLD")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type");

                entity.Property(e => e.UCList)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("U_C_list");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Adress).IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idOrg");

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<RateList>(entity =>
            {
                entity.ToTable("rate_list");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CurrentRate).HasColumnName("current_rate");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.IdOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.LetterFilename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("letter_filename");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<RemoteControl>(entity =>
            {
                entity.ToTable("RemoteControl");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ContactDolgnost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contactDolgnost");

                entity.Property(e => e.ContactFio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contactFIO");

                entity.Property(e => e.ContactMail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contactMail");

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contactPhone");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Tid)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tpass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SelectOrgTask>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SelectOrgTask");

                entity.Property(e => e.DateComplite).HasColumnType("datetime");

                entity.Property(e => e.StatusComplite)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SelectOrgTmp>(entity =>
            {
                entity.ToTable("SelectOrgTmp");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ConnectNotEmpty).HasColumnName("connect_not_empty");

                entity.Property(e => e.ContractEd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContractED");

                entity.Property(e => e.ContractLd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContractLD");

                entity.Property(e => e.ContractorEd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContractorED");

                entity.Property(e => e.ContractorLd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ContractorLD");

                entity.Property(e => e.CryptoZakaz).HasColumnName("crypto_zakaz");

                entity.Property(e => e.DateEd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DateED");

                entity.Property(e => e.DateLd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DateLD");

                entity.Property(e => e.EcpNotEmpty).HasColumnName("ecp_not_empty");

                entity.Property(e => e.Inn)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("INN");

                entity.Property(e => e.LdBlock).HasColumnName("ld_block");

                entity.Property(e => e.Licensee).IsUnicode(false);

                entity.Property(e => e.Operator).IsUnicode(false);

                entity.Property(e => e.OrgName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.OrgNameOriginal)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Rate).IsUnicode(false);

                entity.Property(e => e.RespresentativeRegion).IsUnicode(false);

                entity.Property(e => e.Sbis).HasColumnName("SBIS");

                entity.Property(e => e.SslBlockCount).HasColumnName("ssl_block_count");

                entity.Property(e => e.SslBlockNow).HasColumnName("ssl_block_now");

                entity.Property(e => e.StatusAllert).HasColumnName("status_allert");

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.UC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("U_C");

                entity.Property(e => e.UkCount).HasColumnName("uk_count");
            });

            modelBuilder.Entity<Ssl>(entity =>
            {
                entity.ToTable("ssl");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AdresOtprav)
                    .IsUnicode(false)
                    .HasColumnName("adres_otprav");

                entity.Property(e => e.IdDec)
                    .IsUnicode(false)
                    .HasColumnName("id_dec");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Pass)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.UserDec)
                    .IsUnicode(false)
                    .HasColumnName("user_dec");
            });

            modelBuilder.Entity<SslBlock>(entity =>
            {
                entity.ToTable("ssl_blocks");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateBlock)
                    .HasColumnType("datetime")
                    .HasColumnName("date_block");

                entity.Property(e => e.DateUnblick)
                    .HasColumnType("datetime")
                    .HasColumnName("date_unblick");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.IdSsl)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_ssl");

                entity.Property(e => e.SslName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ssl_name");
            });

            modelBuilder.Entity<SslMegr>(entity =>
            {
                entity.ToTable("ssl_megr");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateStart)
                    .HasColumnType("datetime")
                    .HasColumnName("date_start");

                entity.Property(e => e.DateStop)
                    .HasColumnType("datetime")
                    .HasColumnName("date_stop");

                entity.Property(e => e.Note)
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.Property(e => e.OrgNew)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("org_new");

                entity.Property(e => e.OrgOld)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("org_old");

                entity.Property(e => e.SslLoginId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ssl_login_id");
            });

            modelBuilder.Entity<SslNew>(entity =>
            {
                entity.ToTable("ssl_new");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AdressGnivc)
                    .IsUnicode(false)
                    .HasColumnName("adress_gnivc");

                entity.Property(e => e.DateGo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("date_go");

                entity.Property(e => e.IdDecl)
                    .IsUnicode(false)
                    .HasColumnName("id_decl");

                entity.Property(e => e.IdOrg)
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Pass)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.PassOld)
                    .IsUnicode(false)
                    .HasColumnName("pass_old");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SslcontrolAlert>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SSLControlAlert");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OrgName)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("org_name");
            });

            modelBuilder.Entity<StUser>(entity =>
            {
                entity.HasKey(e => e.LoginName);

                entity.ToTable("st_users");

                entity.Property(e => e.LoginName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("login_name");

                entity.Property(e => e.Dolgnost)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("dolgnost");

                entity.Property(e => e.FamilyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("family_name");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Policy)
                    .HasColumnType("xml")
                    .HasColumnName("policy");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tasks");

                entity.Property(e => e.Complite).HasColumnName("complite");

                entity.Property(e => e.DataNach)
                    .HasColumnType("datetime")
                    .HasColumnName("data_nach");

                entity.Property(e => e.DataZav)
                    .HasColumnType("datetime")
                    .HasColumnName("data_zav");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("login");

                entity.Property(e => e.Manager)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("manager");

                entity.Property(e => e.Napomin)
                    .HasColumnType("datetime")
                    .HasColumnName("napomin");

                entity.Property(e => e.NapominPeriod)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("napomin_period");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("note");

                entity.Property(e => e.Tema)
                    .HasColumnType("text")
                    .HasColumnName("tema");

                entity.Property(e => e.Vajn).HasColumnName("vajn");
            });

            modelBuilder.Entity<Tr1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tr1");

                entity.Property(e => e.T)
                    .HasColumnType("datetime")
                    .HasColumnName("t");
            });

            modelBuilder.Entity<TriggerOrderPaymentTable>(entity =>
            {
                entity.ToTable("TriggerOrderPaymentTable");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateOrder).HasColumnType("date");

                entity.Property(e => e.DatePaymet).HasColumnType("date");

                entity.Property(e => e.IdOrder).HasColumnName("idOrder");

                entity.Property(e => e.OrderNote).IsUnicode(false);

                entity.Property(e => e.Shet)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Uk>(entity =>
            {
                entity.ToTable("uk");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.PointIn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("point_in");

                entity.Property(e => e.User)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user");
            });

            modelBuilder.Entity<WorksClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("works_clients");

                entity.Property(e => e.ContactFio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("contact_fio");

                entity.Property(e => e.ContactMail)
                    .IsUnicode(false)
                    .HasColumnName("contact_mail");

                entity.Property(e => e.ContactPhone)
                    .IsUnicode(false)
                    .HasColumnName("contact_phone");

                entity.Property(e => e.DateStart)
                    .HasColumnType("datetime")
                    .HasColumnName("date_start");

                entity.Property(e => e.DateStop)
                    .HasColumnType("datetime")
                    .HasColumnName("date_stop");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.OrgName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("org_name");

                entity.Property(e => e.Shet)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("shet");

                entity.Property(e => e.Sotrudnik)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sotrudnik");
            });

            modelBuilder.Entity<ZayavkaNew>(entity =>
            {
                entity.ToTable("zayavka_new");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AktEd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("akt_ed");

                entity.Property(e => e.AktLd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("akt_ld");

                entity.Property(e => e.ChPoluchenFpsu).HasColumnName("ch_poluchen_fpsu");

                entity.Property(e => e.ChPoluchenId).HasColumnName("ch_poluchen_id");

                entity.Property(e => e.ChPoluchenSsl).HasColumnName("ch_poluchen_ssl");

                entity.Property(e => e.ChPoluchenoEcp).HasColumnName("ch_polucheno_ecp");

                entity.Property(e => e.Complite)
                    .IsUnicode(false)
                    .HasColumnName("complite");

                entity.Property(e => e.Contracter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Crypto)
                    .IsUnicode(false)
                    .HasColumnName("crypto");

                entity.Property(e => e.CryptoZakaz)
                    .IsUnicode(false)
                    .HasColumnName("crypto_zakaz");

                entity.Property(e => e.Cspchecked).HasColumnName("CSPChecked");

                entity.Property(e => e.Csplicensee)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CSPLicensee");

                entity.Property(e => e.Cspversion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CSPVersion");

                entity.Property(e => e.DataComplite)
                    .IsUnicode(false)
                    .HasColumnName("data_complite");

                entity.Property(e => e.Del)
                    .HasColumnName("del")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DocComplite).HasColumnName("doc_complite");

                entity.Property(e => e.DocumentsPeredanData)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("documents_peredan_data");

                entity.Property(e => e.DocumentsPeredanFio)
                    .IsUnicode(false)
                    .HasColumnName("documents_peredan_fio");

                entity.Property(e => e.DocumentsWorker)
                    .IsUnicode(false)
                    .HasColumnName("documents_worker");

                entity.Property(e => e.Ecpcount).HasColumnName("ECPCount");

                entity.Property(e => e.Ecpscope)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ECPScope");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Infodek)
                    .IsUnicode(false)
                    .HasColumnName("infodek");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.PoluchenFpsu)
                    .IsUnicode(false)
                    .HasColumnName("poluchen_fpsu");

                entity.Property(e => e.PoluchenId)
                    .IsUnicode(false)
                    .HasColumnName("poluchen_id");

                entity.Property(e => e.PoluchenSsl)
                    .IsUnicode(false)
                    .HasColumnName("poluchen_ssl");

                entity.Property(e => e.PoluchenoEcp)
                    .IsUnicode(false)
                    .HasColumnName("polucheno_ecp");

                entity.Property(e => e.Prinyal)
                    .IsUnicode(false)
                    .HasColumnName("prinyal");

                entity.Property(e => e.PrinyalData)
                    .IsUnicode(false)
                    .HasColumnName("prinyal_data");

                entity.Property(e => e.RateChange)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("rate_change");

                entity.Property(e => e.ShetEcp)
                    .IsUnicode(false)
                    .HasColumnName("shet_ecp");

                entity.Property(e => e.ShetEcpAkt)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("shet_ecp_akt");

                entity.Property(e => e.ShetEcpAktDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("shet_ecp_akt_date");

                entity.Property(e => e.ShetEcpNote)
                    .IsUnicode(false)
                    .HasColumnName("shet_ecp_note");

                entity.Property(e => e.ShetEcpOplata)
                    .IsUnicode(false)
                    .HasColumnName("shet_ecp_oplata");

                entity.Property(e => e.ShetEcpPrinyal)
                    .IsUnicode(false)
                    .HasColumnName("shet_ecp_prinyal");

                entity.Property(e => e.ShetEd)
                    .IsUnicode(false)
                    .HasColumnName("shet_ed");

                entity.Property(e => e.ShetEdNote)
                    .IsUnicode(false)
                    .HasColumnName("shet_ed_note");

                entity.Property(e => e.ShetEdOplata)
                    .IsUnicode(false)
                    .HasColumnName("shet_ed_oplata");

                entity.Property(e => e.ShetEdOtpravil)
                    .IsUnicode(false)
                    .HasColumnName("shet_ed_otpravil");

                entity.Property(e => e.ShetEdOtpravilMail)
                    .IsUnicode(false)
                    .HasColumnName("shet_ed_otpravil_mail");

                entity.Property(e => e.ShetEdPrinyal)
                    .IsUnicode(false)
                    .HasColumnName("shet_ed_prinyal");

                entity.Property(e => e.ShetLd)
                    .IsUnicode(false)
                    .HasColumnName("shet_ld");

                entity.Property(e => e.ShetLdNote)
                    .IsUnicode(false)
                    .HasColumnName("shet_ld_note");

                entity.Property(e => e.ShetLdOplata)
                    .IsUnicode(false)
                    .HasColumnName("shet_ld_oplata");

                entity.Property(e => e.ShetLdOtpravil)
                    .IsUnicode(false)
                    .HasColumnName("shet_ld_otpravil");

                entity.Property(e => e.ShetLdOtpravilMail)
                    .IsUnicode(false)
                    .HasColumnName("shet_ld_otpravil_mail");

                entity.Property(e => e.ShetLdPrinyal)
                    .IsUnicode(false)
                    .HasColumnName("shet_ld_prinyal");

                entity.Property(e => e.Sostav)
                    .IsUnicode(false)
                    .HasColumnName("sostav");

                entity.Property(e => e.SpeedZayavka).HasColumnName("speed_zayavka");

                entity.Property(e => e.Technology)
                    .IsUnicode(false)
                    .HasColumnName("technology");

                entity.Property(e => e.WebNum).HasColumnName("web_num");

                entity.Property(e => e.ZayavkaIn)
                    .IsUnicode(false)
                    .HasColumnName("zayavka_in");

                entity.Property(e => e.ZayavkaInOperator)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("zayavka_in_operator");

                entity.Property(e => e.ZayavkaInOperatorDate)
                    .HasColumnType("datetime")
                    .HasColumnName("zayavka_in_operator_date");
            });

            modelBuilder.Entity<ZayavkaPerechen>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zayavka_perechen");

                entity.Property(e => e.Adress)
                    .IsUnicode(false)
                    .HasColumnName("adress");

                entity.Property(e => e.DataComplite)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("data_complite");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("fio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdZayavki)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("id_zayavki")
                    .HasComment("Подразделение");

                entity.Property(e => e.Mail)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Nositel)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nositel");

                entity.Property(e => e.Phone)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Post)
                    .IsUnicode(false)
                    .HasColumnName("post")
                    .HasComment("Должность");

                entity.Property(e => e.Scope)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("scope");

                entity.Property(e => e.Snils)
                    .IsRequired()
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("snils");

                entity.Property(e => e.Unit)
                    .IsUnicode(false)
                    .HasColumnName("unit");

                entity.Property(e => e.UseEd).HasColumnName("use_ed");

                entity.Property(e => e.UsePi).HasColumnName("use_pi");

                entity.Property(e => e.UseSvx).HasColumnName("use_svx");

                entity.Property(e => e.Worker)
                    .IsUnicode(false)
                    .HasColumnName("worker");
            });

            modelBuilder.Entity<ZayavkaUC>(entity =>
            {
                entity.ToTable("zayavka_U_C");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Attn)
                    .HasColumnName("attn")
                    .HasComment("ВНИМАНИЕ!!");

                entity.Property(e => e.ChPPUC).HasColumnName("ch_p_p_U_C");

                entity.Property(e => e.ChShetUC).HasColumnName("ch_shet_U_C");

                entity.Property(e => e.FlagReportUCEdit).HasColumnName("flag_report_U_C_edit");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("id_org");

                entity.Property(e => e.Note)
                    .IsUnicode(false)
                    .HasColumnName("note");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.Num10Date)
                    .HasColumnType("datetime")
                    .HasColumnName("num10_date");

                entity.Property(e => e.Num10Note)
                    .IsUnicode(false)
                    .HasColumnName("num10_note");

                entity.Property(e => e.Num10Worker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("num10_worker");

                entity.Property(e => e.Num11Date)
                    .HasColumnType("datetime")
                    .HasColumnName("num11_date");

                entity.Property(e => e.Num11Note)
                    .IsUnicode(false)
                    .HasColumnName("num11_note");

                entity.Property(e => e.Num11Worker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("num11_worker");

                entity.Property(e => e.Num1Date)
                    .HasColumnType("datetime")
                    .HasColumnName("num1_date");

                entity.Property(e => e.Num1Note)
                    .IsUnicode(false)
                    .HasColumnName("num1_note");

                entity.Property(e => e.Num2Date)
                    .HasColumnType("datetime")
                    .HasColumnName("num2_date");

                entity.Property(e => e.Num2Fio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("num2_fio");

                entity.Property(e => e.Num2Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("num2_mail");

                entity.Property(e => e.Num2Note)
                    .IsUnicode(false)
                    .HasColumnName("num2_note");

                entity.Property(e => e.Num2Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("num2_phone");

                entity.Property(e => e.Num2Worker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("num2_worker");

                entity.Property(e => e.Num3Date)
                    .HasColumnType("datetime")
                    .HasColumnName("num3_date");

                entity.Property(e => e.Num3Note)
                    .IsUnicode(false)
                    .HasColumnName("num3_note");

                entity.Property(e => e.Num3Worker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("num3_worker");

                entity.Property(e => e.Num4Date)
                    .HasColumnType("datetime")
                    .HasColumnName("num4_date");

                entity.Property(e => e.Num4Note)
                    .IsUnicode(false)
                    .HasColumnName("num4_note");

                entity.Property(e => e.Num4Worker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("num4_worker");

                entity.Property(e => e.Num5Date)
                    .HasColumnType("datetime")
                    .HasColumnName("num5_date");

                entity.Property(e => e.Num5Note)
                    .IsUnicode(false)
                    .HasColumnName("num5_note");

                entity.Property(e => e.Num5Worker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("num5_worker");

                entity.Property(e => e.Num6Date)
                    .HasColumnType("datetime")
                    .HasColumnName("num6_date");

                entity.Property(e => e.Num6Fio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("num6_fio");

                entity.Property(e => e.Num6Mail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("num6_mail");

                entity.Property(e => e.Num6Note)
                    .IsUnicode(false)
                    .HasColumnName("num6_note");

                entity.Property(e => e.Num6Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("num6_phone");

                entity.Property(e => e.Num6Worker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("num6_worker");

                entity.Property(e => e.Num7Date)
                    .HasColumnType("datetime")
                    .HasColumnName("num7_date");

                entity.Property(e => e.Num7Note)
                    .IsUnicode(false)
                    .HasColumnName("num7_note");

                entity.Property(e => e.Num7Worker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("num7_worker");

                entity.Property(e => e.Num8Date)
                    .HasColumnType("datetime")
                    .HasColumnName("num8_date");

                entity.Property(e => e.Num8Note)
                    .IsUnicode(false)
                    .HasColumnName("num8_note");

                entity.Property(e => e.Num8Worker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("num8_worker");

                entity.Property(e => e.Num9Date)
                    .HasColumnType("datetime")
                    .HasColumnName("num9_date");

                entity.Property(e => e.Num9Note)
                    .IsUnicode(false)
                    .HasColumnName("num9_note");

                entity.Property(e => e.Num9Worker)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("num9_worker");

                entity.Property(e => e.NumGroup).HasColumnName("num_group");

                entity.Property(e => e.Operator)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("operator");

                entity.Property(e => e.Packege11Original).HasColumnName("packege1_1_original");

                entity.Property(e => e.Packege11Scan).HasColumnName("packege1_1_scan");

                entity.Property(e => e.Packege12Original).HasColumnName("packege1_2_original");

                entity.Property(e => e.Packege12Scan).HasColumnName("packege1_2_scan");

                entity.Property(e => e.Packege13Original).HasColumnName("packege1_3_original");

                entity.Property(e => e.Packege13Scan).HasColumnName("packege1_3_scan");

                entity.Property(e => e.Packege14Original).HasColumnName("packege1_4_original");

                entity.Property(e => e.Packege14Scan).HasColumnName("packege1_4_scan");

                entity.Property(e => e.Packege15Scan).HasColumnName("packege1_5_scan");

                entity.Property(e => e.Packege16Scan).HasColumnName("packege1_6_scan");

                entity.Property(e => e.Packege17Scan).HasColumnName("packege1_7_scan");

                entity.Property(e => e.Packege18Scan).HasColumnName("packege1_8_scan");

                entity.Property(e => e.Packege19Scan).HasColumnName("packege1_9_scan");

                entity.Property(e => e.Packege21Scan).HasColumnName("packege2_1_scan");

                entity.Property(e => e.Packege22Scan).HasColumnName("packege2_2_scan");

                entity.Property(e => e.Packege23Scan).HasColumnName("packege2_3_scan");

                entity.Property(e => e.Packege31).HasColumnName("packege3_1");

                entity.Property(e => e.Packege32).HasColumnName("packege3_2");

                entity.Property(e => e.Packege33).HasColumnName("packege3_3");

                entity.Property(e => e.Packege34).HasColumnName("packege3_4");

                entity.Property(e => e.ReportUC)
                    .HasColumnType("datetime")
                    .HasColumnName("report_U_C");

                entity.Property(e => e.RetransmissionDocuments)
                    .HasColumnType("datetime")
                    .HasColumnName("retransmission_documents");

                entity.Property(e => e.ShowHide).HasComment("1 - Отображается 0 - Скрыта");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasComment("Статус\r\n0 - скрыта\r\n1 - в работе");

                entity.Property(e => e.WarrantOfficer)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("warrant_officer");

                entity.Property(e => e.ZNewId)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("z_new_id");
            });

            modelBuilder.Entity<ZayavkaUCAlert>(entity =>
            {
                entity.ToTable("zayavka_U_C_alert");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DateShow)
                    .HasColumnType("datetime")
                    .HasColumnName("date_show");

                entity.Property(e => e.IdZayavkaNew)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("id_zayavka_new");

                entity.Property(e => e.IdZayavkaUC)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("id_zayavka_U_C");

                entity.Property(e => e.LoginAuth)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("login_auth");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.OrgName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("org_name");

                entity.Property(e => e.S)
                    .IsUnicode(false)
                    .HasColumnName("s");

                entity.Property(e => e.SAll)
                    .IsUnicode(false)
                    .HasColumnName("s_all");
            });

            modelBuilder.Entity<ZayavkarUcBin>(entity =>
            {
                entity.ToTable("ZayavkarUC_BIN");

                entity.HasIndex(e => e.IdOrder, "IX_ZayavkarUC_BIN_idZayavka");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdOrder)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idOrder");

                entity.Property(e => e.IdOrg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("idOrg");

                entity.Property(e => e.Note).HasColumnType("text");

                entity.Property(e => e.Step1Date)
                    .HasColumnType("date")
                    .HasColumnName("Step1_Date");

                entity.Property(e => e.Step1Worker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Step1_Worker");

                entity.Property(e => e.Step2ContactFio)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Step2_ContactFIO");

                entity.Property(e => e.Step2ContactMail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Step2_ContactMail");

                entity.Property(e => e.Step2ContactPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Step2_ContactPhone");

                entity.Property(e => e.Step2Date)
                    .HasColumnType("date")
                    .HasColumnName("Step2_Date");

                entity.Property(e => e.Step2Worker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Step2_Worker");

                entity.Property(e => e.Step3Date)
                    .HasColumnType("date")
                    .HasColumnName("Step3_Date");

                entity.Property(e => e.Step3DocDoverenost).HasColumnName("Step3_DocDoverenost");

                entity.Property(e => e.Step3DocDoverenostOriginal).HasColumnName("Step3_DocDoverenostOriginal");

                entity.Property(e => e.Step3DocInn).HasColumnName("Step3_DocINN");

                entity.Property(e => e.Step3DocInnoriginal).HasColumnName("Step3_DocINNOriginal");

                entity.Property(e => e.Step3DocOgrn).HasColumnName("Step3_DocOGRN");

                entity.Property(e => e.Step3DocOgrnoriginal).HasColumnName("Step3_DocOGRNOriginal");

                entity.Property(e => e.Step3DocOrderOriginal).HasColumnName("Step3_DocOrderOriginal");

                entity.Property(e => e.Step3DocPasport).HasColumnName("Step3_DocPasport");

                entity.Property(e => e.Step3DocPasportOriginal).HasColumnName("Step3_DocPasportOriginal");

                entity.Property(e => e.Step3DocPay).HasColumnName("Step3_DocPay");

                entity.Property(e => e.Step3DocPropiska).HasColumnName("Step3_DocPropiska");

                entity.Property(e => e.Step3DocPropiskaOriginal).HasColumnName("Step3_DocPropiskaOriginal");

                entity.Property(e => e.Step3DocSnils).HasColumnName("Step3_DocSnils");

                entity.Property(e => e.Step3DocSnilsOriginal).HasColumnName("Step3_DocSnilsOriginal");

                entity.Property(e => e.Step3DocZayavka).HasColumnName("Step3_DocZayavka");

                entity.Property(e => e.Step3Worker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Step3_Worker");

                entity.Property(e => e.Step4Date)
                    .HasColumnType("date")
                    .HasColumnName("Step4_Date");

                entity.Property(e => e.Step4Worker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Step4_Worker");

                entity.Property(e => e.Step5ContactFio)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Step5_ContactFIO");

                entity.Property(e => e.Step5ContactMail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Step5_ContactMail");

                entity.Property(e => e.Step5ContactPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Step5_ContactPhone");

                entity.Property(e => e.Step5Date)
                    .HasColumnType("date")
                    .HasColumnName("Step5_Date");

                entity.Property(e => e.Step5Worker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Step5_Worker");

                entity.Property(e => e.Step6Date)
                    .HasColumnType("date")
                    .HasColumnName("Step6_Date");

                entity.Property(e => e.Step6Worker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Step6_Worker");

                entity.Property(e => e.Step7Date)
                    .HasColumnType("date")
                    .HasColumnName("Step7_Date");

                entity.Property(e => e.Step7DocBinAct).HasColumnName("Step7_DocBinAct");

                entity.Property(e => e.Step7DocBinCer).HasColumnName("Step7_DocBinCer");

                entity.Property(e => e.Step7DocBinDogovor).HasColumnName("Step7_DocBinDogovor");

                entity.Property(e => e.Step7DocSiact).HasColumnName("Step7_DocSIAct");

                entity.Property(e => e.Step7DocSidogovor).HasColumnName("Step7_DocSIDogovor");

                entity.Property(e => e.Step7Worker)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Step7_Worker");
            });

            modelBuilder.Entity<ViewLicenseeLDRelation>(e => e.HasNoKey());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
