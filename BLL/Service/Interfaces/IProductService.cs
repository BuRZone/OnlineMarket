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
        Task CreateAsync(Product product, byte[]? imageData);
        Task<Product> UpdateAsync(int? id, byte[]? imageData);
        Task Delete(int? id);
    }
}
