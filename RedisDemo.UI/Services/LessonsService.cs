using RedisDemo.UI.DbContextFile;
using RedisDemo.UI.Models;
using RedisDemo.UI.Repositories;

namespace RedisDemo.UI.Services
{
    public class LessonsService : GenericService<Lessons>, ILessonsService
    {
        public LessonsService(IRepository<Lessons> repository, AppDbContext appDbContext) : base(repository, appDbContext)
        {
        }
    }
}
