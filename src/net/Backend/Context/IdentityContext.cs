using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyApp.Backend.Datas.Entities;

namespace MyApp.Backend.Context
{
    public class IdentityContext<TDbContext> : IdentityDbContext<LoginUser> where TDbContext : DbContext
    {
        public IdentityContext(DbContextOptions<TDbContext> options) : base(options) { }
    }
}
