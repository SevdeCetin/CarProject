using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class RolYetkiDetay
    {
        public int RolYetkiDetayId { get; set; }
        public int? KullaniciRolId { get; set; }
        public int? YetkiId { get; set; }
        public int? SayfaIzinId { get; set; }
        public bool? AktifMi { get; set; }

        public virtual KullaniciRol KullaniciRol { get; set; }
        public virtual SayfaIzin SayfaIzin { get; set; }
        public virtual Yetki Yetki { get; set; }
    }
}
