using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoBusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusController : ControllerBase
    {
        private readonly IBusRepository _busRepository;

        public BusController(IBusRepository busRepository)
        {
            this._busRepository = busRepository;
        }

        // GET: api/Bus/GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var buses = await this._busRepository.Getall(cd => true);
            return Ok(buses);
        }

        // GET: api/Bus/GetAll
        [HttpGet("GetAvalibleBuses")]
        public async Task<IActionResult> GetAvalible()
        {
            var buses =  this._busRepository.GetBuses();
            return Ok(buses);
        }


        // GET: api/Bus/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var bus = await _busRepository.Get(id);
            if (bus == null)
            {
                return NotFound();
            }
            return Ok(bus);
        }

        // POST: api/Bus/Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Bus bus)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _busRepository.Save(bus);
            return CreatedAtAction(nameof(Details), new { id = bus.IdBus }, bus);
        }

        // PUT: api/Bus/Edit/5
        [HttpPut("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Bus bus)
        {
            if (id != bus.IdBus || !ModelState.IsValid)
            {
                return BadRequest();
            }
            await _busRepository.Update(bus);
            return NoContent();
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var bus = await _busRepository.Get(id);
            if (bus == null || bus.IsDeleted)
            {
                return NotFound();
            }

            await _busRepository.Delete(bus);

            return NoContent();
        }

    }
}
