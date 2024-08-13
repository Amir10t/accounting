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
        Accounting_DBEntities db = new Accounting_DBEntities();

        private GenericRepository<Product> _productRepository;

        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new GenericRepository<Product>(db);
                }
                return _productRepository;
            }
        }

        private GenericRepository<Order> _orderRepository;

        public GenericRepository<Order> OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new GenericRepository<Order>(db);
                }

                return _orderRepository;
            }
        }

        private GenericRepository<User> _userRepository;

        public GenericRepository<User> UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new GenericRepository<User>(db);
                }

                return _userRepository;
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
