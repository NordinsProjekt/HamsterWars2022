using HamsterWars_Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamsterAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScoreController : ControllerBase
    {
        IMatchResultRepository _matchResultRep;
        public ScoreController(IMatchResultRepository _rep) => _matchResultRep = _rep;
        // GET: api/<ScoreController>
        [HttpGet("{challenger}/{defender}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Get(int challenger, int defender)
        {
            try
            {
                return Ok(await _matchResultRep.GetChallengerScoreCard(challenger, defender));
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
        [HttpGet("all/{hamsterId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllMatchResult(int hamsterId)
        {
            try
            {
                return Ok(await _matchResultRep.GetAllMatchResultForHamster(hamsterId));
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
