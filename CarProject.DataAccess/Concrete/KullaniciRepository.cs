using CarProject.Core.Entity;
using CarProject.DataAccess.Abstract;
using CarProject.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Concrete
{
    public class KullaniciRepository:Repository<Kullanici>, IKullaniciRepository
    {
        public IhaleDBContext context { get { return _context as IhaleDBContext; } }
        public KullaniciRepository(IhaleDBContext context) : base(context)
        {

        }

        public async Task<bool> KullaniciVarMi(Kullanici kullanici)
        {
            throw new NotImplementedException();
        }

        public async Task<string> KullaniciRolu(int id)
        {
            string kullaniciRol;
            using (IhaleDBContext db = new IhaleDBContext())
            {
                 kullaniciRol = (from k in db.Kullanicis
                                join r in db.KullaniciRols on k.KullaniciRolId equals r.KullaniciRolId
                                where k.KullaniciId == id
                                select r.Rol).FirstOrDefault();
            }

            return kullaniciRol;
        }
    }
}
