using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.DAL.Entity
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }
        public IEnumerable<Order>? Order { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
