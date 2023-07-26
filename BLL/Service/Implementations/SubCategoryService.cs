using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Category;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.BLL.Service.Implementations
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ILogger<SubCategoryService> _logger;
        private readonly IBaseRepository<SubCategory> _repository;

        public SubCategoryService(ILogger<SubCategoryService> logger, IBaseRepository<SubCategory> repository)
        {
            _logger = logger;
            _repository = repository;
        }
        public async Task CreateAsync(SubCategoryVM subCategory)
        {
            try
            {
                var categoryQ = await _repository.GetAsync().FirstOrDefaultAsync(p => p.CategoryName.Equals(subCategory.CategoryName));
                if (categoryQ == null)
                {
                    var cat = new SubCategory()
                    {
                        CategoryName = subCategory.CategoryName

                    };
                    await _repository.CreateAsync(cat);

                    _logger.LogInformation($"[SubCategoryService.CreateAsync] создана новая категория {cat.CategoryName}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[SubCategoryService.CreateAsync] error: {ex.Message}");
            }
        }

        public async Task Delete(int? id)
        {
            try
            {
                var categoryQ = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);

                if (categoryQ != null)
                {
                    await _repository.Delete(categoryQ);
                    _logger.LogInformation($"[CategroyService.Delete] категория удалена {categoryQ}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[CategoryService.Delete] error: {ex.Message}");
            }
        }

        public IQueryable<SubCategory> GetAsync()
        {

            return _repository.GetAsync();
        }

        public async Task UpdateAsync(int? id)
        {
            try
            {
                var categoryQ = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);
                if (categoryQ != null)
                {
                    await _repository.UpdateAsync(categoryQ);

                    _logger.LogInformation($"[SubCategoryService.UpdateAsync] категория обновлена {categoryQ.CategoryName}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[SubCategoryService.UpdateAsync] error: {ex.Message}");
            }
        }
    }
}
