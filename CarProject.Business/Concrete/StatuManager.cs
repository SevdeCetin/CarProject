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
    public class StatuManager : IStatuService
    {
        private IUnitOfWork _unitOfWork;
        protected readonly IStatusRepository _statu;
        public StatuManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _statu = _unitOfWork.StatusRepository;
        }

        public async Task<StatuDTO> CreateAsync(StatuDTO entity)
        {
            var deger = MyAutoMapper<StatuDTO, Statu>.Map(entity);
            if (deger != null)
            {
                await _statu.AddAsync(deger);
                await _unitOfWork.Complete();
            }
            return entity;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StatuDTO>> GetAllAsync(Expression<Func<StatuDTO, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(StatuDTO entity)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetAsync(int id)
        {
            return await _statu.GetStatusAsync(id);
        }
    }
}
