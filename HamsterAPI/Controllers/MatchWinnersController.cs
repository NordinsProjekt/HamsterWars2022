using HamsterWars_Core.DTO;
using HamsterWars_Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamsterAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MatchWinnersController : ControllerBase
    {
        IMatchResultRepository _matchResultRep;
        public MatchWinnersController(IMatchResultRepository _rep) => _matchResultRep = _rep;
        // GET: api/<matchWinnersController>
        [HttpGet("{hamsterId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Get(int hamsterId)
        {
            try
            {
                var result = await _matchResultRep.GetMatchWinners(hamsterId);
                if (result.Count() == 0) 
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception)
            {
                //500
                return StatusCode(500);
            }
        }

    }
}
