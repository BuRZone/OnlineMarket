using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.Models;
using System.Diagnostics;

namespace OnlineMarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index()
        {

            List<ProductVM> productVMList = new List<ProductVM>();
            var productList = await _productService.GetAsync().ToListAsync();
            if (productList == null)
            {
                return NotFound();
            }
            foreach (var product in productList)
            {
                ProductVM productVM = new ProductVM();
                productVM.ProductName = product.ProductName;
                productVM.ProductDescription = product.ProductDescription;
                productVM.Price = product.Price;
                productVM.ProductPhoto = product.ProductPhoto;
                productVM.SubCategoryId = product.SubCategoryId;
                productVM.Id = product.Id;
                productVM.Quantity = product.Quantity;
                productVMList.Add(productVM);
            }

            return View(productVMList);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}