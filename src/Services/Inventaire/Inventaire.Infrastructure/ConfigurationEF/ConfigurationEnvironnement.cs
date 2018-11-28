using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Inventaire.Domain.Entites;

namespace Inventaire.Infrastructure.EntityConfigurations
{
    public class ConfigurationEnvironnement : IEntityTypeConfiguration<Environnement>
    {
        public void Configure(EntityTypeBuilder<Environnement> builder)
        {
            builder.ToTable("Environnement");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Id)
                .ForSqlServerUseSequenceHiLo("environnement_hilo")
                .IsRequired();

            builder.Property(cb => cb.Code)
                .IsRequired()
                .HasMaxLength(5);

            builder.Property(cb => cb.Nom)
                .IsRequired()
                .HasMaxLength(20);

        }
    }

}