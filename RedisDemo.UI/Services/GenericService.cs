
namespace RedisDemo.UI.Services
{
    public class GenericService<T> : IService<T> where T : class
    {
        public Task<T> Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
