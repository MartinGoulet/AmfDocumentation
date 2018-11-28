using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Serveur.API.Infrastructure.EntityConfigurations;
using Serveur.API.Model;

namespace Serveur.API.Donnees
{
    public class ServeurContext : DbContext
    {
        public ServeurContext(DbContextOptions<ServeurContext> options) : base(options)
        {
        }

        public DbSet<Model.Serveurs.Serveur> Serveurs { get; set; }
        public DbSet<Model.GroupeServeurs.GroupeServeur> GroupeServeurs { get; set; }
        public DbSet<Model.GroupeServeurs.ZoneGroupeServeur> ZoneGroupeServeurs { get; set; }
        public DbSet<Model.Pilotages.Environnement> Environnements { get; set; }
        public DbSet<Model.Systemes.Systeme> Systemes { get; set; }

        public DbSet<Model.Jonctions.ZoneGroupeServeurSysteme> ZoneGroupeServeurSystemes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Serveurs
            builder.ApplyConfiguration(new ServeurEntityTypeConfiguration());
            // Groupe Serveurs
            builder.ApplyConfiguration(new GroupeServeurEntityTypeConfiguration());
            builder.ApplyConfiguration(new ZoneGroupeServeurEntityTypeConfiguration());
            // Pilotages
            builder.ApplyConfiguration(new EnvironnementEntityTypeConfiguration());
            // Systèmes
            builder.ApplyConfiguration(new SystemeEntityTypeConfiguration());
            // Jonctions
            builder.ApplyConfiguration(new ZoneGroupeServeurSystemeEntityTypeConfiguration());
        }
    }

    public class ServeurContextDesignFactory : IDesignTimeDbContextFactory<ServeurContext>
    {
        public ServeurContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ServeurContext>()
                .UseSqlServer("Server=sm-dbdd72.dev.local\\martgoul;Initial Catalog=ServeurDb;Integrated Security=true");

            return new ServeurContext(optionsBuilder.Options);
        }
    }
}