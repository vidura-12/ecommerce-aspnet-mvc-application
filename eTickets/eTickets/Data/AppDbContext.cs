using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Actor> Actors { get; set; }
        public DbSet<Models.Cinema> Cinemas { get; set; }
        public DbSet<Models.Movie> Movies { get; set; }
        public DbSet<Models.Produser> Produsers { get; set; }
    }
}