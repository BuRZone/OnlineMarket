using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Order;
using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.DAL.Entity;

namespace OnlineMarket.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        public BasketController(IBasketService basketService, IProductService productService, IOrderService orderService)
        {
            _basketService = basketService;
            _productService = productService;
            _orderService = orderService;

        }

        public async Task<IActionResult> AddToCart(int? id)
        {

            var productQ = await _productService.GetAsync().FirstOrDefaultAsync(x => x.Id == id);
            if (productQ == null)
            {
                return NotFound();
            }
            ProductVM productVM = new ProductVM();
            productVM.ProductName = productQ.ProductName;
            productVM.ProductDescription = productQ.ProductDescription;
            productVM.Price = productQ.Price;
            productVM.ProductPhoto = productQ.ProductPhoto;
            productVM.SubCategoryId = productQ.SubCategoryId;
            productVM.Id = productQ.Id;
            productVM.Quantity = productQ.Quantity;


            var basketQ = await _basketService.GetAsync().Include(x => x.User).FirstOrDefaultAsync(x => x.User.UserName == User.Identity.Name);
            OrderVM orderVM = new OrderVM()
            {
                ProductVM = productVM,
                BasketVMId = basketQ.Id,
                DateCreated = DateTime.Now
            };
            await _orderService.CreateAsync(orderVM);

            return RedirectToAction("GetProduct", "Product");
        }


        public async Task<IActionResult> Get()
        {
            var productVMList = new List<ProductVM>();

            var basketQ = await _basketService.GetAsync().Include(x => x.Order).ThenInclude(x => x.Product).
                FirstOrDefaultAsync(x => x.User.UserName == User.Identity.Name);
            var productQ = basketQ.Order.Select(x => x.Product);


            foreach (var product in productQ)
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

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var OrderQ = await _orderService.GetAsync().Include(x => x.Product).FirstOrDefaultAsync(x => x.Id == id);
            if (OrderQ == null) 
            {
                return NotFound();
            }
            ProductVM productVM = new ProductVM()
            {
                ProductName = OrderQ.Product.ProductName,
                ProductDescription = OrderQ.Product.ProductDescription,
                Price = OrderQ.Product.Price,
                ProductPhoto = OrderQ.Product.ProductPhoto,
                SubCategoryId = OrderQ.Product.SubCategoryId,
                Id = OrderQ.Product.Id,
                Quantity = OrderQ.Product.Quantity
            };

            return View(productVM);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var order = await _orderService.GetAsync().Include(x => x.Product).FirstOrDefaultAsync(x => x.Id == id);
            if (order == null) 
            {
                return NotFound();
            }
            await _orderService.Delete(order);
            return RedirectToAction("Index", "Home");
        }

    }
}
