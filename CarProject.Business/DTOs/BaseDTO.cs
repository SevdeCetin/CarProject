using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CarProject.Business.DTOs
{
    public class BaseDTO
    {
        [DisplayName("Aktif Mi?")]
        public bool AktifMi { get; set; }
        [DisplayName("Oluşturan")]
        public int? CreatedBy { get; set; }

        [DisplayName("Oluşturulma Tarihi")]       
        public DateTime? CreatedDate { get; set; }
        [DisplayName("Düzenleyen")]
        public int? ModifiedBy { get; set; }
        [DisplayName("Düzenlenme Tarihi")]
        public DateTime? ModifiedDate { get; set; }


    }
}
