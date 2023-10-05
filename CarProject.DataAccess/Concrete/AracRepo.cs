using CarProject.Core.Entity;
using CarProject.DataAccess.Abstract;
using CarProject.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarProject.DataAccess.Concrete
{
    public class AracRepo:Repo<Arac,IhaleDBContext>, IAracRepo
    {
    }
}
