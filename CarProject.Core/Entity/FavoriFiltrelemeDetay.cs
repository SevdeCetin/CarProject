using System;
using System.Collections.Generic;

#nullable disable

namespace CarProject.Core.Entity
{
    public partial class FavoriFiltrelemeDetay
    {
        public int FavoriFiltrelemeDetayId { get; set; }
        public int? FavoriAramaId { get; set; }
        public int? AracOzellikId { get; set; }
        public bool AktifMi { get; set; }

        public virtual AracOzellik AracOzellik { get; set; }
        public virtual FavoriArama FavoriArama { get; set; }
    }
}
