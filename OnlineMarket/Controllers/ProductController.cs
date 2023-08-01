using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using OnlineMarket.BLL.Service.Implementations;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Product;

namespace OnlineMarket.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IBasketService _basketService;
        public ProductController(IProductService productService, ICategoryService categoryService, IBasketService basketService)
        {
            _productService = productService;
            _categoryService = categoryService;
            _basketService = basketService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetProduct()
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


        public async Task<IActionResult> Create()
        {
            ProductVM productVM = new ProductVM();
            var category = await _categoryService.GetAsync().Select(x => new { x.Id, x.CategoryName }).ToListAsync();

            ViewData["Category"] = new SelectList(category, "Id", "CategoryName");

            return View(productVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductVM productVM, byte[]? imageData)
        {
            ProductVM prod = new ProductVM();
            var category = await _categoryService.GetAsync().Select(x => new { x.Id, x.CategoryName }).ToListAsync();

            ViewData["Category"] = new SelectList(category, "Id", "CategoryName");

            if (productVM.Price == default)
            {
                ModelState.AddModelError("Price", "укажите стомость");

            }
            if (productVM.Quantity == default)
            {
                ModelState.AddModelError("Quantity", "укажите количество");
            }
            if (ModelState.IsValid)
            {
                using (var binaryReader = new BinaryReader(productVM.ProductformFile.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)productVM.ProductformFile.Length);
                }

                productVM.ProductPhoto = imageData;

                await _productService.CreateAsync(productVM);
                return RedirectToAction("Index", "Home");
            }

            return View(prod);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _productService.GetAsync().FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            ProductVM productVM = new ProductVM();
            productVM.ProductName = product.ProductName;
            productVM.ProductDescription = product.ProductDescription;
            productVM.Price = product.Price;
            productVM.ProductPhoto = product.ProductPhoto;
            productVM.SubCategoryId = product.SubCategoryId;
            productVM.Id = product.Id;
            productVM.Quantity = product.Quantity;

            return View(productVM);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.Delete(id);
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        public async Task<IActionResult> SearchProduct(string searchString)
        {
            var productVMList = new List<ProductVM>();
            var searchQ = await _productService.GetAsync().Where(x => x.ProductName.Contains(searchString)).Select(x => x).ToListAsync();
            if (searchQ.Count() == 0)
            {
                
                TempData["null"] = "ничего не найдено";
                return View(productVMList);
            }

            foreach (var product in searchQ)
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

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _productService.GetAsync().FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            ProductVM productVM = new ProductVM();
            productVM.ProductName = product.ProductName;
            productVM.ProductDescription = product.ProductDescription;
            productVM.Price = product.Price;
            productVM.ProductPhoto = product.ProductPhoto;
            productVM.SubCategoryId = product.SubCategoryId;
            productVM.Id = product.Id;
            productVM.Quantity = product.Quantity;

            return View(productVM);
        }
    }
}
