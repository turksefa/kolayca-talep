using domain.Models;
using infrastructure.Contracts;

namespace infrastructure.EFCore
{
    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(Context context) : base(context)
        {
        }
    }
}
