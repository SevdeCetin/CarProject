using CarProject.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Business.Abstract
{
    public interface IStatuService
    {
        Task<IEnumerable<StatuDTO>> GetAllAsync(Expression<Func<StatuDTO, bool>> filter = null);

        Task<string> GetAsync(int id);

        Task<StatuDTO> CreateAsync(StatuDTO entity);
        Task UpdateAsync(StatuDTO entity);
        Task DeleteAsync(int id);
    }
}
