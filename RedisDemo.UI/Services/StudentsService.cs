using RedisDemo.UI.DbContextFile;
using RedisDemo.UI.Models;
using RedisDemo.UI.Repositories;

namespace RedisDemo.UI.Services
{
    public class StudentsService : GenericService<Students>
    {
        public StudentsService(IRepository<Students> repository, AppDbContext appDbContext) : base(repository, appDbContext)
        {
        }
    }
}
