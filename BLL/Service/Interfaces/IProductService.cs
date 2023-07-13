using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.DAL.Entity;

namespace OnlineMarket.BLL.Service.Interfaces
{
    public interface IProductService
    {
        IQueryable<Product> GetAsync();
        Task CreateAsync(ProductVM product);
        Task UpdateAsync(int? id);
        Task Delete(int? id);
    }
}
