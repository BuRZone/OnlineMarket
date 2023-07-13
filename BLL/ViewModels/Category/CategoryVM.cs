using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.BLL.ViewModels.Seller;
using System.ComponentModel.DataAnnotations;

namespace OnlineMarket.BLL.ViewModels.Category
{
    public class CategoryVM
    {
        public int Id { get; set; }
        [Display(Name = "Название категории")]
        [Required(ErrorMessage = "Введите название")]
        public string CategoryName { get; set; }
        public IEnumerable<ProductVM>? Product { get; set; }
        public IEnumerable<SellerVM>? Seller { get; set; }
    }
}
