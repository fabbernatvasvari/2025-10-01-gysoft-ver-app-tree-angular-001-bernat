using MyApp.Backend.Datas.Entities;
using MyApp.Backend.Repo.Base;

namespace MyApp.Backend.Repo
{
    public interface ITeacherRepo : IBaseRepo<Teacher>
    {
        public int Count();
    }
}
