using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.BLL.ViewModels.Seller;

namespace OnlineMarket.BLL.ViewModels.Category
{
    public class SubCategoryVM
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public int CategoryId { get; set; }
        public CategoryVM Category { get; set; }
        public IEnumerable<ProductVM>? Product { get; set; }
        public IEnumerable<SellerVM>? Seller { get; set; }
    }
}
