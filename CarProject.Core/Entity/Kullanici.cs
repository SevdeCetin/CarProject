using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class Kullanici
    {
        public Kullanici()
        {
            AnahtarKelimeCreatedByNavigations = new HashSet<AnahtarKelime>();
            AnahtarKelimeModifiedByNavigations = new HashSet<AnahtarKelime>();
            AracStatuDetayCreatedByNavigations = new HashSet<AracStatuDetay>();
            AracStatuDetayModifiedByNavigations = new HashSet<AracStatuDetay>();
            AracTramerBilgiCreatedByNavigations = new HashSet<AracTramerBilgi>();
            AracTramerBilgiModifiedByNavigations = new HashSet<AracTramerBilgi>();
            ChatBotDegerlendirmeCreatedByNavigations = new HashSet<ChatBotDegerlendirme>();
            ChatBotDegerlendirmeKullanicis = new HashSet<ChatBotDegerlendirme>();
            ChatBotDegerlendirmeModifiedByNavigations = new HashSet<ChatBotDegerlendirme>();
            ChatbotCreatedByNavigations = new HashSet<Chatbot>();
            ChatbotModifiedByNavigations = new HashSet<Chatbot>();
            FavoriAramas = new HashSet<FavoriArama>();
            FavoriIlans = new HashSet<FavoriIlan>();
            FirmaTurCreatedByNavigations = new HashSet<FirmaTur>();
            FirmaTurModifiedByNavigations = new HashSet<FirmaTur>();
            FotografCreatedByNavigations = new HashSet<Fotograf>();
            FotografModifiedByNavigations = new HashSet<Fotograf>();
            IhaleCreatedByNavigations = new HashSet<Ihale>();
            IhaleFiyatCreatedByNavigations = new HashSet<IhaleFiyat>();
            IhaleFiyatModifiedByNavigations = new HashSet<IhaleFiyat>();
            IhaleKullanicis = new HashSet<Ihale>();
            IhaleStatuDetayCreatedByNavigations = new HashSet<IhaleStatuDetay>();
            IhaleStatuDetayModifiedByNavigations = new HashSet<IhaleStatuDetay>();
            IlanBilgileriCreatedByNavigations = new HashSet<IlanBilgileri>();
            IlanBilgileriModifiedByNavigations = new HashSet<IlanBilgileri>();
            InverseCreatedByNavigation = new HashSet<Kullanici>();
            InverseModifiedByNavigation = new HashSet<Kullanici>();
            KomisyonCreatedByNavigations = new HashSet<Komisyon>();
            KomisyonModifiedByNavigations = new HashSet<Komisyon>();
            KullaniciAracDetayCreatedByNavigations = new HashSet<KullaniciAracDetay>();
            KullaniciAracDetayKullanicis = new HashSet<KullaniciAracDetay>();
            KullaniciAracDetayModifiedByNavigations = new HashSet<KullaniciAracDetay>();
            KullaniciOzellikDetays = new HashSet<KullaniciOzellikDetay>();
            KullaniciPakets = new HashSet<KullaniciPaket>();
            MesajCreatedByNavigations = new HashSet<Mesaj>();
            MesajDetays = new HashSet<MesajDetay>();
            MesajModifiedByNavigations = new HashSet<Mesaj>();
            NoterCreatedByNavigations = new HashSet<Noter>();
            NoterModifiedByNavigations = new HashSet<Noter>();
            ParcaDurumCreatedByNavigations = new HashSet<ParcaDurum>();
            ParcaDurumModifiedByNavigations = new HashSet<ParcaDurum>();
            SatiCreatedByNavigations = new HashSet<Sati>();
            SatiKullanicis = new HashSet<Sati>();
            SatiModifiedByNavigations = new HashSet<Sati>();
            SozlesmeCreatedByNavigations = new HashSet<Sozlesme>();
            SozlesmeModifiedByNavigations = new HashSet<Sozlesme>();
            TramerParcaCreatedByNavigations = new HashSet<TramerParca>();
            TramerParcaModifiedByNavigations = new HashSet<TramerParca>();
        }

        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sifre { get; set; }
        public int? KullaniciRolId { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }

        public virtual Kullanici CreatedByNavigation { get; set; }
        public virtual KullaniciRol KullaniciRol { get; set; }
        public virtual Kullanici ModifiedByNavigation { get; set; }
        public virtual ICollection<AnahtarKelime> AnahtarKelimeCreatedByNavigations { get; set; }
        public virtual ICollection<AnahtarKelime> AnahtarKelimeModifiedByNavigations { get; set; }
        public virtual ICollection<AracStatuDetay> AracStatuDetayCreatedByNavigations { get; set; }
        public virtual ICollection<AracStatuDetay> AracStatuDetayModifiedByNavigations { get; set; }
        public virtual ICollection<AracTramerBilgi> AracTramerBilgiCreatedByNavigations { get; set; }
        public virtual ICollection<AracTramerBilgi> AracTramerBilgiModifiedByNavigations { get; set; }
        public virtual ICollection<ChatBotDegerlendirme> ChatBotDegerlendirmeCreatedByNavigations { get; set; }
        public virtual ICollection<ChatBotDegerlendirme> ChatBotDegerlendirmeKullanicis { get; set; }
        public virtual ICollection<ChatBotDegerlendirme> ChatBotDegerlendirmeModifiedByNavigations { get; set; }
        public virtual ICollection<Chatbot> ChatbotCreatedByNavigations { get; set; }
        public virtual ICollection<Chatbot> ChatbotModifiedByNavigations { get; set; }
        public virtual ICollection<FavoriArama> FavoriAramas { get; set; }
        public virtual ICollection<FavoriIlan> FavoriIlans { get; set; }
        public virtual ICollection<FirmaTur> FirmaTurCreatedByNavigations { get; set; }
        public virtual ICollection<FirmaTur> FirmaTurModifiedByNavigations { get; set; }
        public virtual ICollection<Fotograf> FotografCreatedByNavigations { get; set; }
        public virtual ICollection<Fotograf> FotografModifiedByNavigations { get; set; }
        public virtual ICollection<Ihale> IhaleCreatedByNavigations { get; set; }
        public virtual ICollection<IhaleFiyat> IhaleFiyatCreatedByNavigations { get; set; }
        public virtual ICollection<IhaleFiyat> IhaleFiyatModifiedByNavigations { get; set; }
        public virtual ICollection<Ihale> IhaleKullanicis { get; set; }
        public virtual ICollection<IhaleStatuDetay> IhaleStatuDetayCreatedByNavigations { get; set; }
        public virtual ICollection<IhaleStatuDetay> IhaleStatuDetayModifiedByNavigations { get; set; }
        public virtual ICollection<IlanBilgileri> IlanBilgileriCreatedByNavigations { get; set; }
        public virtual ICollection<IlanBilgileri> IlanBilgileriModifiedByNavigations { get; set; }
        public virtual ICollection<Kullanici> InverseCreatedByNavigation { get; set; }
        public virtual ICollection<Kullanici> InverseModifiedByNavigation { get; set; }
        public virtual ICollection<Komisyon> KomisyonCreatedByNavigations { get; set; }
        public virtual ICollection<Komisyon> KomisyonModifiedByNavigations { get; set; }
        public virtual ICollection<KullaniciAracDetay> KullaniciAracDetayCreatedByNavigations { get; set; }
        public virtual ICollection<KullaniciAracDetay> KullaniciAracDetayKullanicis { get; set; }
        public virtual ICollection<KullaniciAracDetay> KullaniciAracDetayModifiedByNavigations { get; set; }
        public virtual ICollection<KullaniciOzellikDetay> KullaniciOzellikDetays { get; set; }
        public virtual ICollection<KullaniciPaket> KullaniciPakets { get; set; }
        public virtual ICollection<Mesaj> MesajCreatedByNavigations { get; set; }
        public virtual ICollection<MesajDetay> MesajDetays { get; set; }
        public virtual ICollection<Mesaj> MesajModifiedByNavigations { get; set; }
        public virtual ICollection<Noter> NoterCreatedByNavigations { get; set; }
        public virtual ICollection<Noter> NoterModifiedByNavigations { get; set; }
        public virtual ICollection<ParcaDurum> ParcaDurumCreatedByNavigations { get; set; }
        public virtual ICollection<ParcaDurum> ParcaDurumModifiedByNavigations { get; set; }
        public virtual ICollection<Sati> SatiCreatedByNavigations { get; set; }
        public virtual ICollection<Sati> SatiKullanicis { get; set; }
        public virtual ICollection<Sati> SatiModifiedByNavigations { get; set; }
        public virtual ICollection<Sozlesme> SozlesmeCreatedByNavigations { get; set; }
        public virtual ICollection<Sozlesme> SozlesmeModifiedByNavigations { get; set; }
        public virtual ICollection<TramerParca> TramerParcaCreatedByNavigations { get; set; }
        public virtual ICollection<TramerParca> TramerParcaModifiedByNavigations { get; set; }
    }
}
