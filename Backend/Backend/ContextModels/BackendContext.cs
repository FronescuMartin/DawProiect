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
            //One to one
            modelBuilder.Entity<Persoana>()
                .HasOne(Persoana => Persoana.ContWCA)
                .WithOne(ContWCA => ContWCA.Persoana)
                .HasForeignKey<ContWCA>(cwca => cwca.PersoanaId);
            //One to many
            modelBuilder.Entity<Tara>()
                        .HasMany(c => c.Persoane)
                        .WithOne(Persoana => Persoana.Tara);

            //Many to many
            modelBuilder.Entity<Rezultat>().HasKey(r => new { r.PersoanaId, r.CompetitieId });
            modelBuilder.Entity<Rezultat>()
                        .HasOne(r => r.Competitie)
                        .WithMany(c => c.Rezultate)
                        .HasForeignKey(r => r.CompetitieId);

            modelBuilder.Entity<Rezultat>()
                        .HasOne(r => r.Persoana)
                        .WithMany(p => p.Rezultate)
                        .HasForeignKey(r => r.PersoanaId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
