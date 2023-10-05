using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class Sati
    {
        public int SatisId { get; set; }
        public int? IlanBilgileriId { get; set; }
        public int? KullaniciId { get; set; }
        public int? NoterId { get; set; }
        public int? KomisyonId { get; set; }
        public decimal? SatisTutari { get; set; }
        public DateTime? Tarih { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Kullanici CreatedByNavigation { get; set; }
        public virtual IlanBilgileri IlanBilgileri { get; set; }
        public virtual Komisyon Komisyon { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Kullanici ModifiedByNavigation { get; set; }
        public virtual Noter Noter { get; set; }
    }
}
