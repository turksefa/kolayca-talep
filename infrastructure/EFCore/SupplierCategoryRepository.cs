using domain.Models;
using infrastructure.Contracts;

namespace infrastructure.EFCore
{
    public class SupplierCategoryRepository : RepositoryBase<SupplierCategory>, ISupplierCategoryRepository
    {
        public SupplierCategoryRepository(Context context) : base(context)
        {
        }
    }
}
