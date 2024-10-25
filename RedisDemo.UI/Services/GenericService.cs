
using RedisDemo.UI.DbContextFile;
using RedisDemo.UI.Repositories;

namespace RedisDemo.UI.Services
{
    public class GenericService<T> : IService<T> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly AppDbContext _appDbContext;

        public GenericService(IRepository<T> repository, AppDbContext appDbContext)
        {
            _repository = repository;
            _appDbContext = appDbContext;
        }

        public async Task<T> Create(T entity)
        {
            _repository.Create(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var data = _repository.GetAllAsync().ToList();
            return data;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var data = await _repository.GetByIdAsync(id);
            return data;
        }

        public async Task<T> Remove(T entity)
        {
            _repository.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
