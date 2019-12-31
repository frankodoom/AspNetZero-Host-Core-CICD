//using Abp.Dependency;
//using Castle.MicroKernel.Registration;
//using Castle.Windsor.MsDependencyInjection;
//using Microsoft.Data.Sqlite;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using tgtDemo.EntityFrameworkCore;
//using tgtDemo.Identity;

//namespace tgtDemo.Tests
//{
//    public static class ServiceCollectionRegistrar
//    {
//        public static void Register(IIocManager iocManager)
//        {
//            RegisterIdentity(iocManager);

//            var builder = new DbContextOptionsBuilder<tgtDemoDbContext>();

//            var inMemorySqlite = new SqliteConnection("Data Source=:memory:");
//            builder.UseSqlite(inMemorySqlite);

//            iocManager.IocContainer.Register(
//                Component
//                    .For<DbContextOptions<tgtDemoDbContext>>()
//                    .Instance(builder.Options)
//                    .LifestyleSingleton()
//            );

//            inMemorySqlite.Open();

//            new tgtDemoDbContext(builder.Options).Database.EnsureCreated();
//        }

//        private static void RegisterIdentity(IIocManager iocManager)
//        {
//            var services = new ServiceCollection();

//            IdentityRegistrar.Register(services);

//            WindsorRegistrationHelper.CreateServiceProvider(iocManager.IocContainer, services);
//        }
//    }
//}
