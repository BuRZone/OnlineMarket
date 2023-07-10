using OnlineMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Service.Interfaces
{
    public interface ICategoryService
    {
        IQueryable<Category> GetAsync();
        Task CreateAsync(Category category);
        Task<Category> UpdateAsync(int? id);
        Task Delete(int? id);
    }
}
