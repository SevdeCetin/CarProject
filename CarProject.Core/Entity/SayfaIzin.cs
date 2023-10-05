using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class SayfaIzin
    {
        public SayfaIzin()
        {
            RolYetkiDetays = new HashSet<RolYetkiDetay>();
        }

        public int SayfaIzinId { get; set; }
        public string Sayfa { get; set; }
        public bool? AktifMi { get; set; }

        public virtual ICollection<RolYetkiDetay> RolYetkiDetays { get; set; }
    }
}
