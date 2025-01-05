using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlowAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/User
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("GET: api/User");
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok("GET: api/User/" + id);
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] IFormCollection form)
        {
            return Ok("POST: api/User");
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] IFormCollection form)
        {
            return Ok("PUT: api/User/" + id);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("DELETE: api/User/" + id);
        }
    }
}
