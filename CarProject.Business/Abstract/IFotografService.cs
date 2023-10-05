using CarProject.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Business.Abstract
{
    public interface IFotografService
    {
        Task<IEnumerable<string>> Fotograflar(int id);
        Task<IEnumerable<FotografDTO>> GetAllAsync();
        Task<FotografDTO> GetAsync(int id);
        Task<FotografDTO> CreateAsync(FotografDTO entity);
        Task UpdateAsync(FotografDTO entity);
        Task DeleteAsync(int id);
    }
}
