using GitCollab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitCollab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<User> GetUsers()
        {

            return Ok(new User { Id = 1, Name = "kRISHNA", Age = 20});
        }
    }
}
