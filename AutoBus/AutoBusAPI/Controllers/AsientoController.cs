using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoBusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AsientoController : ControllerBase
    {
        private readonly IAsientoRepository _asientoRepository;

        public AsientoController(IAsientoRepository asientoRepository)
        {
            this._asientoRepository = asientoRepository;
        }

        // GET: api/Asiento/GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var Asiento = await this._asientoRepository.Getall(cd => true);
            return Ok(Asiento);
        }

        // GET: api/Asiento/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var asiento = await _asientoRepository.Get(id);
            if (asiento == null)
            {
                return NotFound();
            }
            return Ok(asiento);
        }

        // POST: api/Asiento/Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Asiento asiento)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _asientoRepository.Save(asiento);
            return CreatedAtAction(nameof(Details), new { id = asiento.IdAsiento }, asiento);
        }

        // PUT: api/Asiento/Edit/5
        [HttpPut("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Asiento asiento)
        {
            if (id != asiento.IdAsiento || !ModelState.IsValid)
            {
                return BadRequest();
            }
            await _asientoRepository.Update(asiento);
            return NoContent();
        }

       
    }
}
