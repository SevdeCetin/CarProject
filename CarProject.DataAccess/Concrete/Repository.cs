
using CarProject.Core.Entity;
using CarProject.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T : class,  new()
    {
        protected DbContext _context;
        private DbSet<T> _dbSet;
        public Repository(DbContext dbContext)
        {
            _context = dbContext;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                var deger = await _dbSet.ToListAsync();
                var dd = deger.AsEnumerable();
                return deger.ToList();
            }
            var degerler = await _dbSet.Where(filter).ToListAsync();
            return await _dbSet.Where(filter).ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
            {
                return await _dbSet.FirstOrDefaultAsync();
            }
            return await _dbSet.FirstOrDefaultAsync(filter);
        }


        public void UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
        }

    }
}
