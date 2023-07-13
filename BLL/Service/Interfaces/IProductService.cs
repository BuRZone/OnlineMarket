using OnlineMarket.BLL.ViewModels.Product;
using OnlineMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
