using Microsoft.EntityFrameworkCore;
namespace TA31_api_sgallego.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options) { }
        public DbSet<Cliente> Cliente { get; set; } = null;
    }
}
