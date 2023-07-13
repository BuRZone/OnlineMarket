using OnlineMarket.BLL.ViewModels.User;
using OnlineMarket.DAL.Entity;

namespace OnlineMarket.BLL.Service.Interfaces
{
    public interface IUserService
    {
        IQueryable<User> GetAsync();
        Task CreateAsync(UserVM user);
        Task UpdateAsync(int? id);
        Task Delete(int? id);
    }
}
