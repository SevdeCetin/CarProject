using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class Islem
    {
        public Islem()
        {
            LogKayitlaris = new HashSet<LogKayitlari>();
        }

        public int IslemId { get; set; }
        public string IslemTuru { get; set; }

        public virtual ICollection<LogKayitlari> LogKayitlaris { get; set; }
    }
}
