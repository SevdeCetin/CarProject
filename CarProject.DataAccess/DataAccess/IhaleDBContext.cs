using System;
using CarProject.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CarProject.DataAccess.DataAccess
{
    public partial class IhaleDBContext : DbContext
    {
        public IhaleDBContext()
        {
        }

        public IhaleDBContext(DbContextOptions<IhaleDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnahtarKelime> AnahtarKelimes { get; set; }
        public virtual DbSet<Arac> Aracs { get; set; }
        public virtual DbSet<AracOzellik> AracOzelliks { get; set; }
        public virtual DbSet<AracOzellikDetay> AracOzellikDetays { get; set; }
        public virtual DbSet<AracStatuDetay> AracStatuDetays { get; set; }
        public virtual DbSet<AracTramerBilgi> AracTramerBilgis { get; set; }
        public virtual DbSet<ChatBotDegerlendirme> ChatBotDegerlendirmes { get; set; }
        public virtual DbSet<Chatbot> Chatbots { get; set; }
        public virtual DbSet<Ekspertiz> Ekspertizs { get; set; }
        public virtual DbSet<FavoriArama> FavoriAramas { get; set; }
        public virtual DbSet<FavoriFiltrelemeDetay> FavoriFiltrelemeDetays { get; set; }
        public virtual DbSet<FavoriIlan> FavoriIlans { get; set; }
        public virtual DbSet<FirmaTur> FirmaTurs { get; set; }
        public virtual DbSet<Fotograf> Fotografs { get; set; }
        public virtual DbSet<Ihale> Ihales { get; set; }
        public virtual DbSet<IhaleDetay> IhaleDetays { get; set; }
        public virtual DbSet<IhaleFiyat> IhaleFiyats { get; set; }
        public virtual DbSet<IhaleStatuDetay> IhaleStatuDetays { get; set; }
        public virtual DbSet<IlanBilgileri> IlanBilgileris { get; set; }
        public virtual DbSet<Islem> Islems { get; set; }
        public virtual DbSet<Komisyon> Komisyons { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<KullaniciAracDetay> KullaniciAracDetays { get; set; }
        public virtual DbSet<KullaniciOzellik> KullaniciOzelliks { get; set; }
        public virtual DbSet<KullaniciOzellikDetay> KullaniciOzellikDetays { get; set; }
        public virtual DbSet<KullaniciPaket> KullaniciPakets { get; set; }
        public virtual DbSet<KullaniciRol> KullaniciRols { get; set; }
        public virtual DbSet<LogKayitlari> LogKayitlaris { get; set; }
        public virtual DbSet<Mesaj> Mesajs { get; set; }
        public virtual DbSet<MesajDetay> MesajDetays { get; set; }
        public virtual DbSet<Noter> Noters { get; set; }
        public virtual DbSet<Paket> Pakets { get; set; }
        public virtual DbSet<ParcaDurum> ParcaDurums { get; set; }
        public virtual DbSet<RolYetkiDetay> RolYetkiDetays { get; set; }
        public virtual DbSet<Sati> Satis { get; set; }
        public virtual DbSet<SayfaIzin> SayfaIzins { get; set; }
        public virtual DbSet<Sozlesme> Sozlesmes { get; set; }
        public virtual DbSet<Statu> Status { get; set; }
        public virtual DbSet<TramerParca> TramerParcas { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Yetki> Yetkis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=IhaleDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<AnahtarKelime>(entity =>
            {
                entity.ToTable("AnahtarKelime");

                entity.Property(e => e.AnahtarKelimeId).HasColumnName("AnahtarKelimeID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChatBotId).HasColumnName("ChatBotID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Kelime).HasMaxLength(15);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ChatBot)
                    .WithMany(p => p.AnahtarKelimes)
                    .HasForeignKey(d => d.ChatBotId)
                    .HasConstraintName("FK_AnahtarKelime_Chatbot");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AnahtarKelimeCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_AnahtarKelime_KullaniciCalisan");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AnahtarKelimeModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_AnahtarKelime_KullaniciCalisan1");
            });

            modelBuilder.Entity<Arac>(entity =>
            {
                entity.ToTable("Arac");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fiyat).HasColumnType("money");

                entity.Property(e => e.KmBilgisi).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AracOzellik>(entity =>
            {
                entity.ToTable("AracOzellik");

                entity.Property(e => e.AracOzellikId).HasColumnName("AracOzellikID");

                entity.Property(e => e.EnUstOzellikId).HasColumnName("EnUstOzellikID");

                entity.Property(e => e.OzellikAd).HasMaxLength(50);

                entity.Property(e => e.UstOzellikId).HasColumnName("UstOzellikID");
            });

            modelBuilder.Entity<AracOzellikDetay>(entity =>
            {
                entity.HasKey(e => e.AracOzellikDetay1);

                entity.ToTable("AracOzellikDetay");

                entity.Property(e => e.AracOzellikDetay1).HasColumnName("AracOzellikDetay");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.AracOzellikId).HasColumnName("AracOzellikID");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.AracOzellikDetays)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_AracOzellikDetay_Arac");

                entity.HasOne(d => d.AracOzellik)
                    .WithMany(p => p.AracOzellikDetays)
                    .HasForeignKey(d => d.AracOzellikId)
                    .HasConstraintName("FK_AracOzellikDetay_AracOzellik");
            });

            modelBuilder.Entity<AracStatuDetay>(entity =>
            {
                entity.ToTable("AracStatuDetay");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatuId).HasColumnName("StatuID");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.AracStatuDetays)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_AracStatuDetay_Arac");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AracStatuDetayCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_AracStatuDetay_KullaniciCalisan");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AracStatuDetayModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_AracStatuDetay_KullaniciCalisan1");

                entity.HasOne(d => d.Statu)
                    .WithMany(p => p.AracStatuDetays)
                    .HasForeignKey(d => d.StatuId)
                    .HasConstraintName("FK_AracStatuDetay_Statu");
            });

            modelBuilder.Entity<AracTramerBilgi>(entity =>
            {
                entity.ToTable("AracTramerBilgi");

                entity.Property(e => e.AracTramerBilgiId).HasColumnName("AracTramerBilgiID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParcaDurumId).HasColumnName("ParcaDurumID");

                entity.Property(e => e.TramerParcaId).HasColumnName("TramerParcaID");

                entity.Property(e => e.TramerTutari).HasColumnType("money");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.AracTramerBilgis)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_AracTramerBilgi_Arac");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.AracTramerBilgiCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_AracTramerBilgi_KullaniciCalisan");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.AracTramerBilgiModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_AracTramerBilgi_KullaniciCalisan1");

                entity.HasOne(d => d.ParcaDurum)
                    .WithMany(p => p.AracTramerBilgis)
                    .HasForeignKey(d => d.ParcaDurumId)
                    .HasConstraintName("FK_AracTramerBilgi_ParcaDurum");

                entity.HasOne(d => d.TramerParca)
                    .WithMany(p => p.AracTramerBilgis)
                    .HasForeignKey(d => d.TramerParcaId)
                    .HasConstraintName("FK_AracTramerBilgi_TramerParca");
            });

            modelBuilder.Entity<ChatBotDegerlendirme>(entity =>
            {
                entity.ToTable("ChatBotDegerlendirme");

                entity.Property(e => e.ChatBotDegerlendirmeId).HasColumnName("ChatBotDegerlendirmeID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.ChatBotId).HasColumnName("ChatBotID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ChatBot)
                    .WithMany(p => p.ChatBotDegerlendirmes)
                    .HasForeignKey(d => d.ChatBotId)
                    .HasConstraintName("FK_ChatBotDegerlendirme_Chatbot");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ChatBotDegerlendirmeCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_ChatBotDegerlendirme_KullaniciCalisan");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.ChatBotDegerlendirmeKullanicis)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_ChatBotDegerlendirme_Kullanici");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ChatBotDegerlendirmeModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ChatBotDegerlendirme_KullaniciCalisan1");
            });

            modelBuilder.Entity<Chatbot>(entity =>
            {
                entity.ToTable("Chatbot");

                entity.Property(e => e.ChatbotId).HasColumnName("ChatbotID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.Cevap).HasMaxLength(100);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Soru).HasMaxLength(100);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ChatbotCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Chatbot_KullaniciCalisan2");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ChatbotModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Chatbot_KullaniciCalisan3");
            });

            modelBuilder.Entity<Ekspertiz>(entity =>
            {
                entity.ToTable("Ekspertiz");

                entity.Property(e => e.EkspertizId).HasColumnName("EkspertizID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<FavoriArama>(entity =>
            {
                entity.ToTable("FavoriArama");

                entity.Property(e => e.FavoriAramaId).HasColumnName("FavoriAramaID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.FavoriAramas)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_FavoriArama_Kullanici");
            });

            modelBuilder.Entity<FavoriFiltrelemeDetay>(entity =>
            {
                entity.ToTable("FavoriFiltrelemeDetay");

                entity.Property(e => e.FavoriFiltrelemeDetayId).HasColumnName("FavoriFiltrelemeDetayID");

                entity.Property(e => e.AracOzellikId).HasColumnName("AracOzellikID");

                entity.Property(e => e.FavoriAramaId).HasColumnName("FavoriAramaID");

                entity.HasOne(d => d.AracOzellik)
                    .WithMany(p => p.FavoriFiltrelemeDetays)
                    .HasForeignKey(d => d.AracOzellikId)
                    .HasConstraintName("FK_FavoriFiltrelemeDetay_AracOzellik");

                entity.HasOne(d => d.FavoriArama)
                    .WithMany(p => p.FavoriFiltrelemeDetays)
                    .HasForeignKey(d => d.FavoriAramaId)
                    .HasConstraintName("FK_FavoriFiltrelemeDetay_FavoriArama");
            });

            modelBuilder.Entity<FavoriIlan>(entity =>
            {
                entity.ToTable("FavoriIlan");

                entity.Property(e => e.FavoriIlanId).HasColumnName("FavoriIlanID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.HasOne(d => d.Ilan)
                    .WithMany(p => p.FavoriIlans)
                    .HasForeignKey(d => d.IlanId)
                    .HasConstraintName("FK_FavoriList_ilanBilgileri");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.FavoriIlans)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_FavoriIlan_Kullanici");
            });

            modelBuilder.Entity<FirmaTur>(entity =>
            {
                entity.ToTable("FirmaTur");

                entity.Property(e => e.FirmaTurId).HasColumnName("FirmaTurID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FirmaTuru).HasMaxLength(30);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FirmaTurCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_FirmaBilgi_KullaniciCalisan");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.FirmaTurModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_FirmaBilgi_KullaniciCalisan1");
            });

            modelBuilder.Entity<Fotograf>(entity =>
            {
                entity.ToTable("Fotograf");

                entity.Property(e => e.FotografId).HasColumnName("FotografID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fotograf1).HasColumnName("Fotograf");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.Fotografs)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_Fotograf_Arac");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FotografCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Fotograf_KullaniciCalisan");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.FotografModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Fotograf_KullaniciCalisan1");
            });

            modelBuilder.Entity<Ihale>(entity =>
            {
                entity.ToTable("Ihale");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IhaleAdi)
                    .HasMaxLength(50)
                    .HasColumnName("ihaleAdi");

                entity.Property(e => e.IhaleBasTarih)
                    .HasColumnType("date")
                    .HasColumnName("ihaleBasTarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IhaleBitisTarih)
                    .HasColumnType("date")
                    .HasColumnName("ihaleBitisTarih")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.IhaleCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Ihale_KullaniciCalisan");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.IhaleKullanicis)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_Ihale_Kullanici");
            });

            modelBuilder.Entity<IhaleDetay>(entity =>
            {
                entity.ToTable("IhaleDetay");

                entity.Property(e => e.IhaleDetayId).HasColumnName("IhaleDetayID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.IhaleDetays)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_IhaleDetay_Arac");

                entity.HasOne(d => d.Ihale)
                    .WithMany(p => p.IhaleDetays)
                    .HasForeignKey(d => d.IhaleId)
                    .HasConstraintName("FK_IhaleDetay_Ihale");
            });

            modelBuilder.Entity<IhaleFiyat>(entity =>
            {
                entity.ToTable("IhaleFiyat");

                entity.Property(e => e.IhaleFiyatId).HasColumnName("IhaleFiyatID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.BaslangicFiyat).HasColumnType("money");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MinAlimFiyat).HasColumnType("money");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.IhaleFiyats)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_IhaleFiyat_Arac");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.IhaleFiyatCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_IhaleFiyat_KullaniciCalisan");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.IhaleFiyatModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_IhaleFiyat_KullaniciCalisan1");
            });

            modelBuilder.Entity<IhaleStatuDetay>(entity =>
            {
                entity.ToTable("IhaleStatuDetay");

                entity.Property(e => e.IhaleStatuDetayId).HasColumnName("IhaleStatuDetayID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IhaleId).HasColumnName("IhaleID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatuId).HasColumnName("StatuID");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.IhaleStatuDetayCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_IhaleDetay_KullaniciCalisan");

                entity.HasOne(d => d.Ihale)
                    .WithMany(p => p.IhaleStatuDetays)
                    .HasForeignKey(d => d.IhaleId)
                    .HasConstraintName("FK_IhaleDetay_Ihale1");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.IhaleStatuDetayModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_IhaleDetay_KullaniciCalisan1");

                entity.HasOne(d => d.Statu)
                    .WithMany(p => p.IhaleStatuDetays)
                    .HasForeignKey(d => d.StatuId)
                    .HasConstraintName("FK_IhaleStatuDetay_Statu");
            });

            modelBuilder.Entity<IlanBilgileri>(entity =>
            {
                entity.ToTable("ilanBilgileri");

                entity.Property(e => e.IlanBilgileriId).HasColumnName("ilanBilgileriID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IlanBasligi).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Arac)
                    .WithMany(p => p.IlanBilgileris)
                    .HasForeignKey(d => d.AracId)
                    .HasConstraintName("FK_ilanBilgileri_Arac");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.IlanBilgileriCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_ilanBilgileri_KullaniciCalisan");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.IlanBilgileriModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ilanBilgileri_KullaniciCalisan1");
            });

            modelBuilder.Entity<Islem>(entity =>
            {
                entity.ToTable("Islem");

                entity.Property(e => e.IslemId).HasColumnName("IslemID");

                entity.Property(e => e.IslemTuru).HasMaxLength(50);
            });

            modelBuilder.Entity<Komisyon>(entity =>
            {
                entity.ToTable("Komisyon");

                entity.Property(e => e.KomisyonId).HasColumnName("KomisyonID");

                entity.Property(e => e.BaslangicTarih).HasColumnType("date");

                entity.Property(e => e.BitisTarih).HasColumnType("date");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KomisyonTutar).HasColumnType("money");

                entity.Property(e => e.MaxTutar).HasColumnType("money");

                entity.Property(e => e.MinTutar).HasColumnType("money");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.KomisyonCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_KomisyonFiyatAralik_KullaniciCalisan");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.KomisyonModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_KomisyonFiyatAralik_KullaniciCalisan1");
            });

            modelBuilder.Entity<Kullanici>(entity =>
            {
                entity.ToTable("Kullanici");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KullaniciAdi).HasMaxLength(50);

                entity.Property(e => e.KullaniciRolId).HasColumnName("KullaniciRolID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PasswordHash).IsUnicode(false);

                entity.Property(e => e.PasswordSalt).IsUnicode(false);

                entity.Property(e => e.Soyad).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InverseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_KullaniciCalisan_KullaniciCalisan");

                entity.HasOne(d => d.KullaniciRol)
                    .WithMany(p => p.Kullanicis)
                    .HasForeignKey(d => d.KullaniciRolId)
                    .HasConstraintName("FK_Kullanici_KullaniciRol");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InverseModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_KullaniciCalisan_KullaniciCalisan1");
            });

            modelBuilder.Entity<KullaniciAracDetay>(entity =>
            {
                entity.ToTable("KullaniciAracDetay");

                entity.Property(e => e.KullaniciAracDetayId).HasColumnName("KullaniciAracDetayID");

                entity.Property(e => e.AracId).HasColumnName("AracID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.KullaniciAracDetayCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_MusteriDetay_KullaniciCalisan");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.KullaniciAracDetayKullanicis)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_KullaniciDetay_Kullanici");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.KullaniciAracDetayModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_MusteriDetay_KullaniciCalisan1");
            });

            modelBuilder.Entity<KullaniciOzellik>(entity =>
            {
                entity.ToTable("KullaniciOzellik");

                entity.Property(e => e.KullaniciOzellikId).HasColumnName("KullaniciOzellikID");

                entity.Property(e => e.KullaniciOzellikAd).HasMaxLength(50);
            });

            modelBuilder.Entity<KullaniciOzellikDetay>(entity =>
            {
                entity.ToTable("KullaniciOzellikDetay");

                entity.Property(e => e.KullaniciOzellikDetayId).HasColumnName("KullaniciOzellikDetayID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.KullaniciOzellikId).HasColumnName("KullaniciOzellikID");

                entity.Property(e => e.Ozellik).HasMaxLength(50);

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.KullaniciOzellikDetays)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_KullaniciOzellikDetay_Kullanici");

                entity.HasOne(d => d.KullaniciOzellik)
                    .WithMany(p => p.KullaniciOzellikDetays)
                    .HasForeignKey(d => d.KullaniciOzellikId)
                    .HasConstraintName("FK_KullaniciOzellikDetay_KullaniciOzellik");
            });

            modelBuilder.Entity<KullaniciPaket>(entity =>
            {
                entity.ToTable("KullaniciPaket");

                entity.Property(e => e.KullaniciPaketId).HasColumnName("KullaniciPaketID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.PaketId).HasColumnName("PaketID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.KullaniciPakets)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_KullaniciPaket_Kullanici");

                entity.HasOne(d => d.Paket)
                    .WithMany(p => p.KullaniciPakets)
                    .HasForeignKey(d => d.PaketId)
                    .HasConstraintName("FK_KullaniciPaket_Paket");
            });

            modelBuilder.Entity<KullaniciRol>(entity =>
            {
                entity.ToTable("KullaniciRol");

                entity.Property(e => e.KullaniciRolId).HasColumnName("KullaniciRolID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.Rol).HasMaxLength(50);
            });

            modelBuilder.Entity<LogKayitlari>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("LogKayitlari");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.IslemEtkisi).HasMaxLength(50);

                entity.Property(e => e.IslemId).HasColumnName("IslemID");

                entity.Property(e => e.IslemTarihi).HasColumnType("datetime");

                entity.Property(e => e.Macadres).HasColumnName("MACAdres");

                entity.Property(e => e.TabloAdi).HasMaxLength(50);

                entity.Property(e => e.TabloId).HasColumnName("TabloID");

                entity.HasOne(d => d.Islem)
                    .WithMany(p => p.LogKayitlaris)
                    .HasForeignKey(d => d.IslemId)
                    .HasConstraintName("FK_LogKayitlari_Islem");
            });

            modelBuilder.Entity<Mesaj>(entity =>
            {
                entity.ToTable("Mesaj");

                entity.Property(e => e.MesajId).HasColumnName("MesajID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icerik).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MesajCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Mesaj_KullaniciCalisan");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.MesajModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Mesaj_KullaniciCalisan1");
            });

            modelBuilder.Entity<MesajDetay>(entity =>
            {
                entity.ToTable("MesajDetay");

                entity.Property(e => e.MesajDetayId)
                    .ValueGeneratedNever()
                    .HasColumnName("MesajDetayID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.MesajId).HasColumnName("MesajID");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.MesajDetays)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_MesajDetay_Kullanici");

                entity.HasOne(d => d.Mesaj)
                    .WithMany(p => p.MesajDetays)
                    .HasForeignKey(d => d.MesajId)
                    .HasConstraintName("FK_MesajDetay_Mesaj");
            });

            modelBuilder.Entity<Noter>(entity =>
            {
                entity.ToTable("Noter");

                entity.Property(e => e.NoterId).HasColumnName("NoterID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.BaslangicTarih).HasColumnType("date");

                entity.Property(e => e.BitisTarih).HasColumnType("date");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NoterTutari).HasColumnType("money");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.NoterCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Noter_KullaniciCalisan");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.NoterModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Noter_KullaniciCalisan1");
            });

            modelBuilder.Entity<Paket>(entity =>
            {
                entity.ToTable("Paket");

                entity.Property(e => e.PaketId).HasColumnName("PaketID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.PaketAdi).HasMaxLength(20);
            });

            modelBuilder.Entity<ParcaDurum>(entity =>
            {
                entity.ToTable("ParcaDurum");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParcaDurum1)
                    .HasMaxLength(40)
                    .HasColumnName("ParcaDurum");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ParcaDurumCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_ParcaDurum_KullaniciCalisan");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ParcaDurumModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_ParcaDurum_KullaniciCalisan1");
            });

            modelBuilder.Entity<RolYetkiDetay>(entity =>
            {
                entity.ToTable("RolYetkiDetay");

                entity.Property(e => e.RolYetkiDetayId).HasColumnName("RolYetkiDetayID");

                entity.Property(e => e.KullaniciRolId).HasColumnName("KullaniciRolID");

                entity.Property(e => e.SayfaIzinId).HasColumnName("SayfaIzinID");

                entity.Property(e => e.YetkiId).HasColumnName("YetkiID");

                entity.HasOne(d => d.KullaniciRol)
                    .WithMany(p => p.RolYetkiDetays)
                    .HasForeignKey(d => d.KullaniciRolId)
                    .HasConstraintName("FK_RolYetkiDetay_KullaniciRol");

                entity.HasOne(d => d.SayfaIzin)
                    .WithMany(p => p.RolYetkiDetays)
                    .HasForeignKey(d => d.SayfaIzinId)
                    .HasConstraintName("FK_RolYetkiDetay_SayfaIzin");

                entity.HasOne(d => d.Yetki)
                    .WithMany(p => p.RolYetkiDetays)
                    .HasForeignKey(d => d.YetkiId)
                    .HasConstraintName("FK_RolYetkiDetay_Yetki");
            });

            modelBuilder.Entity<Sati>(entity =>
            {
                entity.HasKey(e => e.SatisId);

                entity.Property(e => e.SatisId).HasColumnName("SatisID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IlanBilgileriId).HasColumnName("ilanBilgileriID");

                entity.Property(e => e.KomisyonId).HasColumnName("KomisyonID");

                entity.Property(e => e.KullaniciId).HasColumnName("KullaniciID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NoterId).HasColumnName("NoterID");

                entity.Property(e => e.SatisTutari).HasColumnType("money");

                entity.Property(e => e.Tarih).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SatiCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Satis_KullaniciCalisan");

                entity.HasOne(d => d.IlanBilgileri)
                    .WithMany(p => p.Satis)
                    .HasForeignKey(d => d.IlanBilgileriId)
                    .HasConstraintName("FK_Satis_ilanBilgileri");

                entity.HasOne(d => d.Komisyon)
                    .WithMany(p => p.Satis)
                    .HasForeignKey(d => d.KomisyonId)
                    .HasConstraintName("FK_Satis_Komisyon");

                entity.HasOne(d => d.Kullanici)
                    .WithMany(p => p.SatiKullanicis)
                    .HasForeignKey(d => d.KullaniciId)
                    .HasConstraintName("FK_Satis_Kullanici");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SatiModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Satis_KullaniciCalisan1");

                entity.HasOne(d => d.Noter)
                    .WithMany(p => p.Satis)
                    .HasForeignKey(d => d.NoterId)
                    .HasConstraintName("FK_Satis_Noter");
            });

            modelBuilder.Entity<SayfaIzin>(entity =>
            {
                entity.ToTable("SayfaIzin");

                entity.Property(e => e.SayfaIzinId).HasColumnName("SayfaIzinID");

                entity.Property(e => e.Sayfa).HasMaxLength(50);
            });

            modelBuilder.Entity<Sozlesme>(entity =>
            {
                entity.ToTable("Sozlesme");

                entity.Property(e => e.SozlesmeId).HasColumnName("SozlesmeID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SozlesmeAdi).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SozlesmeCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_Sozlesme_Kullanici");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SozlesmeModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Sozlesme_Kullanici1");
            });

            modelBuilder.Entity<Statu>(entity =>
            {
                entity.ToTable("Statu");

                entity.Property(e => e.StatuId).HasColumnName("StatuID");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.Statusu).HasMaxLength(50);

                entity.Property(e => e.UstStatuId).HasColumnName("UstStatuID");
            });

            modelBuilder.Entity<TramerParca>(entity =>
            {
                entity.ToTable("TramerParca");

                entity.Property(e => e.AktifMi).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParcaAdi).HasMaxLength(30);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TramerParcaCreatedByNavigations)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_TramerParca_KullaniciCalisan");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.TramerParcaModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_TramerParca_KullaniciCalisan1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User");

                entity.Property(e => e.Gg).HasColumnName("gg");

                entity.Property(e => e.PasswordHash).IsUnicode(false);

                entity.Property(e => e.PasswordSalt).IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Yetki>(entity =>
            {
                entity.ToTable("Yetki");

                entity.Property(e => e.YetkiId).HasColumnName("YetkiID");

                entity.Property(e => e.YetkiTuru).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
