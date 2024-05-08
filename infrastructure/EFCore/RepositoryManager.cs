using domain.Models;
using infrastructure.Contracts;

namespace infrastructure.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Context _context;
        private readonly Lazy<IProductCategoryRepository> _productCategoryRepository;
        private readonly Lazy<ISupplierCategoryRepository> _supplierCategoryRepository;

        public RepositoryManager(Context context)
        {
            _context = context;
            _productCategoryRepository = new Lazy<IProductCategoryRepository>(() => new ProductCategoryRepository(_context));
            _supplierCategoryRepository = new Lazy<ISupplierCategoryRepository>(() => new SupplierCategoryRepository(_context));
        }

        public IProductCategoryRepository ProductCategoryRepository => _productCategoryRepository.Value;
        public ISupplierCategoryRepository SupplierCategoryRepository => _supplierCategoryRepository.Value;

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
