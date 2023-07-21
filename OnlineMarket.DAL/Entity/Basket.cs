namespace OnlineMarket.DAL.Entity
{
    public class Basket
    {
        public int BasketId { get; set; }
        public IEnumerable<Order>? Order { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
