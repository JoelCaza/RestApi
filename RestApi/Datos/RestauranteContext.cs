using Microsoft.EntityFrameworkCore;
using RestApi.Entidades;

namespace RestApi.Datos;
public class RestauranteContext(
    DbContextOptions<RestauranteContext> options)
    : DbContext(options)
{
    public DbSet<Plato> Platos => Set<Plato>();
    public DbSet<Categoria> Categorias => Set<Categoria>();
    public DbSet<Mesa> Mesas => Set<Mesa>();   // NUEVO

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Plato>(e =>
        {
            e.Property(p => p.Precio).HasPrecision(10, 2);
            e.Property(p => p.Descripcion).IsRequired(false);
            e.Ignore(p => p.Categoria);   // viene del JOIN
            e.HasQueryFilter(p => p.Disponible == 1);
        });
    }
}