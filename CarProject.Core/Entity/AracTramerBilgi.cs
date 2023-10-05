using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class AracTramerBilgi
    {
        public int AracTramerBilgiId { get; set; }
        public int? AracId { get; set; }
        public int? TramerParcaId { get; set; }
        public int? ParcaDurumId { get; set; }
        public decimal? TramerTutari { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual Kullanici CreatedByNavigation { get; set; }
        public virtual Kullanici ModifiedByNavigation { get; set; }
        public virtual ParcaDurum ParcaDurum { get; set; }
        public virtual TramerParca TramerParca { get; set; }
    }
}
