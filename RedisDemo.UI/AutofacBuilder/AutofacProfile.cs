using Autofac;
using RedisDemo.UI.DbContextFile;
using RedisDemo.UI.Repositories;
using RedisDemo.UI.Services;
using System.Reflection;
using Module = Autofac.Module;
namespace RedisDemo.UI.AutofacBuilder
{
    public class AutofacProfile : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            //tüm assembly leri al (katmanlar)
            var apiAssembly = Assembly.GetExecutingAssembly(); //mevcutta calısılan assembly
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(GenericService<>));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();
        }

    }
}
