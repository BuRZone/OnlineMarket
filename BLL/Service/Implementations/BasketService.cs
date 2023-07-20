using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Basket;
using OnlineMarket.DAL;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;
using OnlineMarket.DAL.SQLRepositories;

namespace OnlineMarket.BLL.Service.Implementations
{
    public class BasketService : IBasketService
    {
        private readonly ILogger<BasketService> _logger;
        private readonly IBaseRepository<Basket> _repository;
        public BasketService(ILogger<BasketService> logger, IBaseRepository<Basket> repository)
        {
            _logger = logger;
            _repository = repository;
        }
       
        public IQueryable<Basket> GetAsync()
        {

            return _repository.GetAsync();
        }

        public Task Update(AddToBasketVM toBasketVM)
        {
            throw new NotImplementedException();
        }

        //public async Task Update(AddToBasketVM toBasketVM)
        //{
        //    var basket = await _repository.GetAsync().Include(p => p.Product).FirstOrDefaultAsync(x => x.Id == toBasketVM.BasketId);
        //    basket.ProductId = toBasketVM.ProductId;

        //    await _repository.UpdateAsync(basket);
        //}
    }
}
