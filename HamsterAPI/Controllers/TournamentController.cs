using HamsterWars_Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamsterAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TournamentController : ControllerBase
    {
        ITournamentRepository _tournamentRep;
        public TournamentController(ITournamentRepository _rep) => _tournamentRep = _rep;
        // GET: api/<TournamentController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var request = await _tournamentRep.GetTournaments();
            return Ok(request);
        }

        // GET api/<TournamentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var request = await _tournamentRep.GetTournamentByID(id);
                if (request != null)
                    return Ok(request);
                else
                    return BadRequest();
            }
            catch (Exception)
            { 
                return StatusCode(500); 
            }
        }
    }
}
