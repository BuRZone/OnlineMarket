using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Account;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Enum;
using OnlineMarket.DAL.Interfaces;
using OnlineMarket.LOGIC.Helpers;
using System.Security.Claims;

namespace OnlineMarket.BLL.Service.Implementations
{
    public class AccountService : IAccountService
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

        public async Task<ClaimsIdentity> Register(RegisterVM registerVM)
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
                    user.Basket = basket;
                    await _userRepository.UpdateAsync(user);


                    var result = Authenticate(user);
                    _logger.LogInformation($"[AccountService.Register] создан новый пользователь {user.UserName}");
                    _logger.LogInformation($"[AccountService.Register] создана новая корзина {basket.Id} для пользователя {user.UserName}");
                    return result;
                }
                _logger.LogWarning($"[AccountService.Register] пользователь с таким UserName: {user.UserName} уже существует");
                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[AccountService.Register] error: {ex.Message}");
                return null;
            }
        }
        public async Task<ClaimsIdentity> Login(LoginVM loginVM)
        {
            try
            {
                var user = await _userRepository.GetAsync().FirstOrDefaultAsync(x => x.UserName == loginVM.UserName);
                if (user == null)
                {
                    _logger.LogWarning($"[AccountService.Login] пользователя с таким UserName: {user.UserName} не существует");
                    return null;
                }
                if (user.Password != HashPasswordHelper.HashPassowrd(loginVM.Password))
                {
                    _logger.LogWarning($"[AccountService.Login] неверный пароль или логин");
                    return null;
                }
                var result = Authenticate(user);
                _logger.LogInformation($"[AccountService.Login] пользователь: {user.UserName} вошел в систему");

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[AccountService.Login]: {ex.Message}");
                return null;
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
