using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class FavoriIlan
    {
        public int FavoriIlanId { get; set; }
        public int? KullaniciId { get; set; }
        public int? IlanId { get; set; }
        public bool? AktifMi { get; set; }

        public virtual IlanBilgileri Ilan { get; set; }
        public virtual Kullanici Kullanici { get; set; }
    }
}
