using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Product;

namespace OnlineMarket.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetProduct()
        {
            var productList = await _productService.GetAsync().ToListAsync();
            return View(productList);
        }

        public async Task <IActionResult> Create()
        {
            var category = await _categoryService.GetAsync().Select(x => new { x.Id, x.CategoryName}).ToListAsync();

            ViewData["Category"] =  new SelectList(category, "Id", "CategoryName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductVM product, byte[]? imageData)
        {

                using (var binaryReader = new BinaryReader(product.ProductformFile.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)product.ProductformFile.Length);
                }

                product.ProductPhoto = imageData;

                await _productService.CreateAsync(product);
                return RedirectToAction("Index", "Home");


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
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _productService.Delete(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
