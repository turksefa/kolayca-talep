using domain.Dtos;
using domain.RequestFeatures;

namespace application.Contracts
{
    public interface IProductCategoryService
    {
        Task<IEnumerable<ProductCategoryDto>> GetAllProductCategoriesAsync(RequestParameters requestParameters, bool trackChanges);
        Task<ProductCategoryDto> GetProductCategoryByIdAsync(int id, bool trackChanges);
        Task CreateProductCategoryAsync(ProductCategoryDto productCategoryDto);
        Task UpdateProductCategoryAsync(ProductCategoryDto productCategoryDto);
        Task DeleteProductCategoryAsync(int id, bool trackChanges);
    }
}
