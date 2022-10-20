using DataAccess.Entity;
using LocationApp.Models;
using LocationApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LocationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly IGenericCRUDService<CountryCreationModel, CountryResponseModel> _countrySvc;
        public CountryController(IGenericCRUDService<CountryCreationModel, CountryResponseModel> countrySvc)
        {
            _countrySvc = countrySvc;
        }

        // GET: api/<CountryController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _countrySvc.Get());
        }

        // GET api/<CountryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
                return NotFound($"Address with the given id: {id} is not found!");
            else if (id < 1)
                return BadRequest("Wrong data!");
            return Ok(await _countrySvc.Get(id));
        }

        // POST api/<CountryController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CountryCreationModel country)
        {
            var createCountry = await _countrySvc.Create(country);
            var routeValues = new { name = createCountry.Title};
            return CreatedAtRoute(routeValues, country);
        }

        // PUT api/<CountryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] CountryCreationModel country)
        {
            var updatedRegion = await _countrySvc.Update(id, country);
            return Ok(updatedRegion);
        }

        // DELETE api/<CountryController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool deletedCountry = await _countrySvc.Delete(id);

            if (deletedCountry)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
