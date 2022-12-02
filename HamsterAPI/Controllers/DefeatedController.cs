using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamsterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefeatedController : ControllerBase
    {
        // GET: api/<DefeatedController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DefeatedController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DefeatedController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DefeatedController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DefeatedController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
