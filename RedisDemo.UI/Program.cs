using Microsoft.EntityFrameworkCore;
using RedisDemo.UI.DbContextFile;
using RedisDemo.UI.Repositories;
using RedisDemo.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

builder.Services.AddScoped(typeof(IService<>), typeof(GenericService<>));
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));


//inmemory database used
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseInMemoryDatabase("database");
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
