using RedisDemo.UI.DbContextFile;
using RedisDemo.UI.Models;

namespace RedisDemo.UI.Repositories
{
    public class LessonRepository : GenericRepository<Lessons>
    {
        public LessonRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
