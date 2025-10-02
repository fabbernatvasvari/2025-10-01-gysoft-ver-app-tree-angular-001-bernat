using MyApp.Backend.Responses;
using MyApp.Backend.Datas.Entities;
using System.Linq.Expressions;

namespace MyApp.Backend.Repo.Base
{
    public interface IBaseRepo<TEntity> where TEntity : class, IDbEntity<TEntity>, new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression);
        Task<TEntity?> GetByIdAsync(Guid id);
        Task<Response> CreateAsync(TEntity entity);
        Task<Response> UpdateAsync(TEntity entity);
        Task<Response> DeleteAsync(Guid id);
    }
}
