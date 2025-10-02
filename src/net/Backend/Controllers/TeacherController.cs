using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {        
        public TeacherController()
        {            
        }
        
        [HttpGet("count")]
        public IActionResult GetNumberOfTeacher()
        {
            return Ok(10);
        }
    }
}
