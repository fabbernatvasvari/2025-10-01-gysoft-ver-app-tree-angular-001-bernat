using Microsoft.EntityFrameworkCore;
using MyApp.Backend.Context;

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


        public static void ConfigureInMemoryContext(this IServiceCollection services)
        {
            string dbNameInMemoryContext = "Estate" + Guid.NewGuid();
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


    }
}
