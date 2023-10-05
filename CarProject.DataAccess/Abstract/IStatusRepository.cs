using CarProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Abstract
{
    public interface IStatusRepository:IRepository<Statu>
    {
        Task<string> GetStatusAsync(int id);
    }
}
