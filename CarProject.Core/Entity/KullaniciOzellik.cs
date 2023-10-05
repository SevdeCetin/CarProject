using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class KullaniciOzellik
    {
        public KullaniciOzellik()
        {
            KullaniciOzellikDetays = new HashSet<KullaniciOzellikDetay>();
        }

        public int KullaniciOzellikId { get; set; }
        public string KullaniciOzellikAd { get; set; }
        public bool? AktifMi { get; set; }

        public virtual ICollection<KullaniciOzellikDetay> KullaniciOzellikDetays { get; set; }
    }
}
