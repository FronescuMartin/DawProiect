using Backend.Entities;
using Microsoft.EntityFrameworkCore;

namespace Backend.ContextModels
{
    public class BackendContext : DbContext
    {
        public DbSet<Competitie> Competitie { get; set; }
        public DbSet<Rezultat> Rezultat { get; set; }
        public DbSet<Persoana> Persoana { get; set; }
        public DbSet<Tara> Tara { get; set; }
        public DbSet<ContWCA> ContWCA { get; set; }
        public BackendContext(DbContextOptions<BackendContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persoana>()
                .HasOne(Persoana => Persoana.ContWCA)
                .WithOne(ContWCA => ContWCA.Persoana)
                .HasForeignKey<ContWCA>(cwca => cwca.Id_persoana);
        }

    }
}
