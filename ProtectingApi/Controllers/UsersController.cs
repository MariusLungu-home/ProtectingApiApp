using Microsoft.AspNetCore.Mvc;
using MonitoringApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProtectingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        //[ResponseCache(Duration = 1, Location = ResponseCacheLocation.Any, NoStore = false)]
        public IEnumerable<string> Get()
        {
            return new string[] { Random.Shared.Next(1, 101).ToString() };
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        //[ResponseCache(Duration = 60, Location = ResponseCacheLocation.Any, NoStore = false)]

        public string Get(int id)
        {
            return $"Random number: {Random.Shared.Next(1, 101)} for id {id}";
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post([FromBody] UserModel value)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
