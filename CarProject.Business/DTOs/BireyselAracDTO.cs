using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Business.DTOs
{
    public class BireyselAracDTO
    {
        public int AracID { get; set; }
        public string Statusu { get; set; }
        public string KullaniciTipi { get; set; }
        public string FirmaAd { get; set; }
        public string Fotograf { get; set; }
        public string Versiyon { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string VitesTipi { get; set; }
        public string GovdeTipi { get; set; }
        public string YakıtTipi { get; set; }
        public string Donanim { get; set; }
        public string Renk { get; set; }
        public int? Yil { get; set; }
        public Nullable<decimal> KmBilgisi { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public string Aciklama { get; set; }
        public Nullable<bool> AktifMi { get; set; }
        public DateTime? OlusmaTarihi { get; set; }
        public int? Olusturan { get; set; }
        public string OlusturanKişi { get; set; }
        public DateTime? DuzenlemeTarihi { get; set; }
        public int? Duzenleyen { get; set; }
    }
}
