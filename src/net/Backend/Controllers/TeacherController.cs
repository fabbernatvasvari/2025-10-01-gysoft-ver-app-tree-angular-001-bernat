<<<<<<< HEAD
using Microsoft.AspNetCore.Http;
=======
﻿using Microsoft.AspNetCore.Http;
>>>>>>> c2805dde624bde7d3507ac521c5d594048a8835c
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
