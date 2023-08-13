using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Category;

namespace OnlineMarket.Controllers
{
    [Authorize(Roles ="Admin")]
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
            var categoryVMList = new List<CategoryVM>();
            var categoryList = await _categoryService.GetAsync().Select(x => new { x.Id, x.CategoryName }).AsNoTracking().ToListAsync();
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

        public async Task<IActionResult> Create()
        {
            CategoryVM categoryVM = new CategoryVM();
            List<CategoryVM> categoryVMs = new List<CategoryVM>();
            var category = await _categoryService.GetAsync().Select(x => new { x.Id, x.CategoryName }).OrderBy(x => x.CategoryName).ToListAsync();
            foreach (var sub in category)
            {
                CategoryVM subVM = new CategoryVM();
                subVM.CategoryName = sub.CategoryName;
                subVM.Id = sub.Id;
                categoryVMs.Add(subVM);

            }

            ViewData["Category"] = categoryVMs;

            return View(categoryVM);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryVM category)
        {
            CategoryVM categoryVM = new CategoryVM();
            List<CategoryVM> categoryVMs = new List<CategoryVM>();
            var categoryQ = await _categoryService.GetAsync().Select(x => new { x.Id, x.CategoryName }).OrderBy(x => x.CategoryName).ToListAsync();
            foreach (var sub in categoryQ)
            {
                CategoryVM subVM = new CategoryVM();
                subVM.CategoryName = sub.CategoryName;
                subVM.Id = sub.Id;
                categoryVMs.Add(subVM);
            }

            ViewData["Category"] = categoryVMs;

            if (ModelState.IsValid)
            {
                await _categoryService.CreateAsync(category);
                return RedirectToAction("GetCategory");
            }
            return View(categoryVM);
        }

        public async Task<IActionResult> Delete(int? id)
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


    }
}
