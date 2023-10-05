using CarProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Abstract
{
    public interface IKullaniciRepository:IRepository<Kullanici>
    {
        Task<bool> KullaniciVarMi(Kullanici kullanici);
        Task<string> KullaniciRolu(int id);
    }
}
