using CarProject.Business.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarProject.Business.DTOs
{
    public class KullaniciDTO:BaseDTO
    {
        public int KullaniciID { get; set; }

        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [StringLength(50)]
        public string Ad { get; set; }

        [StringLength(50)]
        public string Soyad { get; set; }

        public string Sifre { get; set; }

        public int KullaniciRolID { get; set; }
    }
}
