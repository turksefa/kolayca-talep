using domain.RequestFeatures;
using infrastructure.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace infrastructure.EFCore
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
        where T : class
    {
        private readonly Context _context;

        protected RepositoryBase(Context context)
        {
            _context = context;
        }

        public void Create(T entity) => _context.Set<T>().Add(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);

        public IQueryable<T> FindAll(bool trackChanges) => trackChanges ?
            _context.Set<T>() :
            _context.Set<T>().AsNoTracking();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) => trackChanges ?
            _context.Set<T>().Where(expression) :
            _context.Set<T>().Where(expression).AsNoTracking();

        public void Update(T entity) => _context.Set<T>().Update(entity);
    }
}
