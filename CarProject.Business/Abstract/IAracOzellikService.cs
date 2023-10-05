using CarProject.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Business.Abstract
{
    public interface IAracOzellikService
    {
        Task<string> OzellikAdGetir(string ozellik);
        Task<IEnumerable<MarkaDTO>> MarkaListele();
        Task<IEnumerable<ModelDTO>> ModelListele();
        Task<IEnumerable<VersiyonDTO>> VersiyonListele();
        Task<IEnumerable<YakitDTO>> YakitListele();
        Task<IEnumerable<GovdeDTO>> GovdeTipiListele();
        Task<IEnumerable<VitesDTO>> VitesTipiListele();
        Task<IEnumerable<DonanimDTO>> DonanımListele();
        Task<IEnumerable<RenkDTO>> RenkListele();
    }
}
