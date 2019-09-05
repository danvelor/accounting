using accounting.api.infrastructure.Data;
using accounting.api.infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace accounting.api.infrastructure.Repositories
{
    public class EntityBaseRepository<T>: IEntityBaseRepository<T>
        where T : class, new()
    {
            public accountingContext Context { get; set; }

            #region Constructor

            public EntityBaseRepository(accountingContext context)
            {
                Context = context;
            }
            #endregion
            #region Functions
            public virtual void Add(T entity)
            {
                var entitySet = Context.Set<T>();
                entitySet.Add(entity);
            }
            public virtual IQueryable<T> GetAll()
            {
                var entitySet = Context.Set<T>();
                return entitySet.AsQueryable();
            }
            public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
            {
                return GetAll().Where(predicate);
            }
            public virtual void Commit()
            {
                Context.SaveChanges();
            }

            #endregion
    }
}
