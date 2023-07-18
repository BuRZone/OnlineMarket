using OnlineMarket.BLL.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Service.Interfaces
{
    public interface IAccountService
    {
        Task<ClaimsIdentity> Register(RegisterVM registerVM);
        Task<ClaimsIdentity> Login(LoginVM loginVM);
        Task ChangePassword(ChangePasswordVM changePasswordVM);

    }
}
