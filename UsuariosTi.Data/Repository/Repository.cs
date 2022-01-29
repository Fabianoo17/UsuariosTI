using Microsoft.EntityFrameworkCore;
using UsuariosTi.Business.Entities;
using UsuariosTi.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace UsuariosTi.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity>, IDisposable where TEntity : Entity
    {
        protected readonly DbContext DbContext;
        protected readonly DbSet<TEntity> Entities;

        public Repository(DbContext dbContext)
        {
            DbContext = dbContext;
            Entities = DbContext.Set<TEntity>();
        }       

        public virtual IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> expressionSeach, params Expression<Func<TEntity, object>>[] expressionIncludes)
        {
            IQueryable<TEntity> query = Entities as IQueryable<TEntity>;

            foreach (var incluede in expressionIncludes)
            {
                query = query.Include(incluede);
            }

            query = query.Where(expressionSeach);

            return query.ToList();
        }

        public virtual TEntity GetOne(Expression<Func<TEntity, bool>> expressionSeach, params Expression<Func<TEntity, object>>[] expressionIncludes)
        {
            IQueryable<TEntity> query = Entities as IQueryable<TEntity>;

            foreach (var include in expressionIncludes)
            {
                query = query.Include(include);
            }

            return query.FirstOrDefault(expressionSeach);
        }

        public virtual void Insert(TEntity obj)
        {
            Entities.Add(obj);
            DbContext.SaveChanges();
        }

        public virtual void Remove(int Id)
        {
            var item = Entities.Find(Id);
            Entities.Remove(item);
            SaveChange();
        }

        public virtual void Update(TEntity obj)
        {
            Entities.Update(obj);
            SaveChange();
        }

        public void SaveChange()
        {
            DbContext.SaveChanges();
        }

        public void Dispose()
        {
            DbContext.Dispose();
        }
    }
}
