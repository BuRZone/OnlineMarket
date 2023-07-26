using OnlineMarket.BLL.ViewModels.Category;
using OnlineMarket.DAL.Entity;

namespace OnlineMarket.BLL.Service.Interfaces
{
    public interface ISubCategoryService
    {
        IQueryable<SubCategory> GetAsync();
        Task CreateAsync(SubCategoryVM category);
        Task UpdateAsync(int? id);
        Task Delete(int? id);
    }
}
