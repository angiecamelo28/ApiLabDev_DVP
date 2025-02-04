using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Factura> Facturas { get; set; }
    public DbSet<DetallesFactura> DetallesFactura { get; set; }
    public DbSet<Producto> Productos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Factura>()
            .HasMany(f => f.Detalles)
            .WithOne(d => d.Factura)
            .HasForeignKey(d => d.IdFactura)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Cliente>().ToTable("TblClientes");
        modelBuilder.Entity<Factura>().ToTable("TblFacturas");
        modelBuilder.Entity<DetallesFactura>().ToTable("TblDetallesFactura");
        modelBuilder.Entity<Producto>().ToTable("CatProductos");
    }
}
