using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class IhaleDetay
    {
        public int IhaleDetayId { get; set; }
        public int? AracId { get; set; }
        public int? IhaleId { get; set; }
        public bool? AktifMi { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual Ihale Ihale { get; set; }
    }
}
