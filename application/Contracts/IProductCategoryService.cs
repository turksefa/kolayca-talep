using domain.Dtos;

namespace application.Contracts
{
    public interface IProductCategoryService
    {
        Task<IEnumerable<ProductCategoryDto>> GetAllProductCategoryAsync(bool trackChanges);
        Task<ProductCategoryDto> GetProductCategoryByIdAsync(int id, bool trackChanges);
        Task CreateProductCategoryAsync(ProductCategoryDto productCategoryDto);
        Task UpdateProductCategoryAsync(ProductCategoryDto productCategoryDto);
        Task DeleteProductCategoryAsync(int id, bool trackChanges);
    }
}
