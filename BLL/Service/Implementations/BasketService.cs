using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;
using OnlineMarket.DAL.SQLRepositories;

namespace OnlineMarket.BLL.Service.Implementations
{
    public class BasketService : IBasketService
    {
        private readonly IBaseRepository<Basket> _repository;
        public BasketService()
        {
            _repository = new BasketRepository();
        }
       

        public IQueryable<Basket> GetAsync()
        {

            return _repository.GetAsync();
        }

    }
}
