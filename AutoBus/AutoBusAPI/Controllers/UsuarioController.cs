using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoBusAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            this._usuarioRepository = usuarioRepository;
        }

        // GET: api/Usuario/GetAll
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            var usuarios = await this._usuarioRepository.Getall(cd => true);
            return Ok(usuarios);
        }

        // GET: api/Usuario/Details/5
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var usuario = await _usuarioRepository.Get(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        // POST: api/Usuario/Create
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _usuarioRepository.Save(usuario);
            return CreatedAtAction(nameof(Details), new { id = usuario.IdUsuario }, usuario);
        }

        // PUT: api/Usuario/Edit/5
        [HttpPut("Edit/{id}")]
        public async Task<IActionResult> Edit(int id, [FromBody] Usuario usuario)
        {
            if (id != usuario.IdUsuario || !ModelState.IsValid)
            {
                return BadRequest();
            }
            await _usuarioRepository.Update(usuario);
            return NoContent();
        }

    }
}
