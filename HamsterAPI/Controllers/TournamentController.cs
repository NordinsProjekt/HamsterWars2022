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
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var request = await _tournamentRep.GetTournaments();
                return Ok(request);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }

        [HttpGet("done")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetTournamentsDone()
        {
            try
            {
                var request = await _tournamentRep.GetTournamentsDone();
                return Ok(request);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }

        }

        [HttpGet("ongoing")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetTournamentsOngoing()
        {
            try
            {
                var request = await _tournamentRep.GetTournamentsOngoing();
                return Ok(request);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }

        // GET api/<TournamentController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
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
