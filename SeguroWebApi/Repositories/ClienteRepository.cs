using Microsoft.EntityFrameworkCore;
using SeguroWebApi.Domain;

namespace SeguroWebApi.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public readonly ClienteContext _context;

        public ClienteRepository(ClienteContext context)
        {
            _context = context;
        }

        public async Task<Cliente> create(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task delete(int id)
        {
            var clienteToDelete = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(clienteToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Cliente> get(int id)
        {
           return await _context.Clientes.FindAsync(id);
        }

        public async Task<IEnumerable<Cliente>> getAll()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task update(Cliente cliente)
        {
           _context.Entry(cliente).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
