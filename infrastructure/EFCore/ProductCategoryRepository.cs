using domain.Models;
using domain.RequestFeatures;
using infrastructure.Contracts;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.EFCore
{
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(Context context) : base(context)
        {
        }

		public async Task<IEnumerable<ProductCategory>> GetAllProductCategoriesAsync(RequestParameters requestParameters, bool trackChanges)
		{
			var productCategories = await FindAll(trackChanges).ToListAsync();
			var count = productCategories.Count;

			return productCategories
				.Skip((requestParameters.PageNumber - 1) * requestParameters.PageSize)
				.Take(requestParameters.PageSize);
		}

		public async Task<ProductCategory?> GetProductCategoryByIdAsync(int id, bool trackChanges)
		{
			return await FindByCondition(p => p.ProductCategoryId.Equals(id), trackChanges).SingleOrDefaultAsync();
		}
	}
}
