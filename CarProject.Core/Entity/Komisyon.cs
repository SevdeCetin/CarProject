using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class Komisyon
    {
        public Komisyon()
        {
            Satis = new HashSet<Sati>();
        }

        public int KomisyonId { get; set; }
        public decimal? MinTutar { get; set; }
        public decimal? MaxTutar { get; set; }
        public decimal? KomisyonTutar { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? BaslangicTarih { get; set; }
        public DateTime? BitisTarih { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Kullanici CreatedByNavigation { get; set; }
        public virtual Kullanici ModifiedByNavigation { get; set; }
        public virtual ICollection<Sati> Satis { get; set; }
    }
}
