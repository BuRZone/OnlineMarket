using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Category;
using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.DAL.Entity;

namespace OnlineMarket.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService; 

        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetCategory() 
        {
            List<CategoryVM> categoryVMList = new List<CategoryVM>();
            var categoryList = await _categoryService.GetAsync().ToListAsync();
            if (categoryList == null)
            {
                return NotFound();
            }

            foreach (var categroy in categoryList)
            {
                CategoryVM categoryVM = new CategoryVM();
                categoryVM.CategoryName = categroy.CategoryName;
                categoryVM.Id = categroy.Id;
                categoryVMList.Add(categoryVM);
            }
            return View(categoryVMList);
        }

        public IActionResult Create()
        {
            CategoryVM categoryVM = new CategoryVM();
            return View(categoryVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryVM category) 
        {
            if (ModelState.IsValid)
            {
                await _categoryService.CreateAsync(category);
                return RedirectToAction("GetCategory");
            }
            return View();
        }

        public async Task <IActionResult> Delete(int? id) 
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = await _categoryService.GetAsync().FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.Delete(id);
            return RedirectToAction("GetCategory");
        }

        public async Task<IActionResult> GetAll(int Id)
        {
            var cat = await _categoryService.GetAsync().Include(x => x.Product).FirstOrDefaultAsync(m => m.Id == Id);
            if (cat == null) 
            {
                return NotFound();
            }
            List<ProductVM> productVMList = new List<ProductVM>();
            foreach (var product in cat.Product)
            {
                ProductVM productVM = new ProductVM();
                productVM.ProductName = product.ProductName;
                productVM.ProductDescription = product.ProductDescription;
                productVM.Price = product.Price;
                productVM.ProductPhoto = product.ProductPhoto;
                productVM.CategoryId = product.CategoryId;
                productVM.Id = product.Id;
                productVM.Quantity = product.Quantity;
                productVMList.Add(productVM);
            }

            CategoryVM categoryVM = new CategoryVM();
            categoryVM.Id = cat.Id;
            categoryVM.CategoryName = cat.CategoryName;
            categoryVM.Product = productVMList;
            
            return View(categoryVM);
        }
    }
}
