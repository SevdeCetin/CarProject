using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class AnahtarKelime
    {
        public int AnahtarKelimeId { get; set; }
        public int? ChatBotId { get; set; }
        public string Kelime { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Chatbot ChatBot { get; set; }
        public virtual Kullanici CreatedByNavigation { get; set; }
        public virtual Kullanici ModifiedByNavigation { get; set; }
    }
}
