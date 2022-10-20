using LocationApp.Models;
using LocationApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LocationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IGenericCRUDService<RegionCreationModel, RegionResponseModel> _regionSvc;
        public RegionController(IGenericCRUDService<RegionCreationModel, RegionResponseModel> addressSvc)
        {
            _regionSvc = addressSvc;
        }

        // GET: api/<RegionController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _regionSvc.Get());
        }

        // GET api/<RegionController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
                return NotFound($"Address with the given id: {id} is not found!");
            else if (id < 1)
                return BadRequest("Wrong data!");
            return Ok(await _regionSvc.Get(id));
        }

        // POST api/<RegionController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegionCreationModel region)
        {
            var createRegion = await _regionSvc.Create(region);
            var routeValues = new { title = createRegion.Title };
            return CreatedAtRoute(routeValues, createRegion);
        }

        // PUT api/<RegionController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] RegionCreationModel region)
        {
             var updatedRegion = await _regionSvc.Update(id, region);
            return Ok(updatedRegion);
        }

        // DELETE api/<RegionController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool deletedEmployee = await _regionSvc.Delete(id);

            if (deletedEmployee)
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
