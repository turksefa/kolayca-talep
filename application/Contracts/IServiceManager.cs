namespace application.Contracts
{
    public interface IServiceManager
    {
        IProductCategoryService ProductCategoryService { get; }
        ISupplierCategoryService SupplierCategoryService { get; }
    }
}
