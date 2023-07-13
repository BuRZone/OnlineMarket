namespace OnlineMarket.DAL.Entity
{

    public  class Order
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public string Address { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}
