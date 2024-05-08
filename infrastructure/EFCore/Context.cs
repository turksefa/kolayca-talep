using domain.Models;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.EFCore
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<SupplierCategory> SupplierCategories { get; set; }
    }
}
