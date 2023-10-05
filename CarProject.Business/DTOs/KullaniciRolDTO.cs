using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject.Business.DTOs
{
    public class KullaniciRolDTO
    {
        public int KullaniciID { get; set; }
        public string KullaniciAd { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sifre { get; set; }
        public string Rol { get; set; }
        public int RolID { get; set; }
        public bool AktifMi { get; set; }
    }
}
