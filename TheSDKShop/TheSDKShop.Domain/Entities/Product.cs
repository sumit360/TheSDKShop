namespace TheSDKShop.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ProductCode { get; set; }

        public int SupplierId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public int CreatedBy { get; set; }

        public int UpdatedBy { get; set; }

        public ProductCategory Category { get; set; }

        public Supplier Supplier { get; set; }

        public List<ProductReview> ProductReviews { get; set; }
    }
}