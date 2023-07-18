using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.DAL.Entity;

namespace OnlineMarket.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
            
        }
        public async Task<IActionResult> Get(int id)
        {
            List<ProductVM> productList = new List<ProductVM>();


            var productQ = await _basketService.GetAsync().Include(x => x.Product).FirstOrDefaultAsync(x => x.Id == id);

            if (productQ != null)
            {
                foreach (var product in productQ.Product)
                {
                    ProductVM productVM = new ProductVM()
                    {
                        Id = product.Id,
                        ProductName = product.ProductName,
                        ProductDescription = product.ProductDescription,
                        Price = product.Price,
                        Quantity = product.Quantity,
                        ProductPhoto = product.ProductPhoto,
                        CategoryId = product.CategoryId
                    };
                    productList.Add(productVM);
                }

                return View(productList);
            }
            return View(productList);
        }
    }
}
