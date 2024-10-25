
using Microsoft.EntityFrameworkCore;
using RedisDemo.UI.DbContextFile;

namespace RedisDemo.UI.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<T>();
        }

        public async void Create(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public  IQueryable<T> GetAllAsync()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
    }
}
