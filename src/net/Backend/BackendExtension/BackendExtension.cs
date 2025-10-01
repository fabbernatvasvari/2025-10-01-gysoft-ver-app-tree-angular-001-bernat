using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyApp.Backend.Context;
using MyApp.Backend.Datas.Entities;

namespace MyApp.Backend.BackendExtension
{
    public enum SelectDatabase { Inmemory, MySql }
    public static class BackendExtension
    {


        public static SelectDatabase _selectDatabase = SelectDatabase.Inmemory;

        public static void ConfigureBackend(this IServiceCollection services)
        {
            services.ConfigureCors();
            services.ConfigureInMemoryContext();
            services.ConfigureInMemoryIdentityContext();
            //services.ConfigureMysqlContext();
            //services.ConfigureMysqlIdentityContext();
            services.ConfigureRepos();
            services.ConfigureServices();
        }

        public static void ConfigureCors(this IServiceCollection service)
        {
            service.AddCors(option =>
                option.AddPolicy(name: "EstateSalesCore",
                policy =>
                {
                    policy.WithOrigins("https://localhost:7020/").AllowAnyHeader().AllowAnyMethod();
                }
                )
            );

        }


        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbNameInMemoryContext = "App" + Guid.NewGuid();
            services.AddDbContext<AppInMemoryContext>(

                options => options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }

        public static void ConfigureInMemoryIdentityContext(this IServiceCollection services)
        {
            string dbNameInMemoryContext = "AppIdentity" + Guid.NewGuid();
            services.AddDbContext<AppInMemoryIdentityContext>(

                options => options.UseInMemoryDatabase(databaseName: dbNameInMemoryContext),
                ServiceLifetime.Scoped,
                 ServiceLifetime.Scoped
            );
        }

        public static void ConfigureRepos(this IServiceCollection services)
        {
            
        }

        public static void ConfigureServices(this IServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration configuration = builder.Build();
        }


    }
}
