using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class Arac
    {
        public Arac()
        {
            AracOzellikDetays = new HashSet<AracOzellikDetay>();
            AracStatuDetays = new HashSet<AracStatuDetay>();
            AracTramerBilgis = new HashSet<AracTramerBilgi>();
            Fotografs = new HashSet<Fotograf>();
            IhaleDetays = new HashSet<IhaleDetay>();
            IhaleFiyats = new HashSet<IhaleFiyat>();
            IlanBilgileris = new HashSet<IlanBilgileri>();
        }

        public int AracId { get; set; }
        public int? Yil { get; set; }
        public decimal? KmBilgisi { get; set; }
        public decimal? Fiyat { get; set; }
        public string Aciklama { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? KullaniciId { get; set; }

        public virtual ICollection<AracOzellikDetay> AracOzellikDetays { get; set; }
        public virtual ICollection<AracStatuDetay> AracStatuDetays { get; set; }
        public virtual ICollection<AracTramerBilgi> AracTramerBilgis { get; set; }
        public virtual ICollection<Fotograf> Fotografs { get; set; }
        public virtual ICollection<IhaleDetay> IhaleDetays { get; set; }
        public virtual ICollection<IhaleFiyat> IhaleFiyats { get; set; }
        public virtual ICollection<IlanBilgileri> IlanBilgileris { get; set; }
    }
}
