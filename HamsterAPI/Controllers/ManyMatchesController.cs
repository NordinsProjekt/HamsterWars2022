using HamsterWars_Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamsterAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ManyMatchesController : ControllerBase
    {
        IMatchResultRepository _matchResultRep;
        public ManyMatchesController(IMatchResultRepository _rep) => _matchResultRep = _rep;
        // GET: <ManyMatches>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _matchResultRep.GetHighestGamesTop5());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
