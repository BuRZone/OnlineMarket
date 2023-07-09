using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.DAL.Entity
{
    public enum OrderStatus
    {
        AwaitingPayment,
        Paied,
        InProgress,
        Shipped,
        Сancelled

    }
    public class Basket
    {
        public int Id { get; set; }
        public OrderStatus Status { get; set; }
        IEnumerable<Product> Product { get; set; }
        public User User { get; set; }
    }
}
