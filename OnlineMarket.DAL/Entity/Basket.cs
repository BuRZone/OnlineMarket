using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
