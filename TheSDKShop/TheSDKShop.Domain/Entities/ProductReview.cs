namespace TheSDKShop.Domain.Entities
{
    public class ProductReview
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public Product Product { get; set; }

        public User User { get; set; }
    }
}