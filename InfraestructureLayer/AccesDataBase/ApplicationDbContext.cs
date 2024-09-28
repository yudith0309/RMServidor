using GestionAlmacenes.Entidad;
using GestionInventarios.Entidad;
using GestionPedidos.Entidad;
using GestionProveedores.Entidad;
using Microsoft.EntityFrameworkCore;
using RecepcionMercancia.Entidad;

namespace AccesDataBase;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Producto> Producto { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }
    public DbSet<OrdenDeCompra> OrdenesDeCompra { get; set; }
    public DbSet<ItemDeOrdenDeCompra> ItemsDeOrdenDeCompra { get; set; }
    public DbSet<Recepcion> Recepciones { get; set; }
    public DbSet<ItemRecepcion> ItemsRecepcion { get; set; }
    public DbSet<Almacen> Almacenes { get; set; }
    public DbSet<Inventario> Inventarios { get; set; }
    public DbSet<MovimientoInventario> MovimientosInventario { get; set; }
    public DbSet<Ubicacion> Ubicaciones { get; set; }
    public DbSet<MovimientosAlmacen> MovimientosAlmacen { get; set; }
    public DbSet<InventarioUbicaciones> InventarioUbicaciones { get; set; }
    public DbSet<ZonasAlmacen> ZonasAlmacen { get; set; }
    public DbSet<OrdenesTransferenciaInterna> OrdenesTransferenciaInterna { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Producto 
        modelBuilder
            .Entity<Producto>()
            .ToTable("Producto");
        //Provedor 
        modelBuilder
            .Entity<Proveedor>()
            .ToTable("Proveedor");

        //OrdenDeCompra 
        modelBuilder
            .Entity<OrdenDeCompra>()
            .ToTable("OrdenDeCompra");

        //Item Orden de compra

        modelBuilder
            .Entity<ItemDeOrdenDeCompra>()
            .ToTable("ItemDeOrdenDeCompra");
        modelBuilder
            .Entity<ItemDeOrdenDeCompra>()
            .Property(i => i.ItemDeOrdenDeCompraID)
            .HasDefaultValueSql("gen_random_uuid()");  // Generar un nuevo UUID por defecto

        // Configuración de relaciones
        modelBuilder
            .Entity<ItemDeOrdenDeCompra>()
            .HasOne(i => i.OrdenDeCompra)
            .WithMany()
            .HasForeignKey(i => i.OrdenDeCompraID)
            .OnDelete(DeleteBehavior.Cascade);  // Comportamiento de eliminación en cascada

        modelBuilder
            .Entity<ItemDeOrdenDeCompra>()
            .HasOne(i => i.Producto)
            .WithMany()
            .HasForeignKey(i => i.ProductoID)
            .OnDelete(DeleteBehavior.Cascade);
        //Recepcion 
        modelBuilder
            .Entity<Recepcion>()
            .ToTable("Recepciones");
        modelBuilder
            .Entity<Recepcion>()
            .HasOne<OrdenDeCompra>()
            .WithMany()
            .HasForeignKey(r => r.OrdenDeCompraID)
            .OnDelete(DeleteBehavior.Cascade);

        //Item Recepcion 
        modelBuilder
            .Entity<ItemRecepcion>()
            .ToTable("itemsRecepcion");

        modelBuilder
            .Entity<ItemRecepcion>()
            .HasOne<Recepcion>()
            .WithMany()
            .HasForeignKey(ir => ir.RecepcionID)
            .OnDelete(DeleteBehavior.Cascade);  // Configura el comportamiento al eliminar

        modelBuilder
            .Entity<ItemRecepcion>()
            .HasOne<Producto>()
            .WithMany()
            .HasForeignKey(ir => ir.ProductoID)
            .OnDelete(DeleteBehavior.Cascade);

        //Almacen
        modelBuilder
            .Entity<Almacen>()
            .ToTable("Almacenes");

        //Inventario 
        modelBuilder
            .Entity<Inventario>()
            .ToTable("Inventarios");

        modelBuilder.Entity<MovimientoInventario>()
            .HasOne<Producto>()
            .WithMany()
            .HasForeignKey(m => m.ProductoID)
            .OnDelete(DeleteBehavior.Restrict);

        //Movimientos Inventarios 
        modelBuilder
            .Entity<MovimientoInventario>()
            .ToTable("MovimientosInventario");

        modelBuilder.Entity<MovimientoInventario>()
            .HasOne<Almacen>()
            .WithMany()
            .HasForeignKey(m => m.AlmacenID)
            .OnDelete(DeleteBehavior.Restrict);

        //Ubicacion 
        modelBuilder
            .Entity<Ubicacion>()
            .ToTable("Ubicaciones");

        modelBuilder.Entity<Ubicacion>()
           .HasOne<Almacen>()
           .WithMany()
           .HasForeignKey(u => u.AlmacenID)
           .OnDelete(DeleteBehavior.Cascade);

        //Movimientos Almacen 
        modelBuilder
           .Entity<MovimientosAlmacen>()
           .ToTable("movimientosAlmacen");

        modelBuilder.Entity<MovimientosAlmacen>()
            .HasOne<Producto>()  // Asumiendo que tienes una entidad Producto
            .WithMany()
            .HasForeignKey(m => m.ProductoID)
            .OnDelete(DeleteBehavior.Restrict);  // Configurar comportamiento en eliminación

        //Inventarios Ubicacion
        modelBuilder
             .Entity<InventarioUbicaciones>()
             .ToTable("InventarioUbicaciones");

        modelBuilder.Entity<InventarioUbicaciones>()
            .HasOne<Ubicacion>()  // Relación con la tabla Ubicaciones
            .WithMany()
            .HasForeignKey(i => i.UbicacionID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        modelBuilder.Entity<InventarioUbicaciones>()
            .HasOne<Producto>()  // Relación con la tabla Productos
            .WithMany()
            .HasForeignKey(i => i.ProductoID)
            .OnDelete(DeleteBehavior.Restrict);

        //Zona Almacen 
        modelBuilder
            .Entity<ZonasAlmacen>()
            .ToTable("ZonasAlmacen");

        modelBuilder.Entity<ZonasAlmacen>()
           .HasOne<Almacen>()  // Relación con la tabla Almacenes
           .WithMany()
           .HasForeignKey(z => z.AlmacenID)
           .OnDelete(DeleteBehavior.Restrict);


        //OrndenesTransferencia Interna
        modelBuilder
            .Entity<OrdenesTransferenciaInterna>()
            .ToTable("OrdenesTransferenciaInterna");

        modelBuilder.Entity<OrdenesTransferenciaInterna>()
           .HasOne<Almacen>()  // Relación con la tabla Almacenes
           .WithMany()
           .HasForeignKey(o => o.AlmacenOrigenID)
           .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        modelBuilder.Entity<OrdenesTransferenciaInterna>()
            .HasOne<Almacen>()  // Relación con la tabla Almacenes
            .WithMany()
            .HasForeignKey(o => o.AlmacenDestinoID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        modelBuilder
            .Entity<OrdenesTransferenciaInterna>()
            .HasOne<Producto>()  // Relación con la tabla Productos
            .WithMany()
            .HasForeignKey(o => o.ProductoID)
            .OnDelete(DeleteBehavior.Restrict);

        //Pedido 

        modelBuilder
            .Entity<Pedido>()
            .ToTable("Pedido");
        modelBuilder
           .Entity<Pedido>()
           .HasOne<Cliente>()  // Relación con la tabla Clientes
           .WithMany()
           .HasForeignKey(p => p.ClienteID)
           .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Cliente 
        modelBuilder
           .Entity<Cliente>()
           .ToTable("Cliente");

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Nombre)
            .IsRequired()
            .HasMaxLength(100);  // Configurar propiedades del nombre

        modelBuilder.Entity<Cliente>()
            .Property(c => c.CorreoElectronico)
            .IsRequired()
            .HasMaxLength(100);  // Configurar propiedades del correo electrónico

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Telefono)
            .HasMaxLength(20);  // Configurar propiedades del teléfono
        modelBuilder.Entity<Cliente>()
            .Property(c => c.Direccion)
            .HasMaxLength(255);  // Configurar propiedades de la dirección

        // Configuración de relaciones con la tabla Pedidos
        modelBuilder.Entity<Pedido>()
            .HasOne<Cliente>()  // Relación con la tabla Clientes
            .WithMany()
            .HasForeignKey(p => p.ClienteID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación
    }
}


