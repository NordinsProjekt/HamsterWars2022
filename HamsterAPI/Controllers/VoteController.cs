using HamsterWars_Core.DTO;
using HamsterWars_Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamsterAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        IVoteRepository _voteRep;
        public VoteController(IVoteRepository _rep) => _voteRep = _rep;
        // GET: <VoteController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Post([FromBody] VoteDTO vote)
        {
            if (ModelState.IsValid == false)
                return BadRequest();
            try
            {
                var result = await _voteRep.VoteOnMatch(vote);
                if (result)
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
