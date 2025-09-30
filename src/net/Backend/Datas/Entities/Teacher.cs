namespace MyApp.Backend.Datas.Entities
{
    public class Teacher : IdbEntitiy<Teacher>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public Teacher(string name) 
        { 
              Name= name;
        }
    }
}
