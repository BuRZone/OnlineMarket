namespace OnlineMarket.DAL.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Seller> Seller { get; set; }
        public byte[]? ProductPhoto { get; set; }
    }
}
