using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoBusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaRepository _reservaRepository;

        public ReservaController(IReservaRepository reservaRepository)
        {
            this._reservaRepository = reservaRepository;
        }

        // GET: api/Reserva/GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var reservas = await this._reservaRepository.Getall(cd => true);
            return Ok(reservas);
        }

        // GET: api/Reserva/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var reserva = await _reservaRepository.Get(id);
            if (reserva == null)
            {
                return NotFound();
            }
            return Ok(reserva);
        }

        // POST: api/Reserva/Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Reserva reserva)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _reservaRepository.Save(reserva);
            return CreatedAtAction(nameof(Details), new { id = reserva.IdReserva }, reserva);
        }

        // PUT: api/Reserva/Edit/5
        [HttpPut("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Reserva reserva)
        {
            if (id != reserva.IdReserva || !ModelState.IsValid)
            {
                return BadRequest();
            }
            await _reservaRepository.Update(reserva);
            return NoContent();
        }

    }
}
