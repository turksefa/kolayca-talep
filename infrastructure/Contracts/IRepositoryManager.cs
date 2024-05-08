namespace infrastructure.Contracts
{
    public interface IRepositoryManager
    {
        IProductCategoryRepository ProductCategoryRepository { get; }
        ISupplierCategoryRepository SupplierCategoryRepository { get; }
        Task SaveAsync();
    }
}
