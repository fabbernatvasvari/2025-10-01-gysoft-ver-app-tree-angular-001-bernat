using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Backend.Datas
{
    public class DataContext:IdentityDbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
