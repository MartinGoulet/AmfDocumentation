using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Inventaire.Domain.Entites;

namespace Inventaire.Infrastructure.EntityConfigurations
{
    public class ConfigurationSysteme : IEntityTypeConfiguration<Systeme>
    {
        public void Configure(EntityTypeBuilder<Systeme> builder)
        {
            builder.ToTable("Systeme");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Id)
                .ForSqlServerUseSequenceHiLo("systeme_hilo")
                .IsRequired();

            builder.Property(cb => cb.Nom)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(cb => cb.Description)
                .IsRequired()
                .HasMaxLength(500);

        }
    }

}