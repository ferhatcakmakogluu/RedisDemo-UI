namespace RedisDemo.UI.Repositories
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        void Create(T entity);
        void Remove(T entity);
    }
}
