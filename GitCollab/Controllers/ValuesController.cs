using GitCollab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitCollab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetUsers(int id)
        {
            var user = new List<User> {
                new User{ Id = 1, Name = "kRISHNA", Age = 20 },
                new User { Id = 2, Name = "Raj", Age = 21 }
                };

            var found = user.Find(e => e.Id == id);

            if(found == null)
            {
                return NotFound();
            }

            return Ok(found);
        }
    }
}
