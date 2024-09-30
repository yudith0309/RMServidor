using GestionAlmacenes.Entidad;
using GestionCompras.Entidad;
using GestionDevoluciones.Entidad;
using GestionInventarios.Entidad;
using GestionPedidos.Entidad;
using GestionProveedores.Entidad;
using Microsoft.EntityFrameworkCore;
using RecepcionMercancia.Entidad;
using TransporteEnvios.Entidad;

namespace AccesDataBase;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Producto> Producto { get; set; }
    public DbSet<Proveedor> Proveedores { get; set; }
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
    public DbSet<DetallesPedido> DetallesPedidos { get; set; }
    public DbSet<Devoluciones> Devoluciones { get; set; }
    public DbSet<HistorialEstadoPedido> HistorialEstadoPedido { get; set; }
    public DbSet<DetallesDevolucion> DetallesDevolucion { get; set; }
    public DbSet<HistorialEstadoDevolucion> HistorialEstadoDevolucion { get; set; }
    public DbSet<PagosDevoluciones> PagosDevoluciones { get; set; }
    public DbSet<OrdenesCompra> OrdenesCompra { get; set; }
    public DbSet<PagosProveedores> PagosProveedores { get; set; }
    public DbSet<HistorialProveedor> HistorialProveedores { get; set; }
    public DbSet<OrdenesEnvio> OrdenesEnvios { get; set; }
    public DbSet<Transportista> Transportistas { get; set; }
    public DbSet<SeguimientoEnvio> SeguimientoEnvios { get; set; }
    public DbSet<CostosEnvio> CostosEnvios { get; set; }
    public DbSet<DocumentacionEnvio> DocumentacionesEnvio { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Tabla Producto 
        modelBuilder
            .Entity<Producto>()
            .ToTable("Producto")
            .HasKey(p => p.ProductoID);

        //Tabla Provedor 
        modelBuilder
            .Entity<Proveedor>()
            .ToTable("Proveedor")
            .HasKey(p => p.ProveedorID);

        //Tabla OrdenDeCompra 
        modelBuilder
            .Entity<OrdenesCompra>()
            .ToTable("OrdenesCompra")
            .HasKey(p => p.OrdenCompraID);
        // Configuración de relaciones
        modelBuilder
            .Entity<OrdenesCompra>()
            .HasOne<Proveedor>()  // Relación con la tabla Proveedor
            .WithMany()
            .HasForeignKey(p => p.ProveedorID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Item Orden de compra
        modelBuilder
            .Entity<ItemDeOrdenDeCompra>()
            .ToTable("ItemDeOrdenDeCompra")
            .HasKey(p => p.ItemDeOrdenDeCompraID);

        // Configuración de relaciones
        modelBuilder
            .Entity<ItemDeOrdenDeCompra>()
            .HasOne<OrdenesCompra>()  // Relación con la tabla Orden de Compra
            .WithMany()
            .HasForeignKey(p => p.OrdenDeCompraID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        modelBuilder
            .Entity<ItemDeOrdenDeCompra>()
            .HasOne<Producto>()  // Relación con la tabla Producto
            .WithMany()
            .HasForeignKey(p => p.ProductoID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Recepcion 
        modelBuilder
            .Entity<Recepcion>()
            .ToTable("Recepciones")
            .HasKey(p => p.RecepcionID);

        modelBuilder
            .Entity<Recepcion>()
            .HasOne<OrdenesCompra>()  // Relación con la tabla Orden de Compra
            .WithMany()
            .HasForeignKey(p => p.OrdenDeCompraID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        modelBuilder
            .Entity<Recepcion>()
            .HasOne<OrdenesCompra>()
            .WithMany()
            .HasForeignKey(r => r.OrdenDeCompraID)
            .OnDelete(DeleteBehavior.Cascade);

        //Tabla Item Recepcion 
        modelBuilder
            .Entity<ItemRecepcion>()
            .ToTable("ItemsRecepcion")
            .HasKey(p => p.RecepccionItemID);

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

        //Tabla Almacen
        modelBuilder
            .Entity<Almacen>()
            .ToTable("Almacenes")
            .HasKey(p => p.AlmacenID);

        //Tabla Inventario 
        modelBuilder
            .Entity<Inventario>()
            .ToTable("Inventarios")
            .HasKey(p => p.InventarioID);
        modelBuilder
            .Entity<Inventario>()
            .HasOne<Almacen>()
            .WithMany()
            .HasForeignKey(ir => ir.AlmacenID)
            .OnDelete(DeleteBehavior.Cascade);
        modelBuilder
            .Entity<Inventario>()
            .HasOne<Producto>()
            .WithMany()
            .HasForeignKey(ir => ir.ProductoID)
            .OnDelete(DeleteBehavior.Cascade);        

        //Tabla Movimientos Inventarios 
        modelBuilder
            .Entity<MovimientoInventario>()
            .ToTable("MovimientosInventario")
            .HasKey(p => p.MovimientoID);

        modelBuilder
            .Entity<MovimientoInventario>()
            .HasOne<Almacen>()
            .WithMany()
            .HasForeignKey(m => m.AlmacenID)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder
            .Entity<MovimientoInventario>()
            .HasOne<Producto>()
            .WithMany()
            .HasForeignKey(m => m.ProductoID)
            .OnDelete(DeleteBehavior.Restrict);

        //Tabla Ubicacion 
        modelBuilder
            .Entity<Ubicacion>()
            .ToTable("Ubicaciones")
            .HasKey(p => p.UbicacionID);

        modelBuilder
           .Entity<Ubicacion>()
           .HasOne<Almacen>()
           .WithMany()
           .HasForeignKey(u => u.AlmacenID)
           .OnDelete(DeleteBehavior.Cascade);

        //Tabla Movimientos Almacen 
        modelBuilder
           .Entity<MovimientosAlmacen>()
           .ToTable("movimientosAlmacen")
           .HasKey(p => p.MovimientoID);

        modelBuilder
            .Entity<MovimientosAlmacen>()
            .HasOne<Producto>()  // Asumiendo que tienes una entidad Producto
            .WithMany()
            .HasForeignKey(m => m.ProductoID)
            .OnDelete(DeleteBehavior.Restrict);  // Configurar comportamiento en eliminación
        modelBuilder
            .Entity<MovimientosAlmacen>()
            .HasOne<Ubicacion>()  // Asumiendo que tienes una entidad Ubicaciones
            .WithMany()
            .HasForeignKey(m => m.UbicacionOrigenID)
            .OnDelete(DeleteBehavior.Restrict);  // Configurar comportamiento en eliminación
        modelBuilder
            .Entity<MovimientosAlmacen>()
            .HasOne<Ubicacion>()  // Asumiendo que tienes una entidad Ubicaciones
            .WithMany()
            .HasForeignKey(m => m.UbicacionDestinoID)
            .OnDelete(DeleteBehavior.Restrict);  // Configurar comportamiento en eliminación

        //Tabla Inventarios Ubicacion
        modelBuilder
             .Entity<InventarioUbicaciones>()
             .ToTable("InventarioUbicaciones")
             .HasKey(p => p.InventarioUbicacionID);

        modelBuilder
            .Entity<InventarioUbicaciones>()
            .HasOne<Ubicacion>()  // Relación con la tabla Ubicaciones
            .WithMany()
            .HasForeignKey(i => i.UbicacionID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        modelBuilder
            .Entity<InventarioUbicaciones>()
            .HasOne<Producto>()  // Relación con la tabla Productos
            .WithMany()
            .HasForeignKey(i => i.ProductoID)
            .OnDelete(DeleteBehavior.Restrict);

        //Tabla Zona Almacen 
        modelBuilder
            .Entity<ZonasAlmacen>()
            .ToTable("ZonasAlmacen")
            .HasKey(p => p.ZonaID);

        modelBuilder
           .Entity<ZonasAlmacen>()
           .HasOne<Almacen>()  // Relación con la tabla Almacenes
           .WithMany()
           .HasForeignKey(z => z.AlmacenID)
           .OnDelete(DeleteBehavior.Restrict);

        //Tabla OrdenesTransferencia Interna
        modelBuilder
            .Entity<OrdenesTransferenciaInterna>()
            .ToTable("OrdenesTransferenciaInterna")
            .HasKey(p => p.OrdenTransferenciaID);

        modelBuilder
           .Entity<OrdenesTransferenciaInterna>()
           .HasOne<Almacen>()  // Relación con la tabla Almacenes
           .WithMany()
           .HasForeignKey(o => o.AlmacenOrigenID)
           .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        modelBuilder
            .Entity<OrdenesTransferenciaInterna>()
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

        //Tabla Pedido 
        modelBuilder
            .Entity<Pedido>()
            .ToTable("Pedido")
            .HasKey(p => p.PedidoID);

        modelBuilder
           .Entity<Pedido>()
           .HasOne<Cliente>()  // Relación con la tabla Clientes
           .WithMany()
           .HasForeignKey(p => p.ClienteID)
           .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Cliente 
        modelBuilder
           .Entity<Cliente>()
           .ToTable("Cliente")
           .HasKey(p => p.ClienteID);       

        //Tabla Detalles Pedido 
        modelBuilder
            .Entity<DetallesPedido>()
            .ToTable("DetallesPedido")
            .HasKey(p => p.DetalleID);

        //Tabla Relaciones
        modelBuilder
            .Entity<DetallesPedido>()
            .HasOne<Producto>()  // Relación con la tabla Producto
            .WithMany()
            .HasForeignKey(p => p.ProductoID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        modelBuilder
            .Entity<DetallesPedido>()
            .HasOne<Pedido>()  // Relación con la tabla Pedido
            .WithMany()
            .HasForeignKey(p => p.PedidoID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla pagos 

        modelBuilder
            .Entity<Pagos>()
            .ToTable("Pagos")
            .HasKey(p => p.PagoID);  // Clave primaria del pago

        modelBuilder
            .Entity<Pagos>()
            .HasOne<Pedido>()  // Relación con la tabla Pedidos
            .WithMany()
            .HasForeignKey(p => p.PedidoID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Devoluciones 
        modelBuilder
            .Entity<Devoluciones>()
            .ToTable("Devoluciones")
            .HasKey(p => p.DevolucionID);

        modelBuilder
            .Entity<Devoluciones>()
            .HasOne<Pedido>()  // Relación con la tabla Pedidos
            .WithMany()
            .HasForeignKey(p => p.PedidoID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Historial de devoluciones 
        modelBuilder
            .Entity<HistorialEstadoPedido>()
            .ToTable("HistorialEstadoPedido")
            .HasKey(p => p.HistorialID);

        modelBuilder
            .Entity<HistorialEstadoPedido>()
            .HasOne<Pedido>()  // Relación con la tabla Pedidos
            .WithMany()
            .HasForeignKey(p => p.PedidoID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Detalles de devolucion 

        modelBuilder
           .Entity<DetallesDevolucion>()
           .ToTable("DetallesDevolucion")
           .HasKey(p => p.DetalleDevolucionID);

        modelBuilder
            .Entity<DetallesDevolucion>()
            .HasOne<Producto>()  // Relación con la tabla Pedidos
            .WithMany()
            .HasForeignKey(p => p.ProductoID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        modelBuilder
            .Entity<DetallesDevolucion>()
            .HasOne<Devoluciones>()  // Relación con la tabla Pedidos
            .WithMany()
            .HasForeignKey(p => p.DevolucionID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla HistorialEstadoDevolucion
        modelBuilder
          .Entity<HistorialEstadoDevolucion>()
          .ToTable("HistorialEstadoDevolucion")
          .HasKey(p => p.HistorialDevolucionID);

        modelBuilder
            .Entity<HistorialEstadoDevolucion>()
            .HasOne<Devoluciones>()  // Relación con la tabla devoluciones
            .WithMany()
            .HasForeignKey(p => p.DevolucionID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Pagos Devoluciones 
        modelBuilder
          .Entity<PagosDevoluciones>()
          .ToTable("PagosDevoluciones")
          .HasKey(p => p.PagoDevolucionID);

        modelBuilder
            .Entity<PagosDevoluciones>()
            .HasOne<Devoluciones>()  // Relación con la tabla devoluciones
            .WithMany()
            .HasForeignKey(p => p.DevolucionID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Detalles Orden de Compras 
        modelBuilder
          .Entity<DetallesOrdenCompra>()
          .ToTable("DetallesOrdenCompra")
          .HasKey(p => p.DetalleOrdenCompraID);

        modelBuilder
            .Entity<DetallesOrdenCompra>()
            .HasOne<OrdenesCompra>()  // Relación con la tabla Orden de Compras
            .WithMany()
            .HasForeignKey(p => p.OrdenCompraID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        modelBuilder
            .Entity<DetallesOrdenCompra>()
            .HasOne<Producto>()  // Relación con la tabla Producto
            .WithMany()
            .HasForeignKey(p => p.ProductoID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Detalles Pago a proveedores
        modelBuilder
          .Entity<PagosProveedores>()
          .ToTable("PagosProveedores")
          .HasKey(p => p.PagoProveedorID);

        modelBuilder
            .Entity<PagosProveedores>()
            .HasOne<Proveedor>()  // Relación con la tabla Proveedor
            .WithMany()
            .HasForeignKey(p => p.ProveedorID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Detalles Historial de proveedores
        modelBuilder
          .Entity<HistorialProveedor>()
          .ToTable("HistorialProveedor")
          .HasKey(p => p.HistorialProveedorID);

        modelBuilder
            .Entity<HistorialProveedor>()
            .HasOne<Proveedor>()  // Relación con la tabla provedor 
            .WithMany()
            .HasForeignKey(p => p.ProveedorID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Ordenes de Envio
        modelBuilder
          .Entity<OrdenesEnvio>()
          .ToTable("OrdenesEnvio")
          .HasKey(p => p.OrdenEnvioID);

        modelBuilder
            .Entity<OrdenesEnvio>()
            .HasOne<Pedido>()  // Relación con la tabla pedido 
            .WithMany()
            .HasForeignKey(p => p.PedidoID)
            .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        modelBuilder
           .Entity<OrdenesEnvio>()
           .HasOne<Transportista>()  // Relación con la tabla pedido 
           .WithMany()
           .HasForeignKey(p => p.TransportistaID)
           .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Transportista
        modelBuilder
          .Entity<Transportista>()
          .ToTable("Transportista")
          .HasKey(p => p.TransportistaID);

        //Tabla Rutas
        modelBuilder
          .Entity<Ruta>()
          .ToTable("Ruta")
          .HasKey(p => p.RutaID);

        modelBuilder
           .Entity<Ruta>()
           .HasOne<OrdenesEnvio>()  // Relación con la tabla Orden Envio  
           .WithMany()
           .HasForeignKey(p => p.OrdenEnvioID)
           .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla SeguimientoEnvio 
        modelBuilder
          .Entity<SeguimientoEnvio>()
          .ToTable("SeguimientoEnvio")
          .HasKey(p => p.SeguimientoID);

        modelBuilder
           .Entity<SeguimientoEnvio>()
           .HasOne<OrdenesEnvio>()  // Relación con la tabla Orden Envio  
           .WithMany()
           .HasForeignKey(p => p.OrdenEnvioID)
           .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Costo Envio  
        modelBuilder
          .Entity<CostosEnvio>()
          .ToTable("CostosEnvio")
          .HasKey(p => p.CostoEnvioID);

        modelBuilder
           .Entity<CostosEnvio>()
           .HasOne<OrdenesEnvio>()  // Relación con la tabla Orden Envio  
           .WithMany()
           .HasForeignKey(p => p.OrdenEnvioID)
           .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

        //Tabla Documentacion envio 
        modelBuilder
          .Entity<DocumentacionEnvio>()
          .ToTable("DocumentacionEnvio")
          .HasKey(p => p.DocumentacionID);

        modelBuilder
           .Entity<DocumentacionEnvio>()
           .HasOne<OrdenesEnvio>()  // Relación con la tabla Orden Envio  
           .WithMany()
           .HasForeignKey(p => p.OrdenEnvioID)
           .OnDelete(DeleteBehavior.Restrict);  // Comportamiento en eliminación

    }
}


