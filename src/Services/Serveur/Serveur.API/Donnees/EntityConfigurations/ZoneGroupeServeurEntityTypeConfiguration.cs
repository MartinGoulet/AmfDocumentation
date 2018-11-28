using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Serveur.API.Model;

namespace Serveur.API.Infrastructure.EntityConfigurations
{
    public class ZoneGroupeServeurEntityTypeConfiguration : IEntityTypeConfiguration<Model.GroupeServeurs.ZoneGroupeServeur>
    {
        public void Configure(EntityTypeBuilder<Model.GroupeServeurs.ZoneGroupeServeur> builder)
        {
            builder.ToTable("ZoneGroupeServeur");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Id)
                .ForSqlServerUseSequenceHiLo("zonegroupeserveur_hilo")
                .IsRequired();
            
            builder.Property(cb => cb.Zone)
                .IsRequired()
                .HasMaxLength(5);

            builder.Property(cb => cb.Categorie)
                .IsRequired();

            builder.Property(cb => cb.Description)
                .IsRequired()
                .HasMaxLength(200);

        }
    }

}