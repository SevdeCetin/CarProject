using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class KullaniciPaket
    {
        public int KullaniciPaketId { get; set; }
        public int? PaketId { get; set; }
        public int? KullaniciId { get; set; }
        public bool? AktifMi { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual Paket Paket { get; set; }
    }
}
