using EdunovaAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace EdunovaAPP.Data
{
    public class EdunovaContext:DbContext
    {
        public EdunovaContext(DbContextOptions<EdunovaContext> options)
            :base(options)
        {

        }
        public DbSet<Smjer> Smjerovi { get; set; }

        public DbSet<Predavac> Predavaci { get; set; }

        public DbSet<Polaznik> Polaznici { get; set; }

        public DbSet<Grupa> Grupe { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // implementacija veze 1:n
            modelBuilder.Entity<Grupa>().HasOne(g => g.Smjer);
            modelBuilder.Entity<Grupa>().HasOne(g => g.Predavac);

            // implementacija veze n:n
            modelBuilder.Entity<Grupa>()
                .HasMany(g => g.Polaznici)
                .WithMany(p => p.Grupe)
                .UsingEntity<Dictionary<string, object>>("clanovi",
                c => c.HasOne<Polaznik>().WithMany().HasForeignKey("polaznik"),
                c => c.HasOne<Grupa>().WithMany().HasForeignKey("grupa"),
                c => c.ToTable("clanovi")
                );

        }
    }
}
