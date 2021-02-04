using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LogRecovery.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Create(TEntity model);
        IEnumerable<TEntity> Create(IEnumerable<TEntity> models);
        bool Update(TEntity model);
        bool Delete(TEntity model);
        int Save();
        TEntity Find(params object[] keys);
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where);
    }
}
