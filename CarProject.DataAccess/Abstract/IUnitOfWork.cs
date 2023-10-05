using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.DataAccess.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
       IAracRepository AracRepository { get; }
       IStatusRepository StatusRepository { get; }
        IKullaniciRepository KullaniciRepository { get; }
        IAracOzellikRepository AracOzellikRepository { get; }
        IFotografRepository FotografRepository { get; }
        Task<int> Complete();
    }
}
