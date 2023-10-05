using CarProject.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Business.Abstract
{
    public interface IAracService
    {
        string CarPropDetail(int AracId, int detail);
        Task<AracDTO> GetAsync(int id);
        Task<AracDTO> CreateAsync(AracDTO entity);
        Task UpdateAsync(AracDTO entity);
        Task DeleteAsync(int id);
        Task<IEnumerable<AracDTO>> CarList(Expression<Func<AracDTO, bool>> filter = null);
    }
}
