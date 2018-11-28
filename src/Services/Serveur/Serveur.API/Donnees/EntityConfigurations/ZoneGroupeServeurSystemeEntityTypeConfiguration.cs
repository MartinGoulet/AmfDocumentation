using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Serveur.API.Model;

namespace Serveur.API.Infrastructure.EntityConfigurations
{
    public class ZoneGroupeServeurSystemeEntityTypeConfiguration : IEntityTypeConfiguration<Model.Jonctions.ZoneGroupeServeurSysteme>
    {
        public void Configure(EntityTypeBuilder<Model.Jonctions.ZoneGroupeServeurSysteme> builder)
        {
            builder.ToTable("GroupeServeurSysteme");

            builder.HasKey(ci => new { ci.IdZoneGroupeServeur, ci.IdSysteme });


            builder.HasOne(x => x.ZoneGroupeServeur)
                   .WithMany(b => b.GroupeServeurSystemes)
                   .HasForeignKey(x => x.IdZoneGroupeServeur);

            builder.HasOne(x => x.Systeme)
                   .WithMany(b => b.ZoneGroupeServeurSystemes)
                   .HasForeignKey(x => x.IdSysteme);

        }
    }

}