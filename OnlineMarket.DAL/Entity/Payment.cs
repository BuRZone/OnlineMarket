namespace OnlineMarket.DAL.Entity
{
    public class Payment
    {
        public int Id { get; set; }
        public string PaymentDescription { get; set; }
        public decimal PaymentPrice { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        public bool IsApproved { get; set; }
    }
}
