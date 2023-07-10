using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;
using OnlineMarket.DAL.SQLRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Service.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly IBaseRepository<Category> _repository;

        public CategoryService(IBaseRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task CreateAsync(Category category)
        {
            try
            {
                var categoryList = await _repository.GetAsync().ToListAsync();
                var categoryFind = categoryList.FirstOrDefault(p => p.CategoryName.Equals(category.CategoryName));
                if (categoryFind == null)
                {
                    await _repository.CreateAsync(category);
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
                var category = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);

                if (category != null)
                {
                    await _repository.Delete(category);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IQueryable<Category> GetAsync()
        {
            return _repository.GetAsync();
        }

        public async Task<Category> UpdateAsync(int? id)
        {
            try
            {
                var category = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);
                
                if (category != null)
                {
                    await _repository.UpdateAsync(category);
                }
                    return category;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
