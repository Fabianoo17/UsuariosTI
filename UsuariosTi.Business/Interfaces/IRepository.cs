using Corretora.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Corretora.Business.Interfaces
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Remove(int Id);
        TEntity GetOne(Expression<Func<TEntity, bool>> expressionSeach, params Expression<Func<TEntity, object>>[] expressionIncludes);
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> expressionSeach, params Expression<Func<TEntity, object>>[] expressionIncludes);
    }
}
