using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Service.Implementations
{
    
    

    public class UserService : IUserService
    {
        private readonly IBaseRepository<User> _repository;

        public UserService(IBaseRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task CreateAsync(User user)
        {
            try
            {
                var userList = await _repository.GetAsync().ToListAsync();
                if (!userList.Contains(user))
                {
                    await _repository.CreateAsync(user);
                }
            }
            catch (Exception ex)
            {

                throw;
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
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IQueryable<User> GetAsync()
        {
            return _repository.GetAsync();
        }

        public async Task<User> UpdateAsync(int? id)
        {
            try
            {
                var user = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);

                if (user != null)
                {
                    await _repository.UpdateAsync(user);
                }
                return user;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
