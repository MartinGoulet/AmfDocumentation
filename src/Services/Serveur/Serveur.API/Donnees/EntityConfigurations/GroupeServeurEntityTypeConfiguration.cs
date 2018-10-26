using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Serveur.API.Model;

namespace Serveur.API.Infrastructure.EntityConfigurations
{
    public class GroupeServeurEntityTypeConfiguration : IEntityTypeConfiguration<Model.GroupeServeur>
    {
        public void Configure(EntityTypeBuilder<Model.GroupeServeur> builder)
        {
            builder.ToTable("GroupeServeur");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Id)
                .ForSqlServerUseSequenceHiLo("groupeserveur_hilo")
                .IsRequired();

            builder.Property(cb => cb.Numero)
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