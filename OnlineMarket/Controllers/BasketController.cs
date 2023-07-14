using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineMarket.BLL.Service.Interfaces;

namespace OnlineMarket.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketService _basketService;
        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
            
        }

        public async Task<IActionResult> Index()
        {
            var basket = _basketService.GetAsync().Include(x => x.Product).Select(x => x.Product).ToListAsync();   
            return View(basket);
        }
    }
}
