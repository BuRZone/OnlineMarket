using Microsoft.AspNetCore.Http;
using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.BLL.ViewModels.Seller;
using OnlineMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
