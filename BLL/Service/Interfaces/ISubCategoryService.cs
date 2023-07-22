using OnlineMarket.BLL.ViewModels.Category;
using OnlineMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
