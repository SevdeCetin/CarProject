using CarProject.Core.Entity;
using CarProject.DataAccess.Abstract;
using CarProject.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CarProject.DataAccess.Concrete
{
    public class FotografRepository:Repository<Fotograf>, IFotografRepository
    {
        public IhaleDBContext context { get { return _context as IhaleDBContext; } }
        public FotografRepository(IhaleDBContext context) : base(context)
        {

        }

        public async Task<IEnumerable<string>> Fotograflar(int id)
        {
           
            using (IhaleDBContext db = new IhaleDBContext())
            {
                return await db.Fotografs.Where(x => x.AracId == id).Select(a=>a.Fotograf1).ToListAsync();
            }
        }
    }
}
