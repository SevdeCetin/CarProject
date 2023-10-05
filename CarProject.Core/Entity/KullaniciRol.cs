using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class KullaniciRol
    {
        public KullaniciRol()
        {
            Kullanicis = new HashSet<Kullanici>();
            RolYetkiDetays = new HashSet<RolYetkiDetay>();
        }

        public int KullaniciRolId { get; set; }
        public string Rol { get; set; }
        public bool? AktifMi { get; set; }

        public virtual ICollection<Kullanici> Kullanicis { get; set; }
        public virtual ICollection<RolYetkiDetay> RolYetkiDetays { get; set; }
    }
}
