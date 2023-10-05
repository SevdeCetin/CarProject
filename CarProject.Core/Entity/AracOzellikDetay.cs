using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class AracOzellikDetay
    {
        public int AracOzellikDetay1 { get; set; }
        public int? AracOzellikId { get; set; }
        public int? AracId { get; set; }
        public bool? AktifMi { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual AracOzellik AracOzellik { get; set; }
    }
}
