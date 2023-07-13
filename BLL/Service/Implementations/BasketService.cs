using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.BLL.Service.Implementations
{
    public class BasketService : IBasketService
    {
        private readonly IBaseRepository<Basket> _repository;
        public BasketService(IBaseRepository<Basket> repository)
        {
            _repository = repository;
        }
       

        public IQueryable<Basket> GetAsync()
        {

            return _repository.GetAsync();
        }

    }
}
