using CarProject.Business.Abstract;
using CarProject.Business.DTOs;
using CarProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using CarProject.Common.Mapping;
using CarProject.Core.Entity;

namespace CarProject.Business.Concrete
{
    public class AracOzellikManager : IAracOzellikService
    {
        private IUnitOfWork _unitOfWork;
        protected readonly IAracOzellikRepository _arac;
        public AracOzellikManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _arac = _unitOfWork.AracOzellikRepository;
        }
        public Task<string> OzellikAdGetir(string ozellik)
        {
            int oz = Int32.Parse(ozellik);
            return _arac.OzellikAdGetir(ozellik);
        }

        public async Task<IEnumerable<MarkaDTO>> MarkaListele()
        {
            var ozellik = await _arac.GetAllAsync(a => a.EnUstOzellikId == 1 && a.AracOzellikId != 1);
            
            return MyAutoMapper<AracOzellik, MarkaDTO>.MapList((await _arac.GetAllAsync(a => a.EnUstOzellikId == 1 && a.AracOzellikId != 1 )) as List<AracOzellik>);
        }

        public async Task<IEnumerable<ModelDTO>> ModelListele()
        {
            var ozellik = await _arac.GetAllAsync(a => a.EnUstOzellikId == 2 && a.AracOzellikId != 2);
            
            return MyAutoMapper<AracOzellik, ModelDTO>.MapList((await _arac.GetAllAsync(a => a.EnUstOzellikId == 2 && a.AracOzellikId != 2 )) as List<AracOzellik>);

        }

        public async Task<IEnumerable<VersiyonDTO>> VersiyonListele()
        {
            var ozellik = await _arac.GetAllAsync(a => a.EnUstOzellikId == 3 && a.AracOzellikId != 3);
            
            return MyAutoMapper<AracOzellik, VersiyonDTO>.MapList((await _arac.GetAllAsync(a => a.EnUstOzellikId == 3 && a.AracOzellikId != 3 )) as List<AracOzellik>);

        }

        public async Task<IEnumerable<YakitDTO>> YakitListele()
        {
            var ozellik = await _arac.GetAllAsync(a => a.EnUstOzellikId == 4 && a.AracOzellikId != 4);
            
            return MyAutoMapper<AracOzellik, YakitDTO>.MapList((await _arac.GetAllAsync(a => a.EnUstOzellikId == 4 && a.AracOzellikId != 4)) as List<AracOzellik>);

        }

        public async Task<IEnumerable<GovdeDTO>> GovdeTipiListele()
        {
            var ozellik = await _arac.GetAllAsync(a => a.EnUstOzellikId == 5 && a.AracOzellikId != 5);
            
            return MyAutoMapper<AracOzellik, GovdeDTO>.MapList((await _arac.GetAllAsync(a => a.EnUstOzellikId == 5 && a.AracOzellikId != 5)) as List<AracOzellik>);

        }

        public async Task<IEnumerable<VitesDTO>> VitesTipiListele()
        {
            var ozellik = await _arac.GetAllAsync(a => a.EnUstOzellikId == 6 && a.AracOzellikId != 6);
            
            return MyAutoMapper<AracOzellik, VitesDTO>.MapList((await _arac.GetAllAsync(a => a.EnUstOzellikId == 6 && a.AracOzellikId != 6)) as List<AracOzellik>);

        }

        public async Task<IEnumerable<DonanimDTO>> DonanımListele()
        {
            var ozellik = await _arac.GetAllAsync(a => a.EnUstOzellikId == 1 && a.AracOzellikId != 1);
            
            return MyAutoMapper<AracOzellik, DonanimDTO>.MapList((await _arac.GetAllAsync(a => a.EnUstOzellikId == 7 && a.AracOzellikId != 7)) as List<AracOzellik>);

        }

        public async Task<IEnumerable<RenkDTO>> RenkListele()
        {
            var ozellik = await _arac.GetAllAsync(a => a.EnUstOzellikId == 8 && a.AracOzellikId != 8);
            
            return MyAutoMapper<AracOzellik, RenkDTO>.MapList((await _arac.GetAllAsync(a => a.EnUstOzellikId == 8 && a.AracOzellikId != 8)) as List<AracOzellik>);

        }
    }
}
