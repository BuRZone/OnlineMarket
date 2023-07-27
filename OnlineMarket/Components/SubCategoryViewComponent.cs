using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Category;

namespace OnlineMarket.Components
{
    public class SubCategoryViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public SubCategoryViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public List<SubCategoryVM> subCategoryVMList = new List<SubCategoryVM>();
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var categoryQ = await _categoryService.GetAsync().Include(x => x.SubCategory).FirstOrDefaultAsync(x => x.Id == id);

            foreach (var subCategroy in categoryQ.SubCategory)
            {
                SubCategoryVM subCtegoryVM = new SubCategoryVM()
                {
                    CategoryName = subCategroy.CategoryName,
                    Id = subCategroy.Id,
                };
                subCategoryVMList.Add(subCtegoryVM);
            }

            return View("SubCategoryViewComponent", subCategoryVMList);
        }
    }
}
