using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Account;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Enum;
using OnlineMarket.DAL.Interfaces;
using OnlineMarket.LOGIC.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Service.Implementations
{
    internal class AccountService : IAccountService
    {
        private readonly IBaseRepository<User> _userRepository;
        private readonly IBaseRepository<Basket> _basketRepository;
        private readonly ILogger<AccountService> _logger;

        public AccountService(IBaseRepository<User> userRepository, IBaseRepository<Basket> basketRepository, ILogger<AccountService> logger)
        {
            _userRepository = userRepository;
            _basketRepository = basketRepository;
            _logger = logger;
        }

        public async Task Register(RegisterVM registerVM)
        {
            try
            {
                var user = await _userRepository.GetAsync().FirstOrDefaultAsync(x => x.UserName == registerVM.UserName);
                if (user == null) 
                {
                    user = new User()
                    {
                        UserName = registerVM.UserName,
                        Role = Role.User,
                        Password = HashPasswordHelper.HashPassowrd(registerVM.Password)
                    };
                    await _userRepository.CreateAsync(user);

                    var basket = new Basket()
                    {
                        UserId = user.Id
                    };
                    await _basketRepository.CreateAsync(basket);
                    var result = Authenticate(user);
                    _logger.LogInformation($"[AccountService.Register] создан новый пользователь {user}");
                    _logger.LogInformation($"[AccountService.Register] создана новая корзина {basket} для пользователя {user}");
                }
                _logger.LogWarning($"[AccountService.Register] пользователь с таким UserName: {user.UserName} уже существует");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[AccountService.Register] error: {ex.Message}");
            }
        }
        public async Task Login(LoginVM loginVM)
        {
            try
            {
                var user = await _userRepository.GetAsync().FirstOrDefaultAsync(x => x.UserName == loginVM.UserName);
                if (user == null)
                {
                    _logger.LogWarning($"[AccountService.Login] пользователя с таким UserName: {user.UserName} не существует");
                }
                if (user.Password != HashPasswordHelper.HashPassowrd(loginVM.Password))
                {
                    _logger.LogWarning($"[AccountService.Login] неверный пароль или логин");
                }
                var result = Authenticate(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[AccountService.Login]: {ex.Message}");
            }

        }
        public async Task ChangePassword(ChangePasswordVM changePasswordVM)
        {
            try
            {
                var user = await _userRepository.GetAsync().FirstOrDefaultAsync(x => x.UserName == changePasswordVM.UserName);
                if (user == null)
                {
                    _logger.LogWarning($"[AccountService.ChangePassword] пользователя с таким UserName: {user.UserName} не существует");
                }
                user.Password = HashPasswordHelper.HashPassowrd(changePasswordVM.NewPassword);
                await _userRepository.UpdateAsync(user);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[AccountService.ChangePassword]: {ex.Message}");
            }
        }

        private ClaimsIdentity Authenticate(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.UserName),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString())
            };

            return new ClaimsIdentity(claims, "Cookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}
