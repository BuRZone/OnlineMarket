using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.DAL.Entity;
using OnlineMarket.Models;
using System.Diagnostics;
using System.Drawing.Printing;

namespace OnlineMarket.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public int PageNumber { get; set; }
  
        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index(int? scrolled, int pageNumber=1)
        {
            List<ProductVM> productVMList = new List<ProductVM>();
            const int PageSize = 12;
            int recsCount = _productService.GetAsync().Count();
            var pager = new Pager(recsCount, pageNumber, PageSize*2);
            this.ViewBag.Pager = pager;

            int scrollPage = scrolled ?? 0;
            int itemsToSkip = (pageNumber -1) * PageSize;
            PageNumber = pageNumber;


            if (scrollPage < 2 && PageNumber == 1)
            {
                itemsToSkip = scrollPage * PageSize;
                var productList = await _productService.GetAsync().OrderBy(x => x.Id).Skip(itemsToSkip).Take(PageSize).ToListAsync();
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
            else if (scrollPage < 2 && PageNumber != 1)
            {

                scrollPage = scrolled == null ? 0 : PageSize;
                var i = PageNumber;


                itemsToSkip = scrollPage + 2 * PageSize * (i - 1);
                var productList = await _productService.GetAsync().OrderBy(x => x.Id).Skip(itemsToSkip).Take(PageSize).ToListAsync();
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

            else return View();
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