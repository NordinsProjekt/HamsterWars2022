using HamsterWars_Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamsterAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DefeatedController : ControllerBase
    {
        IMatchResultRepository _matchResultRep;
        public DefeatedController(IMatchResultRepository _rep) => _matchResultRep = _rep;

        // GET api/<DefeatedController>/5
        [HttpGet("{hamsterId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Get(int hamsterId)
        {
            try
            {
                return Ok(await _matchResultRep.GetDefeatedHamsters(hamsterId));
            }
            catch (ArgumentException ae)
            {
                return NotFound(ae.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
