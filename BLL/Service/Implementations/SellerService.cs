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
    public class SellerService : ISellerService
    {
        private readonly IBaseRepository<Seller> _repository;

        public SellerService(IBaseRepository<Seller> repository)
        {
            _repository = repository;
        }
        public async Task CreateAsync(Seller seller, byte[]? imageData)
        {
            try
            {
                var sellerList = await _repository.GetAsync().ToListAsync();
                if (!sellerList.Contains(seller))
                {
                    _repository.GetAsync().Select(x => x.SellerPhoto).Append(imageData);

                    await _repository.CreateAsync(seller);
                }
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
                var seller = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);

                if (seller != null)
                {
                    await _repository.Delete(seller);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IQueryable<Seller> GetAsync()
        {
            return _repository.GetAsync();
        }

        public async Task<Seller> UpdateAsync(int? id, byte[]? imageData)
        {
            try
            {
                var seller = await _repository.GetAsync().FirstOrDefaultAsync(x => x.Id == id);

                if (seller != null)
                {
                    _repository.GetAsync().Select(x => x.SellerPhoto).Append(imageData);
                    await _repository.UpdateAsync(seller);
                }
                return seller;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
