using Microsoft.EntityFrameworkCore;

namespace TheSDKShop.Infrastructure.Database.Interfaces
{
    public class ISDKShopContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductReview> ProductReviews { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<User> Users { get; set; }
    }
}