using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class LogKayitlari
    {
        public int LogId { get; set; }
        public DateTime? IslemTarihi { get; set; }
        public int? CreatedBy { get; set; }
        public string TabloAdi { get; set; }
        public int? TabloId { get; set; }
        public string Macadres { get; set; }
        public string IslemEtkisi { get; set; }
        public int? IslemId { get; set; }

        public virtual Islem Islem { get; set; }
    }
}
