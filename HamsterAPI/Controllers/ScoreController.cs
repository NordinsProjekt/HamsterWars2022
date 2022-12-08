using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamsterAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        // GET: api/<ScoreController>
        [HttpGet("{challenger}/{defender}")]
        public IEnumerable<string> Get(int challenger, int defender)
        {
            return new string[] { "value1", "value2" };
        }
    }
}
