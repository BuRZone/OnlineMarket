using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.User;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Enum;
using OnlineMarket.DAL.Interfaces;
using OnlineMarket.DAL.SQLRepositories;
using OnlineMarket.LOGIC.Helpers;

namespace OnlineMarket.BLL.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly IBaseRepository<User> _repository;

        public UserService(ILogger<UserService> logger, IBaseRepository<User> repository)
        {
            _logger = logger;
            _repository = repository;
        }
        public async Task CreateAsync(UserVM user)
        {
            try
            {
                var userQ = await _repository.GetAsync().FirstOrDefaultAsync(p => p.UserName.Equals(user.UserName));
                if (userQ == null)
                {
                    var usr = new User()
                    {
                        UserName = user.UserName,
                        Role = Enum.Parse<Role>(user.Role),
                        Password = HashPasswordHelper.HashPassowrd(user.Password)

                    };
                    await _repository.CreateAsync(usr);
                    _logger.LogInformation($"[UserService.CreateAsync] создан новый пользователь {usr.UserName}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[UserService.CreateAsync] error: {ex.Message}");
            }
        }
        public async Task Delete(int? id)
        {
            try
            {
                var user = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);

                if (user != null)
                {
                    await _repository.Delete(user);
                    _logger.LogInformation($"[UserService.Delete] пользователь удален {user}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[UserService.Delete] error: {ex.Message}");
            }
        }

        public IQueryable<User> GetAsync()
        {
            return _repository.GetAsync();
        }
        public async Task UpdateAsync(int? id)
        {
            try
            {
                var user = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);

                if (user != null)
                {
                    await _repository.UpdateAsync(user);
                    _logger.LogInformation($"[UserService.UpdateAsync] продавец обновлен {user.UserName}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[UserService.UpdateAsync] error: {ex.Message}");
            }
        }
    }
}
