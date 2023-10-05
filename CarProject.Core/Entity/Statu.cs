using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class Statu
    {
        public Statu()
        {
            AracStatuDetays = new HashSet<AracStatuDetay>();
            IhaleStatuDetays = new HashSet<IhaleStatuDetay>();
        }

        public int StatuId { get; set; }
        public int? UstStatuId { get; set; }
        public string Statusu { get; set; }
        public bool? AktifMi { get; set; }

        public virtual ICollection<AracStatuDetay> AracStatuDetays { get; set; }
        public virtual ICollection<IhaleStatuDetay> IhaleStatuDetays { get; set; }
    }
}
