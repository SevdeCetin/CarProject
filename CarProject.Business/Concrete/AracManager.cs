using CarProject.Business.Abstract;
using CarProject.Business.DTOs;
using CarProject.Common.Mapping;
using CarProject.Core.Entity;
using CarProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Business.Concrete
{
    public class AracManager : IAracService
    {
        private IUnitOfWork _unitOfWork;
        protected readonly IAracRepository _arac;
        public AracManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _arac = _unitOfWork.AracRepository;
            

        }

        public string CarPropDetail(int AracId, int detail)
        {
           return _arac.CarPropDetail(AracId, detail);
        }

        public async Task<AracDTO> GetAsync(int id)
        {
            var item = await _arac.GetAsync(x=>x.AracId==id);
            AracDTO aracDTO = new AracDTO()
            {
                AracId = item.AracId,
                Yil = item.Yil,
                KmBilgisi = (decimal)item.KmBilgisi,
                Aciklama = item.Aciklama,
                AktifMi = (bool)item.AktifMi,
                Fiyat = (decimal)item.Fiyat,
                Statusu = await _unitOfWork.StatusRepository.GetStatusAsync(item.AracId),
                KullaniciTipi = await _unitOfWork.KullaniciRepository.KullaniciRolu((int)item.KullaniciId),
                Marka = CarPropDetail(item.AracId, 1),
                Model = CarPropDetail(item.AracId, 2),
                Versiyon = CarPropDetail(item.AracId, 3),
                FirmaAd = "",
                Renk = CarPropDetail(item.AracId, 8),
                VitesTipi = CarPropDetail(item.AracId, 6),
                YakıtTipi = CarPropDetail(item.AracId, 4),
                GovdeTipi = CarPropDetail(item.AracId, 5),
                Donanim = CarPropDetail(item.AracId, 7),
                OlusturanKişi = (await _unitOfWork.KullaniciRepository.GetAsync(x=>x.KullaniciId==item.CreatedBy) as Kullanici).KullaniciAdi,
                CreatedBy = item.CreatedBy,
                CreatedDate = item.CreatedDate,
                ModifiedBy = item.ModifiedBy,
                ModifiedDate = item.ModifiedDate,
                Fotograf= (await _unitOfWork.FotografRepository.Fotograflar(item.AracId)) as List<string>
            };
            return aracDTO;
        }

        public async Task<AracDTO> CreateAsync(AracDTO entity)
        {
            //değişecek 
            var deger = MyAutoMapper<AracDTO, Arac>.Map(entity);
            if (deger != null)
            {
                await _arac.AddAsync(deger);
                await _unitOfWork.Complete();
            }
            return entity;
        }

        public async Task UpdateAsync(AracDTO entity)
        {
            var deger = MyAutoMapper<AracDTO, Arac>.Map(entity);
            _arac.UpdateAsync(deger);
            await _unitOfWork.Complete();
        }

        public async Task DeleteAsync(int id)
        {
            var deger = await _arac.GetAsync(x => x.AracId == id);
            _arac.DeleteAsync(deger);
            await _unitOfWork.Complete();
        }

        public async Task<IEnumerable<AracDTO>> CarList(Expression<Func<AracDTO, bool>> filter = null)
        {
            //DB deki Arac tablosundaki verileri AracDTO tipine çevirerek listeledim.
            List<AracDTO> aracs = new List<AracDTO>();
            var degerler = await _arac.GetAllAsync(x=>x.AktifMi==true);
            foreach (var item in (degerler))
            {
                aracs.Add(new AracDTO
                {
                    AracId = item.AracId,
                    Yil = item.Yil,
                    KmBilgisi = (decimal)item.KmBilgisi,
                    Aciklama = item.Aciklama,
                    AktifMi = (bool)item.AktifMi,
                    Fiyat = (decimal)item.Fiyat,
                    Statusu = await _unitOfWork.StatusRepository.GetStatusAsync(item.AracId),
                    KullaniciTipi = ""/*(KullaniciService.KullaniciGetir((int)item.KullaniciID)).Rol*/,
                    Marka = CarPropDetail(item.AracId, 1),
                    Model = CarPropDetail(item.AracId, 2),
                    Versiyon = CarPropDetail(item.AracId, 3),
                    FirmaAd = "",
                    Renk = CarPropDetail(item.AracId, 8),
                    VitesTipi = CarPropDetail(item.AracId, 6),
                    YakıtTipi = CarPropDetail(item.AracId, 4),
                    GovdeTipi = CarPropDetail(item.AracId, 5),
                    Donanim = CarPropDetail(item.AracId, 7),
                    OlusturanKişi = "", /*item.CreatedBy == null ? "-" : (KullaniciService.KullaniciRolListele().Where(a => a.KullaniciID == item.CreatedBy).FirstOrDefault()).KullaniciAd,*/
                    CreatedBy = item.CreatedBy,
                    CreatedDate = item.CreatedDate,
                    ModifiedBy = item.ModifiedBy,
                    ModifiedDate = item.ModifiedDate
                });
            }

            return aracs;
        }


    }
}
