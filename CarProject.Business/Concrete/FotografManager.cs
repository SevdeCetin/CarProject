using CarProject.Business.Abstract;
using CarProject.Business.DTOs;
using CarProject.Common.Mapping;
using CarProject.Core.Entity;
using CarProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Business.Concrete
{
    public class FotografManager : IFotografService
    {
        private IUnitOfWork _unitOfWork;
        protected readonly IFotografRepository _fotograf;
        public FotografManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _fotograf = _unitOfWork.FotografRepository;
        }
        public async Task<FotografDTO> CreateAsync(FotografDTO entity)
        {
            var deger = MyAutoMapper<FotografDTO, Fotograf>.Map(entity);
            if (deger != null)
            {
                await _fotograf.AddAsync(deger);
                await _unitOfWork.Complete();
            }
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            var deger = await _fotograf.GetAsync(x => x.FotografId == id);
            _fotograf.DeleteAsync(deger);
            await _unitOfWork.Complete();
        }

        public async Task<IEnumerable<FotografDTO>> GetAllAsync()
        {
            var deger = await _fotograf.GetAllAsync(x => x.AktifMi == true);
            return MyAutoMapper<Fotograf, FotografDTO>.MapList((List<Fotograf>)deger);
        }

        public async Task<FotografDTO> GetAsync(int id)
        {
            var deger = await _fotograf.GetAsync(x => x.FotografId == id);
            return MyAutoMapper<Fotograf, FotografDTO>.Map(deger);
        }

        public async Task UpdateAsync(FotografDTO entity)
        {
            var deger = MyAutoMapper<FotografDTO, Fotograf>.Map(entity);
            _fotograf.UpdateAsync(deger);
            await _unitOfWork.Complete();
        }

        public async Task<IEnumerable<string>> Fotograflar(int id)
        {
           return await _fotograf.Fotograflar(id);
        }
    }
}
