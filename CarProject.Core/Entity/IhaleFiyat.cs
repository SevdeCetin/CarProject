using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class IhaleFiyat
    {
        public int IhaleFiyatId { get; set; }
        public int? AracId { get; set; }
        public decimal? BaslangicFiyat { get; set; }
        public decimal? MinAlimFiyat { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual Kullanici CreatedByNavigation { get; set; }
        public virtual Kullanici ModifiedByNavigation { get; set; }
    }
}
