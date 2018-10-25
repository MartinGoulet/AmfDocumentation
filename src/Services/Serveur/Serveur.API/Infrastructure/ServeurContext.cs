using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Serveur.API.Infrastructure.EntityConfigurations;

namespace Serveur.API.Infrastructure
{
    public class ServeurContext : DbContext
    {
        public ServeurContext(DbContextOptions<ServeurContext> options) : base(options)
        {
        }

        public DbSet<Model.Serveur> Serveurs { get; set; }
        public DbSet<Model.GroupeServeur> GroupeServeurs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ServeurEntityTypeConfiguration());
            builder.ApplyConfiguration(new GroupeServeurEntityTypeConfiguration());
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