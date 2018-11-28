using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Inventaire.Infrastructure.EntityConfigurations;
using Inventaire.Domain.Entites;

namespace Inventaire.Infrastructure
{
    public class InventaireContext : DbContext
    {
        public InventaireContext(DbContextOptions<InventaireContext> options) : base(options)
        {
   
        }

        public DbSet<Serveur> Serveurs { get; set; }
        public DbSet<Environnement> Environnements { get; set; }
        public DbSet<Systeme> Systemes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {            
            builder
                .ApplyConfiguration(new ConfigurationServeur())
                .ApplyConfiguration(new ConfigurationEnvironnement())
                .ApplyConfiguration(new ConfigurationSysteme());
        }
    }

    public class InventaireContextDesignFactory : IDesignTimeDbContextFactory<InventaireContext>
    {
        public InventaireContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<InventaireContext>()
                .UseSqlServer("Server=sm-dbdd72.dev.local\\martgoul;Initial Catalog=ServeurDb;Integrated Security=true");

            return new InventaireContext(optionsBuilder.Options);
        }
    }
}