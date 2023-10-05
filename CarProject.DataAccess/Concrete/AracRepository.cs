
using CarProject.DataAccess.Abstract;
using CarProject.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CarProject.Core.Entity;

namespace CarProject.DataAccess.Concrete
{
    public class AracRepository : Repository<Arac>, IAracRepository
    {
        public IhaleDBContext context { get { return _context as IhaleDBContext; } }
        public AracRepository(IhaleDBContext context):base(context)
        {
            
        }

        public string CarPropDetail(int AracId, int detail)
        {
            #region sql
            //            select ao.OzellikAd from AracOzellik ao
            //            join AracOzellikDetay ad on ad.AracOzellikID = ao.AracOzellikID
            //            join Arac a on ad.AracId = a.AracId
            //            where a.AracId = 1 and ao.UstOzellikID = 9

            #endregion
            string detailName = "";
            using (IhaleDBContext db = new IhaleDBContext())
            {
                var deger = (from ao in db.AracOzelliks
                             join ad in db.AracOzellikDetays on ao.AracOzellikId equals ad.AracOzellikId
                             join a in db.Aracs on ad.AracId equals a.AracId
                             where a.AracId == AracId && ao.EnUstOzellikId == detail
                             select new { ozellikadi = ao.OzellikAd }).FirstOrDefault();
                detailName = deger == null ? "-" : deger.ozellikadi;
            }

            return detailName;
        }
    }
}
