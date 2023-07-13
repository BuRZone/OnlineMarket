using OnlineMarket.BLL.ViewModels.Category;
using OnlineMarket.DAL.Entity;

namespace OnlineMarket.BLL.Service.Interfaces
{
    public interface ICategoryService
    {
        IQueryable<Category> GetAsync();
        Task CreateAsync(CategoryVM category);
        Task UpdateAsync(int? id);
        Task Delete(int? id);
    }
}
