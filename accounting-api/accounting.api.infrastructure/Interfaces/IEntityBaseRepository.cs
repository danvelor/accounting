using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace accounting.api.infrastructure.Interfaces
{
    public interface IEntityBaseRepository<T>
    {
        void Add(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
        void Commit();
    }
}
