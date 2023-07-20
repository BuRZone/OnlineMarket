using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineMarket.BLL.Service.Interfaces;
using OnlineMarket.BLL.ViewModels.Order;
using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarket.BLL.Service.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IBaseRepository<Order> _baseRepository;
        private readonly ILogger<OrderService> _logger;

        public OrderService(IBaseRepository<Order> baseRepository, ILogger<OrderService> logger)
        {
            _baseRepository = baseRepository;
            _logger = logger;
        }

        public async Task Delete(int? id)
        {
            try
            {
                var order = await _baseRepository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);
                await _baseRepository.Delete(order);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Order> GetAsync()
        {
            try
            {
                return _baseRepository.GetAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateAsync(int? id)
        {
            try
            {
                var order = await _baseRepository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);
                await _baseRepository.UpdateAsync(order);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task CreateAsync(OrderVM orderVM)
        {
            try
            {
                var order = new Order()
                {
                    DateCreated = orderVM.DateCreated,
                    BasketId = orderVM.BasketVMId,
                    ProductId = orderVM.ProductVMId
                };
                await _baseRepository.CreateAsync(order);

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
