using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject.Business.DTOs
{
    public class AracDTO:BaseDTO
    {
        public AracDTO()
        {
            Fotograf= new List<string>();
        }
        public int AracId { get; set; }
        public string Statusu { get; set; }
        public string KullaniciTipi { get; set; }
        public string FirmaAd { get; set; }
        public List<string> Fotograf { get; set; }
        public string Versiyon { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string VitesTipi { get; set; }
        public string GovdeTipi { get; set; }
        public string YakıtTipi { get; set; }
        public string Donanim { get; set; }
        public string Renk { get; set; }
        public int? Yil { get; set; }
        public decimal KmBilgisi { get; set; }
        public decimal Fiyat { get; set; }
        public string Aciklama { get; set; }
        public string OlusturanKişi { get; set; }

    }
}
