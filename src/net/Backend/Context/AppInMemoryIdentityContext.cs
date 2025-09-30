namespace MyApp.Backend.Context
{
    public class AppInMemoryIdentityContext : IdedentityCon<AppInMemoryIdentityContext>
    {{
        public AppInMemoryIdentityContext(DbContextOptions<AppInMemoryIdentityContext> options) : base(options)
        {
        }
    }
}
