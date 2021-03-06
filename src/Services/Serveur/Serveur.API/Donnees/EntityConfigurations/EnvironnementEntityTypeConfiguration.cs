using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Serveur.API.Model;

namespace Serveur.API.Infrastructure.EntityConfigurations
{
    public class EnvironnementEntityTypeConfiguration : IEntityTypeConfiguration<Model.Pilotages.Environnement>
    {
        public void Configure(EntityTypeBuilder<Model.Pilotages.Environnement> builder)
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