using OnlineMarket.BLL.ViewModels.Product;

namespace OnlineMarket.BLL.ViewModels.Basket
{
    public class BasketVM
    {
        public int Id { get; set; }
        public IEnumerable<ProductVM>? Order { get; set; }
        public int UserId { get; set; }
    }
}