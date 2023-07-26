using OnlineMarket.DAL.Entity;
using OnlineMarket.DAL.Interfaces;

namespace OnlineMarket.DAL.SQLRepositories
{
    public class SubCategoryRepository : IBaseRepository<SubCategory>
    {
        private readonly ApplicationDbContext _context;
        public SubCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(SubCategory entity)
        {
            _context.SubCategories.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(SubCategory subCategory)
        {
            _context.SubCategories.Remove(subCategory);
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

        public IQueryable<SubCategory> GetAsync()
        {
            return _context.SubCategories;
        }

        public async Task UpdateAsync(SubCategory subCategory)
        {
            _context.SubCategories.Update(subCategory);
            await _context.SaveChangesAsync();
        }
    }
}
