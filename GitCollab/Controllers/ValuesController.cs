using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitCollab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetEmployees()
        {
            return Ok();
        }
    }
}
