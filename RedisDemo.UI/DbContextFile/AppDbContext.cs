using Microsoft.EntityFrameworkCore;
using RedisDemo.UI.Models;

namespace RedisDemo.UI.DbContextFile
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Lessons> Lessons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
