using System.Linq.Expressions;

namespace infrastructure.Contracts
{
    public interface IRepositoryBase<T>
    {
        Task<IEnumerable<T>> FindAllAsync(bool trackChanges);
        Task<T?> FindByCondititonAsync(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
