using MyApp.Backend.Context;
using MyApp.Backend.Datas.Entities;

namespace MyApp.Backend.Repo.Base
{
    public class TeacherRepo<TDbContext> : BaseRepo<TDbContext,Teacher>, ITeacherRepo where TDbContext : AppContext
    {
        public TeacherRepo(TDbContext dbContext) : base(dbContext) {}
    }
}
