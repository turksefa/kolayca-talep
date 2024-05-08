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

        public async Task<IEnumerable<T>> FindAllAsync(bool trackChanges) => trackChanges ?
            await _context.Set<T>().ToListAsync() :
            await _context.Set<T>().AsNoTracking().ToListAsync();

        public async Task<T?> FindByCondititonAsync(Expression<Func<T, bool>> expression, bool trackChanges) => trackChanges ?
            await _context.Set<T>().Where(expression).SingleOrDefaultAsync() :
            await _context.Set<T>().Where(expression).AsNoTracking().SingleOrDefaultAsync();

        public void Update(T entity) => _context.Set<T>().Update(entity);
    }
}
