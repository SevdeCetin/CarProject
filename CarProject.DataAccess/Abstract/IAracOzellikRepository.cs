using CarProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Abstract
{
    public interface IAracOzellikRepository : IRepository<AracOzellik>
    {
        Task<bool> AracOzellikEkle(int aracID, int ozellikID);
        Task<string> OzellikAdGetir(string ozellik);
    }
}
