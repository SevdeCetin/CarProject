using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class TramerParca
    {
        public TramerParca()
        {
            AracTramerBilgis = new HashSet<AracTramerBilgi>();
        }

        public int TramerParcaId { get; set; }
        public string ParcaAdi { get; set; }
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
