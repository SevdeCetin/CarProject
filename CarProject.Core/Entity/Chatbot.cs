using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class Chatbot
    {
        public Chatbot()
        {
            AnahtarKelimes = new HashSet<AnahtarKelime>();
            ChatBotDegerlendirmes = new HashSet<ChatBotDegerlendirme>();
        }

        public int ChatbotId { get; set; }
        public string Soru { get; set; }
        public string Cevap { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Kullanici CreatedByNavigation { get; set; }
        public virtual Kullanici ModifiedByNavigation { get; set; }
        public virtual ICollection<AnahtarKelime> AnahtarKelimes { get; set; }
        public virtual ICollection<ChatBotDegerlendirme> ChatBotDegerlendirmes { get; set; }
    }
}
