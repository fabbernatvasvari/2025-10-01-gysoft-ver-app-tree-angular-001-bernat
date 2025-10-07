using Microsoft.AspNetCore.Mvc;
using MyApp.Backend.Datas.Entities;
using MyApp.Backend.Repo;
using MyApp.Backend.Repo.Base;

namespace MyApp.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : BaseController<Teacher>
    {
        private IBaseRepo<Teacher> _repo;
        private ITeacherRepo _teacherRepo;
        public TeacherController(ITeacherRepo teacherRepo, IBaseRepo<Teacher> repo) : base(repo) 
        { 
           _repo = repo ?? throw new ArgumentException($"A {nameof(IBaseRepo<Teacher>)} repo nem elérhető!");
           _teacherRepo=teacherRepo ?? throw new ArgumentException($"A {nameof(IBaseRepo<Teacher>)} repo nem elérhető!");
        } 

        [HttpGet("count")]
        public async Task<IActionResult> GetNumberOfTeacher()
        {
            return Ok(_teacherRepo.Count());
        }
    }
}
