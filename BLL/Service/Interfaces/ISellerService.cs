using OnlineMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Service.Interfaces
{
    public interface ISellerService
    {
        IQueryable<Seller> GetAsync();
        Task CreateAsync(Seller seller, byte[]? imageData);
        Task<Seller> UpdateAsync(int? id, byte[]? imageData);
        Task Delete(int? id);
    }
}
