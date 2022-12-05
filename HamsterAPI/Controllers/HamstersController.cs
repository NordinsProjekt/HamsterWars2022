using HamsterWars_Core.DTO;
using HamsterWars_Core.Interfaces;
using HamsterWars_DatabaseSQL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamsterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HamstersController : ControllerBase
    {
        IHamsterRepository _hamsterRep;
        public HamstersController(IHamsterRepository _rep) => _hamsterRep = _rep;

        // GET: api/<HamsterController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_hamsterRep.GetHamsters());
        }

        [HttpGet("random")]
        public IActionResult GetRandom()
        {
            return Ok(_hamsterRep.RandomHamster());
        }

        // GET api/<HamsterController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var hamster = _hamsterRep.GetHamsterByID(id);
            if (hamster !=null)
                return Ok(hamster);
            else
                return NotFound();
        }

        // POST api/<HamsterController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] HamsterCreateDTO hamster)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _hamsterRep.InsertHamsterAsync(hamster);
                    if (result.Id > 0) { return Ok(result); }
                    return BadRequest();
                }
                catch (Exception ex)
                {
                    return StatusCode(500);
                }
            }
            else
            {
                return BadRequest();
            }
        }
            


        // PUT api/<HamsterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HamsterController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _hamsterRep.DeleteHamster(id))
                return Ok();
            else
                return NotFound();
        }
    }
}
