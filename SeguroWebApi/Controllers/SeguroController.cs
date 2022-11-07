using Microsoft.AspNetCore.Mvc;
using SeguroWebApi.Domain;
using SeguroWebApi.Repositories;

namespace SeguroWebApi.Controllers
{
    [Route("api/[Controller]")]
    public class SeguroController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public SeguroController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Cliente>> getAll()
        {
            return await _clienteRepository.getAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> get(int id)
        {
            return await _clienteRepository.get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Cliente>> create([FromBody]Cliente cliente)
        {
            var newCliente = _clienteRepository.create(cliente);
            return CreatedAtAction(nameof(get), new { id = newCliente.Id}, newCliente);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> delete(int id)
        {
            var clienteToDelete = await _clienteRepository.get(id);

            if (clienteToDelete == null) 
                return NotFound();

            await _clienteRepository.delete(id);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> update (int id, [FromBody] Cliente cliente)
        {
            if (id == cliente.id)
                await _clienteRepository.update(cliente);

            return BadRequest();
        }
    }
}
