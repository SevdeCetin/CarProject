using CarProject.Core.Entity;
using CarProject.DataAccess.Abstract;
using CarProject.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Concrete
{
    public class AracOzellikRepository:Repository<AracOzellik>, IAracOzellikRepository
    {
        public IhaleDBContext context { get { return _context as IhaleDBContext; } }
        public AracOzellikRepository(IhaleDBContext context) : base(context)
        {

        }

        public Task<bool> AracOzellikEkle(int aracID, int ozellikID)
        {
            throw new NotImplementedException();
        }

        public async Task<string> OzellikAdGetir(string ozellik)
        {
            int oz = Int32.Parse(ozellik);
            using (IhaleDBContext db= new IhaleDBContext())
            {
               var deger=  db.AracOzelliks.Find(oz);
                return deger.OzellikAd;
            }
        }
    }
}
