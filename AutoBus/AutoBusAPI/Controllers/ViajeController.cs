using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using AutoBus.Infraestructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoBusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViajeController : ControllerBase
    {
        private readonly IViajeRepository _viajeRepository;

        public ViajeController(IViajeRepository viajeRepository)
        {
            this._viajeRepository = viajeRepository;
        }

        // GET: api/Viaje/GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var viajes = await this._viajeRepository.Getall(cd => true);
            return Ok(viajes);
        }

        // GET: api/Viaje/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var viaje = await _viajeRepository.Get(id);
            if (viaje == null)
            {
                return NotFound();
            }
            return Ok(viaje);
        }

        // POST: api/Viaje/Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Viaje viaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _viajeRepository.Save(viaje);
            return CreatedAtAction(nameof(Details), new { id = viaje.IdViaje }, viaje);
        }

        // PUT: api/Viaje/Edit/5
        [HttpPut("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Viaje viaje)
        {
            if (id != viaje.IdViaje || !ModelState.IsValid)
            {
                return BadRequest();
            }
            await _viajeRepository.Update(viaje);
            return NoContent();
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Viaje = await _viajeRepository.Get(id);
            if (Viaje == null || Viaje.IsDeleted)
            {
                return NotFound();
            }

            await _viajeRepository.Delete(Viaje);

            return NoContent();
        }


    }
}
