using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace iTrellis.HelloWorld.WebAPI.Controllers
{
    [Route("api")]
    [ApiController]
    [AllowAnonymous]
    [EnableCors("AllowLocalHostPort3000")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet("helloworld")]
        public ActionResult<string> HelloWorld()
        {
            return "Hello, world.";
        }
    }
}
