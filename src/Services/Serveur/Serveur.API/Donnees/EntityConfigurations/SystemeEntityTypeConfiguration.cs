using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Serveur.API.Model;

namespace Serveur.API.Infrastructure.EntityConfigurations
{
    public class SystemeEntityTypeConfiguration : IEntityTypeConfiguration<Model.Systemes.Systeme>
    {
        public void Configure(EntityTypeBuilder<Model.Systemes.Systeme> builder)
        {
            builder.ToTable("Systeme");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Id)
                .ForSqlServerUseSequenceHiLo("Systeme_hilo")
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