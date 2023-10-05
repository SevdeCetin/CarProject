using CarProject.DataAccess.Abstract;
using CarProject.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private IhaleDBContext _context;
        public UnitOfWork(IhaleDBContext context)
        {
            _context = context;
            AracRepository = new AracRepository(_context);
            StatusRepository = new StatusRepository(_context);
            KullaniciRepository = new KullaniciRepository(_context);
            AracOzellikRepository = new AracOzellikRepository(_context);
            FotografRepository = new FotografRepository(_context);
        }

        public IAracRepository AracRepository { get; private set; }

        public IStatusRepository StatusRepository { get; private set; }

        public IKullaniciRepository KullaniciRepository { get; private set; }

        public IAracOzellikRepository AracOzellikRepository { get; private set; }

        public IFotografRepository FotografRepository { get; private set; }

        public async Task<int> Complete()
        {
            int durum = await _context.SaveChangesAsync();
            return durum;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
