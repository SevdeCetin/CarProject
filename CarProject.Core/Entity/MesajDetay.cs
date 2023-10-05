using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class MesajDetay
    {
        public int MesajDetayId { get; set; }
        public int? KullaniciId { get; set; }
        public int? MesajId { get; set; }
        public bool? AktifMi { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual Mesaj Mesaj { get; set; }
    }
}
