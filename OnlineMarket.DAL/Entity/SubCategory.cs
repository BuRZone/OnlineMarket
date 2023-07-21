namespace OnlineMarket.DAL.Entity
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Product>? Product { get; set; }
        public IEnumerable<Seller>? Seller { get; set; }
    }
}
