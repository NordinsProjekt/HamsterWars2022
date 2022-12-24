using HamsterWars_Core.DTO;
using HamsterWars_Core.Exception;
using HamsterWars_Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamsterAPI.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        IMatchRepository _matchRep;
        public MatchesController(IMatchRepository _rep) => _matchRep = _rep;
        // GET: api/<MatchesController>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _matchRep.GetMatches());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        // GET api/<MatchesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var match = await _matchRep.GetMatchByID(id);
                if (match != null)
                    return Ok(match);
                else
                    return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("Latest10Matches")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Get10Latest()
        {
            try
            {
                return Ok(await _matchRep.Get10Lastest());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{hamsterId}/{startDate}/{endDate}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetHamsterMatchesWithDates([FromRouteAttribute]string? startDate, 
            [FromRouteAttribute] string? endDate, [FromRouteAttribute] int hamsterId)
        {
            try
            {
                if (DateOnly.TryParse(startDate, out var dateOnlyStart))
                    startDate = dateOnlyStart.ToString();
                else
                    startDate = "0001-01-01";
                if (DateOnly.TryParse(endDate, out var dateOnlyEnd))
                    endDate = dateOnlyEnd.ToString();
                else
                    endDate = "9999-12-31";
                return Ok(await _matchRep.GetBetweenDates(DateOnly.Parse(startDate), DateOnly.Parse(endDate), hamsterId));
            }
            catch (HamsterDoesntExist ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        // POST api/<MatchesController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Post([FromBody] MatchCreateDTO value)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    return Ok(await _matchRep.InsertMatch(value));
                }
                catch (ArgumentException ae)
                {
                    return NotFound(ae.Message);
                }
                catch(Exception)
                {
                    return StatusCode(500);
                }
            }
            return BadRequest();
        }

        // DELETE api/<MatchesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                if (await _matchRep.DeleteMatch(id))
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
