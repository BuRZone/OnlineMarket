namespace OnlineMarket.DAL.Interfaces
{
    public interface IBaseRepository<T> : IDisposable
    {
        IQueryable<T> GetAsync();
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task Delete(T entity);

    }
}
