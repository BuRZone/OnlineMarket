using OnlineMarket.BLL.ViewModels.Seller;
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
        Task CreateAsync(SellerVM seller);
        Task UpdateAsync(int? id);
        Task Delete(int? id);
    }
}
