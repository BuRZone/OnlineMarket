using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Seller;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.BLL.Service.Implementations
{
    public class SellerService : ISellerService
    {
        private readonly ILogger<Seller> _logger;
        private readonly IBaseRepository<Seller> _repository;

        public SellerService(ILogger<Seller> logger, IBaseRepository<Seller> repository)
        {
            _logger = logger;
            _repository = repository;
        }
        public async Task CreateAsync(SellerVM seller)
        {
            try
            {
                var sellerQ = await _repository.GetAsync().FirstOrDefaultAsync(p => p.SellerName.Equals(seller.SellerName));
                if (sellerQ == null)
                {
                    var sel = new Seller()
                    {
                        SellerName = seller.SellerName,
                        SellerDescription = seller.SellerDescription,
                        SellerPhoto = seller.SellerPhoto

                    };
                    await _repository.CreateAsync(sel);
                    _logger.LogInformation($"[SellerService.CreateAsync] создана новый продавец {sel.SellerName}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[SellerService.CreateAsync] error: {ex.Message}");
            }
        }
        public async Task Delete(int? id)
        {
            try
            {
                var seller = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);

                if (seller != null)
                {
                    await _repository.Delete(seller);
                    _logger.LogInformation($"[ProductService.Delete] продавец удален {seller}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[ProductService.Delete] error: {ex.Message}");
            }
        }

        public IQueryable<Seller> GetAsync()
        {
            return _repository.GetAsync();
        }

        public async Task UpdateAsync(int? id)
        {
            try
            {
                var seller = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);

                if (seller != null)
                {
                    await _repository.UpdateAsync(seller);
                    _logger.LogInformation($"[ProductService.UpdateAsync] продавец обновлен {seller.SellerName}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"[ProductService.UpdateAsync] error: {ex.Message}");
            }
        }
    }
}
