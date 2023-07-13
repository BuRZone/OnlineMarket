using Microsoft.AspNetCore.Http;
using OnlineMarket.BLL.ViewModels.Category;
using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.BLL.ViewModels.User;
using OnlineMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.ViewModels.Seller
{
    public class SellerVM
    {
        public int Id { get; set; }
        public string SellerName { get; set; }
        public string SellerDescription { get; set; }
        public IEnumerable<Payment> Payment { get; set; }
        public int UserId { get; set; }
        public UserVM User { get; set; }
        public IEnumerable<CategoryVM> Category { get; set; }
        public IEnumerable<ProductVM> Product { get; set; }
        [NotMapped]
        public IFormFile? SellerformFile { get; set; }
        public byte[]? SellerPhoto { get; set; }
    }
}
