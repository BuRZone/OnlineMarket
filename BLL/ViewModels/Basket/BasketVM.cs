using OnlineMarket.BLL.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.ViewModels.Basket
{
    public class BasketVM
    {
        public int Id { get; set; }
        public IEnumerable<ProductVM>? Products { get; set; }
        public int UserId { get; set; }
    }
}
