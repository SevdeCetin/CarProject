using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class ParcaDurum
    {
        public ParcaDurum()
        {
            AracTramerBilgis = new HashSet<AracTramerBilgi>();
        }

        public int ParcaDurumId { get; set; }
        public string ParcaDurum1 { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Kullanici CreatedByNavigation { get; set; }
        public virtual Kullanici ModifiedByNavigation { get; set; }
        public virtual ICollection<AracTramerBilgi> AracTramerBilgis { get; set; }
    }
}
