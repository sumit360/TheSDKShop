namespace TheSDKShop.Domain.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public List<Product> Products { get; set; }

        public List<SubCategory> SubCategories { get; set; }
    }
}