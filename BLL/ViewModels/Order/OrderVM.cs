using OnlineMarket.BLL.ViewModels.Basket;
using OnlineMarket.BLL.ViewModels.Product;

namespace OnlineMarket.BLL.ViewModels.Order
{
    public class OrderVM
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public int ProductVMId { get; set; }
        public ProductVM Product { get; set; }
        public int BasketVMId { get; set; }
        public BasketVM Basket { get; set; }
    }
}
