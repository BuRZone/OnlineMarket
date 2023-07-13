using OnlineMarket.BLL.ViewModels.Basket;
using OnlineMarket.DAL.Entity;


namespace OnlineMarket.BLL.Service.Interfaces
{
    public interface IBasketService
    {
        IQueryable<Basket> GetAsync();

    }
}
