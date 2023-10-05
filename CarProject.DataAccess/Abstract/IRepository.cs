
using CarProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Abstract
{
    public interface IRepository<T> where T : class,  new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> filter = null);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null);
        Task AddAsync(T entity);
        void UpdateAsync(T entity);
        void DeleteAsync(T entity);
    }
}
