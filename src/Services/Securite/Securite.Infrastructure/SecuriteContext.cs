using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Securite.Infrastructure.EntityConfigurations;
using Securite.Domain.Entites;

namespace Securite.Infrastructure
{
    public class SecuriteContext : DbContext
    {
        public SecuriteContext(DbContextOptions<SecuriteContext> options) : base(options)
        {
   
        }

        public DbSet<Environnement> Environnements { get; set; }
        public DbSet<Systeme> Systemes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {            
            builder
                .ApplyConfiguration(new ConfigurationEnvironnement())
                .ApplyConfiguration(new ConfigurationSysteme());
        }
    }

    public class SecuriteContextDesignFactory : IDesignTimeDbContextFactory<SecuriteContext>
    {
        public SecuriteContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SecuriteContext>()
                .UseSqlServer("Server=sm-dbdd72.dev.local\\martgoul;Initial Catalog=ServeurDb;Integrated Security=true");

            return new SecuriteContext(optionsBuilder.Options);
        }
    }
}