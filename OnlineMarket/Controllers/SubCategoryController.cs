using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Category;
using OnlineMarket.BLL.ViewModels.Product;

namespace OnlineMarket.Controllers
{
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryService _subCategoryService;
        private readonly ICategoryService _categoryService;
        public SubCategoryController(ISubCategoryService subCategoryService, ICategoryService categoryService)
        {
            _subCategoryService = subCategoryService;
            _categoryService = categoryService;
        }

        public IActionResult GetSubCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            List<SubCategoryVM> subCategoryVMList = new List<SubCategoryVM>();
            return View(subCategoryVMList);
        }

        [HttpPost]
        public async Task<IActionResult> GetSubCategory(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var subCatVMList = new List<SubCategoryVM>();

            var categoryQ = await _categoryService.GetAsync().Include(x => x.SubCategory).FirstOrDefaultAsync(x => x.Id == id);

            foreach (var subCat in categoryQ.SubCategory)
            {
                SubCategoryVM subCategoryVM = new SubCategoryVM()
                {
                    Id = subCat.Id,
                    CategoryName = subCat.CategoryName
                };
                subCatVMList.Add(subCategoryVM);
            }

            return View(subCatVMList);
        }
        public async Task<IActionResult> GetProductsFromSubCategory(int Id)
        {
            var subCat = await _subCategoryService.GetAsync().Include(x => x.Product).FirstOrDefaultAsync(m => m.Id == Id);
            if (subCat == null)
            {
                return NotFound();
            }
            var productVMList = new List<ProductVM>();

            foreach (var product in subCat.Product)
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

    }
}
