using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class ChatBotDegerlendirme
    {
        public int ChatBotDegerlendirmeId { get; set; }
        public bool? Yeterlilik { get; set; }
        public int? ChatBotId { get; set; }
        public int? KullaniciId { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Chatbot ChatBot { get; set; }
        public virtual Kullanici CreatedByNavigation { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Kullanici ModifiedByNavigation { get; set; }
    }
}
