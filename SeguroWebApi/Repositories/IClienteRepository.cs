using SeguroWebApi.Domain;

namespace SeguroWebApi.Repositories
{
    public interface IClienteRepository
    {

        Task<IEnumerable<Cliente>> getAll();

        Task<Cliente> get(int id);

        Task<Cliente> create(Cliente cliente);

        Task update(Cliente cliente);

        Task delete(int id);
    }
}
