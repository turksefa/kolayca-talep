using domain.Dtos;
using domain.RequestFeatures;

namespace application.Contracts
{
    public interface ISupplierCategoryService
    {
        Task<IEnumerable<SupplierCategoryDto>> GetAllSupplierCategoriesAsync(RequestParameters requestParameters, bool trackChanges);
        Task<SupplierCategoryDto> GetSupplierCategoryByIdAsync(int id, bool trackChanges);
        Task CreateSupplierCategoryAsync(SupplierCategoryDto supplierCategoryDto);
        Task UpdateSupplierCategoryAsync(SupplierCategoryDto supplierCategoryDto);
        Task DeleteSupplierCategoryAsync(int id, bool trackChanges);
    }
}
