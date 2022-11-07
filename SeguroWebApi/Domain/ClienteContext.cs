using Microsoft.EntityFrameworkCore;

namespace SeguroWebApi.Domain
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
