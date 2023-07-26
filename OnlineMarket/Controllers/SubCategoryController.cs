using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Category;

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

    }
}
