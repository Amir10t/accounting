using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Accounting.DataLayer.Services
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private MOAccountingEntities _db;
        private DbSet<TEntity> _dbset;

        public GenericRepository(MOAccountingEntities db)
        {
            _db = db;
            _dbset = _db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _dbset;

            if (where != null)
            {
                query = query.Where(where);
            }

            return query.ToList();
        }

        public virtual TEntity GetById(object Id)
        {
            return _dbset.Find(Id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbset.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _dbset.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached) // هم میتونیم چک کنیم و هم مثل بالا تنها بنویسیم
            {
                _dbset.Attach(entity);
            }
            //_db.Entry(entity).State = EntityState.Deleted;
            _dbset.Remove(entity);
        }

        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
            Delete(entity);
        }
    }
}
}
