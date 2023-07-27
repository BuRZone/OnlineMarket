using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Category;

namespace OnlineMarket.Components
{
    [ViewComponent]
    public class CategoryViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoryViewComponent(ICategoryService catetogyService)
        {
            _categoryService = catetogyService;
        }

        public List<CategoryVM> categoryVMList = new List<CategoryVM>();

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categoryList = await _categoryService.GetAsync().Include(x => x.SubCategory).ToListAsync();

            foreach (var categroy in categoryList)
            {
                CategoryVM categoryVM = new CategoryVM();
                categoryVM.CategoryName = categroy.CategoryName;
                categoryVM.Id = categroy.Id;
                categoryVMList.Add(categoryVM);
            }



            return View("CategoryViewComponent", categoryVMList);
        }

    }
}
