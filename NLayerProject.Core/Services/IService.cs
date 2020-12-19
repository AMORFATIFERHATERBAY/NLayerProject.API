using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NLayerProject.Core.Services
{
    public interface IService<TEntity> where TEntity :class
    {
        Task<TEntity> GetByIdAsycn(int Id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        // category.SingleOrDefaultAsync(x=> x.Name=="Kalem")
        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> AddAsync(TEntity entity);

        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);

        void RemoveRange(TEntity entities);

        TEntity Update(TEntity entity);
    }
}
