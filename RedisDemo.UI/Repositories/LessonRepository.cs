using RedisDemo.UI.DbContextFile;
using RedisDemo.UI.Models;

namespace RedisDemo.UI.Repositories
{
    public class LessonRepository : GenericRepository<Lessons>, ILessonRepository
    {
        public LessonRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
