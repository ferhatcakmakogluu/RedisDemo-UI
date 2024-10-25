using RedisDemo.UI.DbContextFile;
using RedisDemo.UI.Models;
using RedisDemo.UI.Repositories;

namespace RedisDemo.UI.Services
{
    public class StudentsService : GenericService<Students>, IStudentService
    {
        public StudentsService(IRepository<Students> repository, AppDbContext appDbContext) : base(repository, appDbContext)
        {
        }
    }
}
