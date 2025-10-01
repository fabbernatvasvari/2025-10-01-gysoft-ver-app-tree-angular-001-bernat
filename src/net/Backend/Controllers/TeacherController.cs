using Microsoft.AspNetCore.Mvc;
using MyApp.Backend.Datas.Entities;
using MyApp.Backend.Repo.Base;

namespace MyApp.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : BaseController<Teacher>
    {
        public TeacherController(IBaseRepo<Teacher> repo) : base(repo) { }
    }
}
