using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System.Reflection;

namespace Infraestructura.Data;
public class APITiendaContext : DbContext
{
    public APITiendaContext(DbContextOptions<APITiendaContext> options) : base(options)
    {}

    public DbSet<Producto> Productos { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<ProductoPersona> ProductoPersonas { get; set; }
    public DbSet<Region> Regiones { get; set; }
    public DbSet<TipoPersona> TipoPersonas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}