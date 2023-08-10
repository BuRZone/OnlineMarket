using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.DAL.Entity
{

    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
    }
}
