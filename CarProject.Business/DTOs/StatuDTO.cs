using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarProject.Business.DTOs
{
    public class StatuDTO
    {
        public int StatuID { get; set; }

        [StringLength(50)]
        public string Statusu { get; set; }
    }
}
