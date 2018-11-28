using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Inventaire.Domain.Entites;

namespace Inventaire.Infrastructure.EntityConfigurations
{
    public class ConfigurationServeur : IEntityTypeConfiguration<Serveur>
    {
        public void Configure(EntityTypeBuilder<Serveur> builder)
        {
            builder.ToTable("Serveur");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Id)
                .ForSqlServerUseSequenceHiLo("serveur_hilo")
                .IsRequired();

            builder.Property(cb => cb.Nom)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(cb => cb.Domaine)
                .IsRequired()
                .HasMaxLength(20);

        }
    }

}