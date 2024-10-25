namespace RedisDemo.UI.Services
{
    public interface IService<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> Create(T entity);
        Task<T> Remove(int id);
    }
}
