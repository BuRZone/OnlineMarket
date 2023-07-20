using OnlineMarket.BLL.ViewModels.Order;
using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
