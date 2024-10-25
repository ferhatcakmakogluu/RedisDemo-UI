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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>().HasData(
                new Students { Id =1, Name="Ferhat", Surname="Cakmakoglu", SchoolNo="BM1000", BirthDate=DateTime.Now}    
            );

            modelBuilder.Entity<Lessons>().HasData(
                new Lessons { Id=1,Name="Computer Science", Description="Data stracture", CourseCredit=7}
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
