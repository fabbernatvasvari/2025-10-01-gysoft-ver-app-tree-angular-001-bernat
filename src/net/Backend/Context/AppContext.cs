using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using MyApp.Backend.Datas.Entities;

namespace MyApp.Backend.Context
{
    public class AppContext : DbContext
    {
        public DbSet <Teacher> Teachers { get; set; }
        public AppContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
