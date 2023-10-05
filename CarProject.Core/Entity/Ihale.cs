using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class Ihale
    {
        public Ihale()
        {
            IhaleDetays = new HashSet<IhaleDetay>();
            IhaleStatuDetays = new HashSet<IhaleStatuDetay>();
        }

        public int IhaleId { get; set; }
        public int? KullaniciId { get; set; }
        public string IhaleAdi { get; set; }
        public TimeSpan? BaslangicSaat { get; set; }
        public DateTime? IhaleBasTarih { get; set; }
        public DateTime? IhaleBitisTarih { get; set; }
        public TimeSpan? BitisSaati { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? AktifMi { get; set; }

        public virtual Kullanici CreatedByNavigation { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual ICollection<IhaleDetay> IhaleDetays { get; set; }
        public virtual ICollection<IhaleStatuDetay> IhaleStatuDetays { get; set; }
    }
}
