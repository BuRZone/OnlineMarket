using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.DAL.SQLRepositories
{
    public class BasketRepository : IBaseRepository<Basket>
    {
        private readonly ApplicationDbContext _context;
        public BasketRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Basket entity)
        {
            _context.Baskets.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Basket basket)
        {
            _context.Baskets.Remove(basket);
            await _context.SaveChangesAsync();

        }

        private bool _disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IQueryable<Basket> GetAsync()
        {
            return _context.Baskets;
        }

        public async Task UpdateAsync(Basket basket)
        {
            _context.Baskets.Update(basket);
            await _context.SaveChangesAsync();
        }
    }
}

