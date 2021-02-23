using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // generic constraint
    // class : reference type
    
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        // to all data
        List<T> GetAll(Expression<Func<T, bool>> filter =null);
        // to specific one data
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
