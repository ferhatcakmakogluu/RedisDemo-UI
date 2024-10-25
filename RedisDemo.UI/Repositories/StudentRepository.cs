using RedisDemo.UI.DbContextFile;
using RedisDemo.UI.Models;

namespace RedisDemo.UI.Repositories
{
    public class StudentRepository : GenericRepository<Students>
    {
        public StudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
