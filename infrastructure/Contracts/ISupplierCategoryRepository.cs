using domain.Models;
using domain.RequestFeatures;

namespace infrastructure.Contracts
{
    public interface ISupplierCategoryRepository : IRepositoryBase<SupplierCategory>
    {
		Task<IEnumerable<SupplierCategory>> GetAllSupplierCategoriesAsync(RequestParameters requestParameters, bool trackChanges);
		Task<SupplierCategory?> GetSupplierCategoryByIdAsync(int id, bool trackChanges);
	}
}
