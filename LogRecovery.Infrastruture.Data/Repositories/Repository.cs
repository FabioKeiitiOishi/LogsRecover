using LogRecovery.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using LogRecovery.Infrastruture.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using LogRecovery.Domain.Models;

namespace LogRecovery.Infrastruture.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region Properties

        protected readonly LogRecoveryContext _context;
        protected DbSet<TEntity> DbSet
        {
            get
            {
                return _context.Set<TEntity>();
            }
        }

        #endregion
        public Repository(LogRecoveryContext context)
        {
            _context = context;
        }

        #region Create / Remove / Update / Save
        public TEntity Create(TEntity model)
        {
            try
            {
                DbSet.Add(model);
                Save();
                return model;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TEntity> Create(IEnumerable<TEntity> models)
        {
            try
            {
                DbSet.AddRange(models);
                Save();
                return models;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(TEntity model)
        {
            try
            {
                if (model is Entity)
                {
                    (model as Entity).Deleted = true;
                    EntityEntry<TEntity> entry = _context.Entry(model);

                    DbSet.Attach(model);

                    entry.State = EntityState.Modified;
                }
                else
                {
                    EntityEntry<TEntity> entry = _context.Entry(model);

                    DbSet.Attach(model);

                    entry.State = EntityState.Deleted;
                }
                return Save() > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TEntity Find(Expression<Func<TEntity, bool>> where)
        {
            try
            {
                return DbSet.AsNoTracking().FirstOrDefault(where);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> where)
        {
            try
            {
                return DbSet.Where(where);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Save()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(TEntity model)
        {
            try
            {
                EntityEntry<TEntity> entry = _context.Entry(model);
                DbSet.Attach(model);
                entry.State = EntityState.Modified;

                return Save() > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        public void Dispose()
        {
            try
            {
                if (_context != null)
                    _context.Dispose();

                GC.SuppressFinalize(this);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
