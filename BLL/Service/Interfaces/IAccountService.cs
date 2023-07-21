using OnlineMarket.BLL.ViewModels.Account;
using System.Security.Claims;

namespace OnlineMarket.BLL.Service.Interfaces
{
    public interface IAccountService
    {
        Task<ClaimsIdentity> Register(RegisterVM registerVM);
        Task<ClaimsIdentity> Login(LoginVM loginVM);
        Task ChangePassword(ChangePasswordVM changePasswordVM);

    }
}
