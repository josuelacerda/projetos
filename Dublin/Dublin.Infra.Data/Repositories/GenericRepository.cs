using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Dublin.Domain.Interfaces.Repositories;
using Dublin.Infra.Data.Context;

namespace Dublin.Infra.Data.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class, IDisposable
    {
        private readonly DataContext _context = new DataContext();
        public T Add(T obj)
        {
            return _context.Set<T>().Add(obj);
        }

        public IQueryable<T> Get(Expression<Func<T,bool>>predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
           return _context.Set<T>();
        }

        public T Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            return obj;
        }

        public T Delete(T obj)
        {
            return _context.Set<T>().Remove(obj);
        }

        public T Delete(int id)
        {
            var obj = _context.Set<T>().Find(id);
            return obj == null ? null : _context.Set<T>().Remove(obj);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
