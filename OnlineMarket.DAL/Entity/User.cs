using OnlineMarket.DAL.Enum;
using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.DAL.Entity
{

    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; } = Role.User;
        public decimal? Balance { get; set; }
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
        public Seller? Seller { get; set; }
        public decimal? Purchase { get; set; }

    }
}
