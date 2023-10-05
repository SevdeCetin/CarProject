using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class Ekspertiz
    {
        public int EkspertizId { get; set; }
        public string EkspertizAd { get; set; }
        public string Adres { get; set; }
        public bool? AktifMi { get; set; }
    }
}
