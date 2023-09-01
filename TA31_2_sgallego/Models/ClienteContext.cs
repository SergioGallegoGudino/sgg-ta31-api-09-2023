using Microsoft.EntityFrameworkCore;
namespace TA31_api_sgallego.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options) { }
        public DbSet<Cliente> Cliente { get; set; } = null;
        public DbSet<Video> Video { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasMany(cliente => cliente.Videos)
                .WithOne(video => video.Cliente);
        }
    }
}
