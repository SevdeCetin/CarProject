using CarProject.Core;
using CarProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Abstract
{
    public interface IAuthRepo
    {
        Task<Kullanici> Register(Kullanici user, string password);
        Task<Kullanici> Login(string username, string password);
        Task<bool> UserExist(string username);
    }
}
