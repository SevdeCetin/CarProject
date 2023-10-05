using CarProject.Business.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Business.Abstract
{
    public interface IKullaniciService
    {
        Task<bool> KullaniciVarMi(KullaniciDTO kullanici);
        Task<IEnumerable<KullaniciDTO>> GetAllAsync();

        Task<KullaniciDTO> GetAsync(int id);
        Task<KullaniciRolDTO> GetRolAsync(int id);

        Task<KullaniciDTO> CreateAsync(KullaniciDTO entity);
        Task UpdateAsync(KullaniciDTO entity);
        Task DeleteAsync(int id);
    }
}
