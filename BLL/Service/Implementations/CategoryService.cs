using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Category;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;
using OnlineMarket.DAL.MongoRepositories;
using OnlineMarket.DAL.SQLRepositories;

namespace OnlineMarket.BLL.Service.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly ILogger<CategoryService> _logger;
        private readonly IBaseRepository<Category> _repository;

        public CategoryService(ILogger<CategoryService> logger, IBaseRepository<Category> repository)
        {
            _logger = logger;
            _repository = repository;
        }
        public async Task CreateAsync(CategoryVM category)
        {
            try
            {
                var categoryQ = await _repository.GetAsync().FirstOrDefaultAsync(p => p.CategoryName.Equals(category.CategoryName));
                if (categoryQ == null)
                {
                    var cat = new Category()
                    {
                        CategoryName = category.CategoryName

                    };
                    await _repository.CreateAsync(cat);
                    _logger.LogInformation($"[CategoryService.CreateAsync] создана новая категория {cat.CategoryName}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[CategoryService.CreateAsync] error: {ex.Message}");
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

        public IQueryable<Category> GetAsync()
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

                    _logger.LogInformation($"[CategoryService.UpdateAsync] категория обновлена {categoryQ.CategoryName}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[CategoryService.UpdateAsync] error: {ex.Message}");
            }
        }

    }
}
