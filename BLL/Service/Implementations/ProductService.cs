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
    public class ProductService : IProductService
    {
        private readonly IBaseRepository<Product> _repository;

        public ProductService(IBaseRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task CreateAsync(Product product)
        {
            try
            {
                await _repository.CreateAsync(product);
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
                var product = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);

                if (product != null)
                {
                    await _repository.Delete(product);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IQueryable<Product> GetAsync()
        {
            return _repository.GetAsync();
        }

        public async Task<Product> UpdateAsync(int? id)
        {
            try
            {
                var product = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);

                if (product != null)
                {
                    await _repository.UpdateAsync(product);
                }
                return product;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
