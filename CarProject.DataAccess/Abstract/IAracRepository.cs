
using CarProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject.DataAccess.Abstract
{
    public interface IAracRepository:IRepository<Arac>
    {
        string CarPropDetail(int AracId, int detail);
    }
}
