using System;
using System.Linq;
using System.Linq.Expressions;

namespace Dublin.Domain.Interfaces.Repositories
{
    public interface IGenericRepository<T>  where T : class
    {
        T Add(T obj);
        IQueryable<T> Get(Expression<Func<T,bool>> predicate);
        IQueryable<T> GetAll();
        T Update(T obj);
        T Delete(T obj);
        T Delete(int id);
        void Save();
        void Dispose();
    }
}
