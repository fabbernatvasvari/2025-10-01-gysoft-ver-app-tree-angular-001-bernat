using Microsoft.EntityFrameworkCore;

namespace MyApp.Backend.Context
{
    public class AppInMemoryIdentityContext : IdentityContext<AppInMemoryIdentityContext>
    {
        
        public AppInMemoryIdentityContext(DbContextOptions<AppInMemoryIdentityContext> options) : base(options)
        {
        }
    }
}
