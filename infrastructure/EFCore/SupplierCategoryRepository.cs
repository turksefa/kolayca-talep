using domain.Models;
using domain.RequestFeatures;
using infrastructure.Contracts;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.EFCore
{
    public class SupplierCategoryRepository : RepositoryBase<SupplierCategory>, ISupplierCategoryRepository
    {
        public SupplierCategoryRepository(Context context) : base(context)
        {
        }

		public async Task<IEnumerable<SupplierCategory>> GetAllSupplierCategoriesAsync(RequestParameters requestParameters, bool trackChanges)
		{
			var supplierCategories = await FindAll(trackChanges).ToListAsync();
			var count = supplierCategories.Count;

			return supplierCategories
				.Skip((requestParameters.PageNumber - 1) * requestParameters.PageSize)
				.Take(requestParameters.PageSize);
		}

		public async Task<SupplierCategory?> GetSupplierCategoryByIdAsync(int id, bool trackChanges)
		{
			return await FindByCondition(s => s.SupplierCategoryId.Equals(id), trackChanges).SingleOrDefaultAsync();
		}
	}
}
