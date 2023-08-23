using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("estado");

            builder.Property(e => e.NombreEstado)
            .IsRequired()
            .HasMaxLength(50);

            builder.HasOne(e => e.Pais)
            .WithMany(e => e.Estados)
            .HasForeignKey(e => e.IdPaisFk);
        }
    }
}