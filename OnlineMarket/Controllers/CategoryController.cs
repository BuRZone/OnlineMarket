using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
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

        public IActionResult GetCategory() 
        {
            var categoryList = new List<Category>(_categoryService.GetAsync());
            return View(categoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category) 
        {
            await _categoryService.CreateAsync(category);
            return RedirectToAction("GetCategory");
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
    }
}
