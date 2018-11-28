using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Serveur.API.Model;

namespace Serveur.API.Infrastructure.EntityConfigurations
{
    public class ServeurEntityTypeConfiguration : IEntityTypeConfiguration<Model.Serveurs.Serveur>
    {
        public void Configure(EntityTypeBuilder<Model.Serveurs.Serveur> builder)
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

            builder.HasOne(x => x.GroupeServeur)
                .WithMany()
                .HasForeignKey(x => x.IdGroupeServeur)
                .IsRequired(false);

            builder.HasOne(x => x.Environnement)
                .WithMany()
                .HasForeignKey(x => x.IdEnvironnement)
                .IsRequired();

        }
    }

}