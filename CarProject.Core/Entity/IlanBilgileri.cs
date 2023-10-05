using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class IlanBilgileri
    {
        public IlanBilgileri()
        {
            FavoriIlans = new HashSet<FavoriIlan>();
            Satis = new HashSet<Sati>();
        }

        public int IlanBilgileriId { get; set; }
        public int? AracId { get; set; }
        public string IlanBasligi { get; set; }
        public string IlanAciklama { get; set; }
        public bool? AktifMi { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Arac Arac { get; set; }
        public virtual Kullanici CreatedByNavigation { get; set; }
        public virtual Kullanici ModifiedByNavigation { get; set; }
        public virtual ICollection<FavoriIlan> FavoriIlans { get; set; }
        public virtual ICollection<Sati> Satis { get; set; }
    }
}
