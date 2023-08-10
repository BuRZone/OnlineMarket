using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.DAL.Entity
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }
        public string? SellerName { get; set; }
        public string? SellerDescription { get; set; }
        public IEnumerable<Payment>? Payment { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<SubCategory>? SubCategory { get; set; }
        public IEnumerable<Product>? Product { get; set; }
        public byte[]? SellerPhoto { get; set; }
    }
}
