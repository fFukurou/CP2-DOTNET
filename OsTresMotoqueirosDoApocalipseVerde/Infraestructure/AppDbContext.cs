using Microsoft.EntityFrameworkCore;
using OsTresMotoqueirosDoApocalipseVerde.Domain.Entities;

namespace OsTresMotoqueirosDoApocalipseVerde.Infraestructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Moto> Motos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            modelBuilder.Entity<Motorista>()
               .Property(m => m.Plano)
               .HasConversion<string>();

            modelBuilder.Entity<Motorista>()
                .HasOne(m => m.Moto)
                .WithOne() 
                .HasForeignKey<Motorista>(m => m.MotoId)
                .IsRequired(true) 
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}
