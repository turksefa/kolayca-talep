using application.Contracts;
using AutoMapper;
using infrastructure.Contracts;

namespace application
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductCategoryService> _productCategoryService;
        private readonly Lazy<ISupplierCategoryService> _supplierCategoryService;
        public ServiceManager(IRepositoryManager manager, IMapper mapper)
        {
            _productCategoryService = new Lazy<IProductCategoryService>(() => new ProductCategoryManager(manager, mapper));
            _supplierCategoryService = new Lazy<ISupplierCategoryService>(() => new SupplierCategoryManager(manager, mapper));
        }

        public IProductCategoryService ProductCategoryService => _productCategoryService.Value;

        public ISupplierCategoryService SupplierCategoryService => _supplierCategoryService.Value;
    }
}
