using HamsterWars_Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamsterAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LosersController : ControllerBase
    {
        IMatchResultRepository _matchResultRep;
        public LosersController(IMatchResultRepository _rep) => _matchResultRep = _rep;
        // GET: api/<WinnersController>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            try
            {
                return Ok(_matchResultRep.GetLow5Hamsters());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }
    }
}
