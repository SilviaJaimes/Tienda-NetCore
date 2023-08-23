using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.ToTable("region");

            builder.Property(r => r.NombreRegion)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(r => r.Estado)
            .WithMany(r => r.Regiones)
            .HasForeignKey(r => r.IdEstadoFk);
        }
    }
}
