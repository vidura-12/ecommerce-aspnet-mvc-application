using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movies>()
                .HasKey(am => new {
                    am.actorId, 
                    am.MovieId 
                });

            modelBuilder.Entity<Actor_Movies>()
                .HasOne(m => m.Movie)
                .WithMany(am => am.Actor_Movies)
                .HasForeignKey(m => m.MovieId);

            modelBuilder.Entity<Actor_Movies>()
                .HasOne(m => m.Actor)
                .WithMany(am => am.Actor_Movies)
                .HasForeignKey(m => m.actorId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Produser> Produsers { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Actor_Movies> Actor_Movies { get; set; }
    }
}