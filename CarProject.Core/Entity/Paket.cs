using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class Paket
    {
        public Paket()
        {
            KullaniciPakets = new HashSet<KullaniciPaket>();
        }

        public int PaketId { get; set; }
        public int? AylikAracSiniri { get; set; }
        public int? KomisyonAracSiniri { get; set; }
        public bool? AktifMi { get; set; }
        public string PaketAdi { get; set; }

        public virtual ICollection<KullaniciPaket> KullaniciPakets { get; set; }
    }
}
