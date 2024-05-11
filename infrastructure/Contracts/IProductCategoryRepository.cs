using domain.Models;
using domain.RequestFeatures;

namespace infrastructure.Contracts
{
    public interface IProductCategoryRepository : IRepositoryBase<ProductCategory>
    {
        Task<IEnumerable<ProductCategory>> GetAllProductCategoriesAsync(RequestParameters requestParameters, bool trackChanges);
        Task<ProductCategory?> GetProductCategoryByIdAsync(int id, bool trackChanges);
    }
}
