using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class FavoriArama
    {
        public FavoriArama()
        {
            FavoriFiltrelemeDetays = new HashSet<FavoriFiltrelemeDetay>();
        }

        public int FavoriAramaId { get; set; }
        public DateTime? Tarih { get; set; }
        public int? KullaniciId { get; set; }
        public int? AktifMi { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual ICollection<FavoriFiltrelemeDetay> FavoriFiltrelemeDetays { get; set; }
    }
}
