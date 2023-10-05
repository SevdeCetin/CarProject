using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarProject.Business.DTOs
{
    public class RolDTO
    {
        public int KullaniciRolID { get; set; }

        [StringLength(50)]
        public string Rol { get; set; }

        public bool? AktifMi { get; set; }
    }
}
