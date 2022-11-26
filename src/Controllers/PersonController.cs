using Microsoft.AspNetCore.Mvc;
using RestWithASPUdemy.src.Models;
using RestWithASPUdemy.src.Services;

namespace RestWithASPUdemy.src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            return Ok(_personService.GetAll());
        }

        [HttpGet("getById/{id}")]
        public IActionResult GetById(long id)
        {
            var person = _personService.GetById(id);
            if (person == null)
                return NotFound();

            return Ok(person);
        }

        [HttpPost("createPerson")]
        public IActionResult Create([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            return Ok(_personService.Create(person));
        }

        [HttpPut("updatePerson")]
        public IActionResult Update([FromBody] Person person)
        {
            if (person == null)
                return BadRequest();

            return Ok(_personService.Update(person));
        }

        [HttpDelete("deletePerson/{id}")]
        public IActionResult Delete(long id)
        {
            var person = _personService.GetById(id);
            if (person == null)
                return NotFound();

            _personService.Delete(id);

            return NoContent();
        }
    }
}