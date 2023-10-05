using CarProject.Core.Entity;
using CarProject.DataAccess.Abstract;
using CarProject.DataAccess.DataAccess;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Concrete
{
    public class StatusRepository:Repository<Statu>, IStatusRepository
    {
        public IhaleDBContext context { get { return _context as IhaleDBContext; } }
        public StatusRepository(IhaleDBContext context) : base(context)
        {

        }

        public async Task<string> GetStatusAsync(int id)
        {
            string secilenStatu = "";
            #region sql

            //select s.Statusu from statu s
            //join AracStatuDetay asd on s.StatuID = asd.StatuID
            //join Arac a on asd.AracId = a.AracID
            //where a.AracID = 1

            #endregion
            using (IhaleDBContext db = new IhaleDBContext())
            {
                var donen = (from s in db.Status
                             join asd in db.AracStatuDetays on s.StatuId equals asd.StatuId
                             join a in db.Aracs on asd.AracId equals a.AracId
                             where a.AracId == id
                             select new { statu = s.Statusu }).FirstOrDefault();
                secilenStatu = donen == null ? "-" : donen.statu;
            }
            return secilenStatu;
        }
    }
}
