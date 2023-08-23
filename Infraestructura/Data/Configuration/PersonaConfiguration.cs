using System.Globalization;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("persona");

            /* builder.Property(p => p.NombrePersona)
            .IsRequired()
            .HasMaxLength(50); */

            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdTPersonaFk);

            builder.HasOne(p => p.Region)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdRegionFk);

            builder
            .HasMany(p => p.Productos)
            .WithMany(p => p.Personas)
            .UsingEntity<ProductoPersona>(
                j => j 
                    .HasOne(pt => pt.Producto)
                    .WithMany(t => t.ProductoPersonas)
                    .HasForeignKey(pt => pt.IdProductoFk),
                j => j
                    .HasOne(pt => pt.Persona)
                    .WithMany(t => t.ProductoPersonas)
                    .HasForeignKey(pt => pt.IdPersonaFk),
                j => 
                {
                    j.HasKey(t => new { t.IdPersonaFk, t.IdProductoFk});
                }
            );
        }
    }
}