using OnlineMarket.BLL.ViewModels.Order;
using OnlineMarket.DAL.Entity;

namespace OnlineMarket.BLL.Service.Interfaces
{
    public interface IOrderService
    {
        IQueryable<Order> GetAsync();
        Task CreateAsync(OrderVM orderVM);
        Task UpdateAsync(int? id);
        Task Delete(int? id);
    }
}
