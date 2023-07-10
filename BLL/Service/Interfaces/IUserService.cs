using OnlineMarket.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Service.Interfaces
{
    public interface IUserService
    {
        IQueryable<User> GetAsync();
        Task CreateAsync(User user);
        Task<User> UpdateAsync(int? id);
        Task Delete(int? id);
    }
}
