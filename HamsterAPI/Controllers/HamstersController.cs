using Azure;
using HamsterWars_Core.DTO;
using HamsterWars_Core.Interfaces;
using HamsterWars_DatabaseSQL.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HamsterAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HamstersController : ControllerBase
    {
        IHamsterRepository _hamsterRep;
        public HamstersController(IHamsterRepository _rep) => _hamsterRep = _rep;

        // GET: api/<HamsterController>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            try
            {
                return Ok(_hamsterRep.GetHamsters());
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
            
        }
        
        // GET api/<HamsterCotroller>/Random
        [HttpGet("random")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public IActionResult GetRandom()
        {
            try
            {
                return Ok(_hamsterRep.RandomHamster());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        // GET api/<HamsterController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult Get(int id)
        {
            try
            {
                var hamster = _hamsterRep.GetHamsterByID(id);
                if (hamster != null)
                    return Ok(hamster);
                else
                    return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }

        }

        // POST api/<HamsterController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
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



        // PATCH api/<HamsterController>/5
        [HttpPatch("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Patch(int id, [FromBody] HamsterPatchDTO changes)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (await _hamsterRep.UpdateHamster(changes, id))
                        return Ok();
                    return NotFound();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return StatusCode(500);
                }
            }
            return BadRequest();

        }

        // DELETE api/<HamsterController>/5
        //[HttpDelete("{id}")]
        //[ProducesResponseType(200)]
        //[ProducesResponseType(404)]
        //[ProducesResponseType(500)]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    try
        //    {
        //        if (await _hamsterRep.DeleteHamster(id))
        //            return Ok();
        //        else
        //            return NotFound();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //        return StatusCode(500);
        //    }

        //}
    }
}
