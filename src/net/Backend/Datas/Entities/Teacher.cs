using Microsoft.EntityFrameworkCore;
namespace MyApp.Backend.Datas.Entities
{
    public class Teacher : IDbEntity<Teacher>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public bool HasId=> Id != Guid.Empty;

        public Teacher(Guid id,string name) 
        { 
            Id = id;
            Name= name;
        }
        public Teacher(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
        public Teacher()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
        }
    }
}
