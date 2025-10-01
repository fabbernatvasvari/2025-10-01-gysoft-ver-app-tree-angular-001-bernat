using Microsoft.EntityFrameworkCore;
using MyApp.Backend.Datas.Entities;

namespace MyApp.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Ide kerülnek a tesztadatok

            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher(){Name="Teszt Elek"},
                new Teacher(){Name="Teszt Eszter"}
            };
            modelBuilder.Entity<Teacher>().HasData(teachers);
        }
    }
}
