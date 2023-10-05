using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class KullaniciOzellikDetay
    {
        public int KullaniciOzellikDetayId { get; set; }
        public int? KullaniciId { get; set; }
        public int? KullaniciOzellikId { get; set; }
        public string Ozellik { get; set; }
        public bool? AktifMi { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual KullaniciOzellik KullaniciOzellik { get; set; }
    }
}
