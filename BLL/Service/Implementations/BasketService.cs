using Microsoft.Extensions.Logging;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;
using OnlineMarket.DAL.SQLRepositories;

namespace OnlineMarket.BLL.Service.Implementations
{
    public class BasketService : IBasketService
    {
        private readonly ILogger _logger;
        private readonly IBaseRepository<Basket> _repository;
        public BasketService(ILogger<BasketService> logger)
        {
            _logger = logger;
            _repository = new BasketRepository();
        }
       

        public IQueryable<Basket> GetAsync()
        {

            return _repository.GetAsync();
        }

    }
}
