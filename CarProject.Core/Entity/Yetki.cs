using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class Yetki
    {
        public Yetki()
        {
            RolYetkiDetays = new HashSet<RolYetkiDetay>();
        }

        public int YetkiId { get; set; }
        public string YetkiTuru { get; set; }
        public bool? AktifMi { get; set; }

        public virtual ICollection<RolYetkiDetay> RolYetkiDetays { get; set; }
    }
}
