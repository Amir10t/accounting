using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        MOAccountingEntities db = new MOAccountingEntities();

        private GenericRepository<MobileModel> _mobileRepository;

        public GenericRepository<MobileModel> MobileRepository
        {
            get
            {
                if (_mobileRepository == null)
                {
                    _mobileRepository = new GenericRepository<MobileModel>(db);
                }

                return _mobileRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
