using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MyApp.Backend.Datas
{
    public class DataContext:IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
