using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class KullaniciAracDetay
    {
        public int KullaniciAracDetayId { get; set; }
        public int? AracId { get; set; }
        public int? KullaniciId { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Kullanici CreatedByNavigation { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Kullanici ModifiedByNavigation { get; set; }
    }
}
