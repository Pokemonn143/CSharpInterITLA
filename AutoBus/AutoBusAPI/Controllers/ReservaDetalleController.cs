using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoBusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaDetalleController : ControllerBase
    {
        private readonly IReservaDetalleRepository _reservaDetalleRepository;

        public ReservaDetalleController(IReservaDetalleRepository reservaDetalleRepository)
        {
            this._reservaDetalleRepository = reservaDetalleRepository;
        }

        // GET: api/ReservaDetalle/GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var reservaDetalles = await this._reservaDetalleRepository.Getall(cd => true);
            return Ok(reservaDetalles);
        }

        // GET: api/ReservaDetalle/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var reservaDetalle = await _reservaDetalleRepository.Get(id);
            if (reservaDetalle == null)
            {
                return NotFound();
            }
            return Ok(reservaDetalle);
        }

        // POST: api/ReservaDetalle/Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] ReservaDetalle reservaDetalle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _reservaDetalleRepository.Save(reservaDetalle);
            return CreatedAtAction(nameof(Details), new { id = reservaDetalle.IdReservaDetalle }, reservaDetalle);
        }

        // PUT: api/ReservaDetalle/Edit/5
        [HttpPut("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] ReservaDetalle reservaDetalle)
        {
            if (id != reservaDetalle.IdReservaDetalle || !ModelState.IsValid)
            {
                return BadRequest();
            }
            await _reservaDetalleRepository.Update(reservaDetalle);
            return NoContent();
        }

    }
}
