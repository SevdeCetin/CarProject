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
    public class KullaniciManager : IKullaniciService
    {
        private IUnitOfWork _unitOfWork;
        protected readonly IKullaniciRepository _kullanici;
        public KullaniciManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _kullanici = _unitOfWork.KullaniciRepository;
        }
        public async Task DeleteAsync(int id)
        {
            var deger = await _kullanici.GetAsync(x => x.KullaniciId == id);
            _kullanici.DeleteAsync(deger);
            await _unitOfWork.Complete();
        }

        public async Task<IEnumerable<KullaniciDTO>> GetAllAsync()
        {
            var deger = await _kullanici.GetAllAsync(x => x.AktifMi == true);
            return MyAutoMapper<Kullanici, KullaniciDTO>.MapList((List<Kullanici>)deger);
        }

        public async Task<KullaniciDTO> GetAsync(int id)
        {
            var deger = await _kullanici.GetAsync(x => x.KullaniciId == id);
            return MyAutoMapper<Kullanici, KullaniciDTO>.Map(deger);
        }

        public async Task<KullaniciRolDTO> GetRolAsync(int id)
        {
            var kullanici = await _kullanici.GetAsync(x => x.KullaniciId==id);
            KullaniciRolDTO kullaniciRolDTO = new KullaniciRolDTO()
            {
                KullaniciID = kullanici.KullaniciId,
                Adi = kullanici.Ad,
                Soyadi = kullanici.Soyad,
                KullaniciAd = kullanici.KullaniciAdi,
                RolID = (int)kullanici.KullaniciRolId,
                Rol = (await _kullanici.KullaniciRolu(kullanici.KullaniciId)).ToString(),
                Sifre = kullanici.Sifre,
                AktifMi = (bool)kullanici.AktifMi
            };
            return kullaniciRolDTO;
        }

        public Task<bool> KullaniciVarMi(KullaniciDTO kullanici)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(KullaniciDTO entity)
        {
            var deger = MyAutoMapper<KullaniciDTO, Kullanici>.Map(entity);
            _kullanici.UpdateAsync(deger);
            await _unitOfWork.Complete();
        }

        public async Task<KullaniciDTO> CreateAsync(KullaniciDTO entity)
        {
            var deger = MyAutoMapper<KullaniciDTO, Kullanici>.Map(entity);
            if (deger != null)
            {
                await _kullanici.AddAsync(deger);
                await _unitOfWork.Complete();
            }
            return entity;
        }
    }
}
