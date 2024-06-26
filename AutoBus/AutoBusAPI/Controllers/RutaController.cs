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
    public class RutaController : ControllerBase
    {
        private readonly IRutaRepository _rutaRepository;

        public RutaController(IRutaRepository rutaRepository)
        {
            this._rutaRepository = rutaRepository;
        }

        // GET: api/Ruta/GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var rutas = await this._rutaRepository.Getall(cd => true);
            return Ok(rutas);
        }

        // GET: api/Ruta/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var ruta = await _rutaRepository.Get(id);
            if (ruta == null)
            {
                return NotFound();
            }
            return Ok(ruta);
        }

        // POST: api/Ruta/Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Ruta ruta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _rutaRepository.Save(ruta);
            return CreatedAtAction(nameof(Details), new { id = ruta.IdRuta }, ruta);
        }

        // PUT: api/Ruta/Edit/5
        [HttpPut("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Ruta ruta)
        {
            if (id != ruta.IdRuta || !ModelState.IsValid)
            {
                return BadRequest();
            }
            await _rutaRepository.Update(ruta);
            return NoContent();
        }


        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Ruta = await _rutaRepository.Get(id);
            if (Ruta == null || Ruta.IsDeleted)
            {
                return NotFound();
            }

            await _rutaRepository.Delete(Ruta);

            return NoContent();
        }


    }
}
