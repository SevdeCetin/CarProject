using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class AracOzellik
    {
        public AracOzellik()
        {
            AracOzellikDetays = new HashSet<AracOzellikDetay>();
            FavoriFiltrelemeDetays = new HashSet<FavoriFiltrelemeDetay>();
        }

        public int AracOzellikId { get; set; }
        public int? UstOzellikId { get; set; }
        public int? EnUstOzellikId { get; set; }
        public string OzellikAd { get; set; }
        public bool? AktifMi { get; set; }

        public virtual ICollection<AracOzellikDetay> AracOzellikDetays { get; set; }
        public virtual ICollection<FavoriFiltrelemeDetay> FavoriFiltrelemeDetays { get; set; }
    }
}
