using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Category;
using OnlineMarket.BLL.ViewModels.Product;
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
        private readonly ILogger<ProductService> _logger;
        private readonly IBaseRepository<Product> _repository;

        public ProductService(ILogger<ProductService> logger, IBaseRepository<Product> repository)
        {
            _logger = logger;
            _repository = repository;
        }
        public async Task CreateAsync(ProductVM product)
        {
            try
            {
                var productQ = await _repository.GetAsync().FirstOrDefaultAsync(p => p.ProductName.Equals(product.ProductName));
                if (productQ == null)
                {
                    var prod = new Product()
                    {
                        ProductName = product.ProductName,
                        ProductDescription = product.ProductDescription,
                        ProductPhoto = product.ProductPhoto

                    };
                    await _repository.CreateAsync(prod);
                    _logger.LogInformation($"[ProductService.CreateAsync] создан новый продукт {prod.ProductName}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[ProductService.CreateAsync] error: {ex.Message}");
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
                    _logger.LogInformation($"[ProductService.Delete] продукт удален {product}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[ProductService.Delete] error: {ex.Message}");
            }
        }

        public IQueryable<Product> GetAsync()
        {
            return _repository.GetAsync();
        }

        public async Task UpdateAsync(int? id)
        {
            try
            {
                var product = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);

                if (product != null)
                {
                    await _repository.UpdateAsync(product);
                    _logger.LogInformation($"[ProductService.UpdateAsync] продукт обновлен {product.ProductName}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[ProductService.UpdateAsync] error: {ex.Message}");
            }
        }
    }
}
