using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("producto");

            builder.HasKey(p => p.Id);

            builder.Property(P => P.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasMaxLength(3);

            builder.Property(p => p.CodInterno)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.NombreProducto)
            .IsRequired()
            .HasMaxLength(50);

            builder.Property(p => p.StockMin)
            .HasColumnType("int");

            builder.Property(p => p.StockMax)
            .HasColumnType("int");

            builder.Property(p => p.Stock)
            .HasColumnType("int");

            builder.Property(p => p.ValorVenta)
            .HasColumnType("double");
        }
    }
}