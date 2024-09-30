using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccesDataBase.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Almacenes",
                columns: table => new
                {
                    almacen_id = table.Column<Guid>(type: "uuid", nullable: false),
                    nombre_almacen = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ubicacion = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Almacenes", x => x.almacen_id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteID = table.Column<Guid>(type: "uuid", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CorreoElectronico = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Direccion = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    productoID = table.Column<Guid>(type: "uuid", nullable: false),
                    codigoProducto = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    nombreProducto = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    unidadMedida = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.productoID);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    proveedor_id = table.Column<Guid>(type: "uuid", nullable: false),
                    nombre_proveedor = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    informacion_contacto = table.Column<string>(type: "text", nullable: false),
                    direccion = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.proveedor_id);
                });

            migrationBuilder.CreateTable(
                name: "Transportista",
                columns: table => new
                {
                    transportistaID = table.Column<Guid>(type: "uuid", nullable: false),
                    nombreTransportista = table.Column<string>(type: "text", nullable: false),
                    telefono = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    direccion = table.Column<string>(type: "text", nullable: false),
                    tarifaBase = table.Column<decimal>(type: "numeric", nullable: false),
                    estado = table.Column<string>(type: "text", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportista", x => x.transportistaID);
                });

            migrationBuilder.CreateTable(
                name: "Ubicaciones",
                columns: table => new
                {
                    ubicacionID = table.Column<Guid>(type: "uuid", nullable: false),
                    almacenID = table.Column<Guid>(type: "uuid", nullable: false),
                    codigoUbicacion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    tipoUbicacion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    capacidadUbicacion = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    ocupado = table.Column<bool>(type: "boolean", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicaciones", x => x.ubicacionID);
                    table.ForeignKey(
                        name: "FK_Ubicaciones_Almacenes_almacenID",
                        column: x => x.almacenID,
                        principalTable: "Almacenes",
                        principalColumn: "almacen_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ZonasAlmacen",
                columns: table => new
                {
                    zonaID = table.Column<Guid>(type: "uuid", nullable: false),
                    almacenID = table.Column<Guid>(type: "uuid", nullable: false),
                    nombreZona = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    tipoZona = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    capacidadZona = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZonasAlmacen", x => x.zonaID);
                    table.ForeignKey(
                        name: "FK_ZonasAlmacen_Almacenes_almacenID",
                        column: x => x.almacenID,
                        principalTable: "Almacenes",
                        principalColumn: "almacen_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    PedidoID = table.Column<Guid>(type: "uuid", nullable: false),
                    ClienteID = table.Column<Guid>(type: "uuid", nullable: false),
                    FechaPedido = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EstadoPedido = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Total = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    MetodoPago = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.PedidoID);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    inventario_id = table.Column<Guid>(type: "uuid", nullable: false),
                    almacen_id = table.Column<Guid>(type: "uuid", nullable: false),
                    producto_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cantidad_disponible = table.Column<int>(type: "integer", nullable: false),
                    fecha_ultima_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.inventario_id);
                    table.ForeignKey(
                        name: "FK_Inventarios_Almacenes_almacen_id",
                        column: x => x.almacen_id,
                        principalTable: "Almacenes",
                        principalColumn: "almacen_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventarios_Producto_producto_id",
                        column: x => x.producto_id,
                        principalTable: "Producto",
                        principalColumn: "productoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovimientosInventario",
                columns: table => new
                {
                    movimientoID = table.Column<Guid>(type: "uuid", nullable: false),
                    productoID = table.Column<Guid>(type: "uuid", nullable: false),
                    almacenID = table.Column<Guid>(type: "uuid", nullable: false),
                    tipoMovimiento = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    cantidad = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    fechaMovimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    documentoRelacionado = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    creadoPor = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovimientosInventario", x => x.movimientoID);
                    table.ForeignKey(
                        name: "FK_MovimientosInventario_Almacenes_almacenID",
                        column: x => x.almacenID,
                        principalTable: "Almacenes",
                        principalColumn: "almacen_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MovimientosInventario_Producto_productoID",
                        column: x => x.productoID,
                        principalTable: "Producto",
                        principalColumn: "productoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesTransferenciaInterna",
                columns: table => new
                {
                    ordenTransferenciaID = table.Column<Guid>(type: "uuid", nullable: false),
                    almacenOrigenID = table.Column<Guid>(type: "uuid", nullable: false),
                    almacenDestinoID = table.Column<Guid>(type: "uuid", nullable: false),
                    productoID = table.Column<Guid>(type: "uuid", nullable: false),
                    cantidadTransferida = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    fechaTransferencia = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    estadoTransferencia = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    usuarioResponsable = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesTransferenciaInterna", x => x.ordenTransferenciaID);
                    table.ForeignKey(
                        name: "FK_OrdenesTransferenciaInterna_Almacenes_almacenDestinoID",
                        column: x => x.almacenDestinoID,
                        principalTable: "Almacenes",
                        principalColumn: "almacen_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesTransferenciaInterna_Almacenes_almacenOrigenID",
                        column: x => x.almacenOrigenID,
                        principalTable: "Almacenes",
                        principalColumn: "almacen_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesTransferenciaInterna_Producto_productoID",
                        column: x => x.productoID,
                        principalTable: "Producto",
                        principalColumn: "productoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistorialProveedor",
                columns: table => new
                {
                    historialProveedorID = table.Column<Guid>(type: "uuid", nullable: false),
                    proveedorID = table.Column<Guid>(type: "uuid", nullable: false),
                    fechaEvaluacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    calificacion = table.Column<int>(type: "integer", nullable: false),
                    comentarios = table.Column<string>(type: "text", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialProveedor", x => x.historialProveedorID);
                    table.ForeignKey(
                        name: "FK_HistorialProveedor_Proveedor_proveedorID",
                        column: x => x.proveedorID,
                        principalTable: "Proveedor",
                        principalColumn: "proveedor_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesCompra",
                columns: table => new
                {
                    ordenCompraID = table.Column<Guid>(type: "uuid", nullable: false),
                    proveedorID = table.Column<Guid>(type: "uuid", nullable: false),
                    fechaOrden = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaEntregaEstimada = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    total = table.Column<decimal>(type: "numeric", nullable: false),
                    estado = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesCompra", x => x.ordenCompraID);
                    table.ForeignKey(
                        name: "FK_OrdenesCompra_Proveedor_proveedorID",
                        column: x => x.proveedorID,
                        principalTable: "Proveedor",
                        principalColumn: "proveedor_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PagosProveedores",
                columns: table => new
                {
                    pagoProveedorID = table.Column<Guid>(type: "uuid", nullable: false),
                    proveedorID = table.Column<Guid>(type: "uuid", nullable: false),
                    monto = table.Column<decimal>(type: "numeric", nullable: false),
                    fechaPago = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    metodoPago = table.Column<string>(type: "text", nullable: false),
                    estadoPago = table.Column<string>(type: "text", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagosProveedores", x => x.pagoProveedorID);
                    table.ForeignKey(
                        name: "FK_PagosProveedores_Proveedor_proveedorID",
                        column: x => x.proveedorID,
                        principalTable: "Proveedor",
                        principalColumn: "proveedor_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventarioUbicaciones",
                columns: table => new
                {
                    inventarioUbicacionID = table.Column<Guid>(type: "uuid", nullable: false),
                    ubicacionID = table.Column<Guid>(type: "uuid", nullable: false),
                    productoID = table.Column<Guid>(type: "uuid", nullable: false),
                    cantidadDisponible = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    cantidadReservada = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    fechaUltimaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventarioUbicaciones", x => x.inventarioUbicacionID);
                    table.ForeignKey(
                        name: "FK_InventarioUbicaciones_Producto_productoID",
                        column: x => x.productoID,
                        principalTable: "Producto",
                        principalColumn: "productoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventarioUbicaciones_Ubicaciones_ubicacionID",
                        column: x => x.ubicacionID,
                        principalTable: "Ubicaciones",
                        principalColumn: "ubicacionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "movimientosAlmacen",
                columns: table => new
                {
                    movimientoID = table.Column<Guid>(type: "uuid", nullable: false),
                    productoID = table.Column<Guid>(type: "uuid", nullable: false),
                    ubicacionOrigenID = table.Column<Guid>(type: "uuid", nullable: false),
                    ubicacionDestinoID = table.Column<Guid>(type: "uuid", nullable: false),
                    TipoMovimiento = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CantidadMovida = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    FechaMovimiento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DocumentoRelacionado = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    UsuarioResponsable = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movimientosAlmacen", x => x.movimientoID);
                    table.ForeignKey(
                        name: "FK_movimientosAlmacen_Producto_productoID",
                        column: x => x.productoID,
                        principalTable: "Producto",
                        principalColumn: "productoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_movimientosAlmacen_Ubicaciones_ubicacionDestinoID",
                        column: x => x.ubicacionDestinoID,
                        principalTable: "Ubicaciones",
                        principalColumn: "ubicacionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_movimientosAlmacen_Ubicaciones_ubicacionOrigenID",
                        column: x => x.ubicacionOrigenID,
                        principalTable: "Ubicaciones",
                        principalColumn: "ubicacionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesPedido",
                columns: table => new
                {
                    detalleID = table.Column<Guid>(type: "uuid", nullable: false),
                    pedidoID = table.Column<Guid>(type: "uuid", nullable: false),
                    productoID = table.Column<Guid>(type: "uuid", nullable: false),
                    cantidad = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    precioUnitario = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    subtotal = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesPedido", x => x.detalleID);
                    table.ForeignKey(
                        name: "FK_DetallesPedido_Pedido_pedidoID",
                        column: x => x.pedidoID,
                        principalTable: "Pedido",
                        principalColumn: "PedidoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesPedido_Producto_productoID",
                        column: x => x.productoID,
                        principalTable: "Producto",
                        principalColumn: "productoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Devoluciones",
                columns: table => new
                {
                    devolucionID = table.Column<Guid>(type: "uuid", nullable: false),
                    pedidoID = table.Column<Guid>(type: "uuid", nullable: false),
                    fechaDevolucion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    motivo = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    estadoDevolucion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devoluciones", x => x.devolucionID);
                    table.ForeignKey(
                        name: "FK_Devoluciones_Pedido_pedidoID",
                        column: x => x.pedidoID,
                        principalTable: "Pedido",
                        principalColumn: "PedidoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistorialEstadoPedido",
                columns: table => new
                {
                    historialID = table.Column<Guid>(type: "uuid", nullable: false),
                    pedidoID = table.Column<Guid>(type: "uuid", nullable: false),
                    estadoAnterior = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    estadoNuevo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    fechaCambio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    usuarioResponsable = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialEstadoPedido", x => x.historialID);
                    table.ForeignKey(
                        name: "FK_HistorialEstadoPedido_Pedido_pedidoID",
                        column: x => x.pedidoID,
                        principalTable: "Pedido",
                        principalColumn: "PedidoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdenesEnvio",
                columns: table => new
                {
                    ordenEnvioID = table.Column<Guid>(type: "uuid", nullable: false),
                    pedidoID = table.Column<Guid>(type: "uuid", nullable: false),
                    transportistaID = table.Column<Guid>(type: "uuid", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    estado = table.Column<string>(type: "text", nullable: false),
                    fechaEnvio = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    fechaEntregaEstimada = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    costoEnvio = table.Column<decimal>(type: "numeric", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenesEnvio", x => x.ordenEnvioID);
                    table.ForeignKey(
                        name: "FK_OrdenesEnvio_Pedido_pedidoID",
                        column: x => x.pedidoID,
                        principalTable: "Pedido",
                        principalColumn: "PedidoID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrdenesEnvio_Transportista_transportistaID",
                        column: x => x.transportistaID,
                        principalTable: "Transportista",
                        principalColumn: "transportistaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    pagoID = table.Column<Guid>(type: "uuid", nullable: false),
                    pedidoID = table.Column<Guid>(type: "uuid", nullable: false),
                    monto = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    fechaPago = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    metodoPago = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    estadoPago = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.pagoID);
                    table.ForeignKey(
                        name: "FK_Pagos_Pedido_pedidoID",
                        column: x => x.pedidoID,
                        principalTable: "Pedido",
                        principalColumn: "PedidoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetallesOrdenCompra",
                columns: table => new
                {
                    detalleOrdenCompraID = table.Column<Guid>(type: "uuid", nullable: false),
                    ordenCompraID = table.Column<Guid>(type: "uuid", nullable: false),
                    productoID = table.Column<Guid>(type: "uuid", nullable: false),
                    cantidad = table.Column<decimal>(type: "numeric", nullable: false),
                    precioUnitario = table.Column<decimal>(type: "numeric", nullable: false),
                    subtotal = table.Column<decimal>(type: "numeric", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesOrdenCompra", x => x.detalleOrdenCompraID);
                    table.ForeignKey(
                        name: "FK_DetallesOrdenCompra_OrdenesCompra_ordenCompraID",
                        column: x => x.ordenCompraID,
                        principalTable: "OrdenesCompra",
                        principalColumn: "ordenCompraID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesOrdenCompra_Producto_productoID",
                        column: x => x.productoID,
                        principalTable: "Producto",
                        principalColumn: "productoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemDeOrdenDeCompra",
                columns: table => new
                {
                    itemDeOrdenDeCompraID = table.Column<Guid>(type: "uuid", nullable: false),
                    ordenDeCompraID = table.Column<Guid>(type: "uuid", nullable: false),
                    producto_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cantidad_ordenada = table.Column<int>(type: "integer", nullable: false),
                    precio_unitario = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDeOrdenDeCompra", x => x.itemDeOrdenDeCompraID);
                    table.ForeignKey(
                        name: "FK_ItemDeOrdenDeCompra_OrdenesCompra_ordenDeCompraID",
                        column: x => x.ordenDeCompraID,
                        principalTable: "OrdenesCompra",
                        principalColumn: "ordenCompraID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItemDeOrdenDeCompra_Producto_producto_id",
                        column: x => x.producto_id,
                        principalTable: "Producto",
                        principalColumn: "productoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recepciones",
                columns: table => new
                {
                    recepcion_id = table.Column<Guid>(type: "uuid", nullable: false),
                    orden_de_compra_id = table.Column<Guid>(type: "uuid", nullable: false),
                    fecha_recepcion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    recibido_por = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    estado = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    fecha_creacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_actualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepciones", x => x.recepcion_id);
                    table.ForeignKey(
                        name: "FK_Recepciones_OrdenesCompra_orden_de_compra_id",
                        column: x => x.orden_de_compra_id,
                        principalTable: "OrdenesCompra",
                        principalColumn: "ordenCompraID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesDevolucion",
                columns: table => new
                {
                    detalleDevolucionID = table.Column<Guid>(type: "uuid", nullable: false),
                    devolucionID = table.Column<Guid>(type: "uuid", nullable: false),
                    productoID = table.Column<Guid>(type: "uuid", nullable: false),
                    cantidad = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    estadoProducto = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesDevolucion", x => x.detalleDevolucionID);
                    table.ForeignKey(
                        name: "FK_DetallesDevolucion_Devoluciones_devolucionID",
                        column: x => x.devolucionID,
                        principalTable: "Devoluciones",
                        principalColumn: "devolucionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetallesDevolucion_Producto_productoID",
                        column: x => x.productoID,
                        principalTable: "Producto",
                        principalColumn: "productoID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistorialEstadoDevolucion",
                columns: table => new
                {
                    historialDevolucionID = table.Column<Guid>(type: "uuid", nullable: false),
                    devolucionID = table.Column<Guid>(type: "uuid", nullable: false),
                    estadoAnterior = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    estadoNuevo = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    fechaCambio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    usuarioResponsable = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialEstadoDevolucion", x => x.historialDevolucionID);
                    table.ForeignKey(
                        name: "FK_HistorialEstadoDevolucion_Devoluciones_devolucionID",
                        column: x => x.devolucionID,
                        principalTable: "Devoluciones",
                        principalColumn: "devolucionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PagosDevoluciones",
                columns: table => new
                {
                    pagoDevolucionID = table.Column<Guid>(type: "uuid", nullable: false),
                    devolucionID = table.Column<Guid>(type: "uuid", nullable: false),
                    montoReembolsado = table.Column<decimal>(type: "numeric", nullable: false),
                    fechaReembolso = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    metodoPago = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    estadoReembolso = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagosDevoluciones", x => x.pagoDevolucionID);
                    table.ForeignKey(
                        name: "FK_PagosDevoluciones_Devoluciones_devolucionID",
                        column: x => x.devolucionID,
                        principalTable: "Devoluciones",
                        principalColumn: "devolucionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CostosEnvio",
                columns: table => new
                {
                    costoEnvioID = table.Column<Guid>(type: "uuid", nullable: false),
                    ordenEnvioID = table.Column<Guid>(type: "uuid", nullable: false),
                    costoBase = table.Column<decimal>(type: "numeric", nullable: false),
                    costoAdicional = table.Column<decimal>(type: "numeric", nullable: false),
                    descuento = table.Column<decimal>(type: "numeric", nullable: false),
                    costoTotal = table.Column<decimal>(type: "numeric", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostosEnvio", x => x.costoEnvioID);
                    table.ForeignKey(
                        name: "FK_CostosEnvio_OrdenesEnvio_ordenEnvioID",
                        column: x => x.ordenEnvioID,
                        principalTable: "OrdenesEnvio",
                        principalColumn: "ordenEnvioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentacionEnvio",
                columns: table => new
                {
                    documentacionID = table.Column<Guid>(type: "uuid", nullable: false),
                    ordenEnvioID = table.Column<Guid>(type: "uuid", nullable: false),
                    tipoDocumento = table.Column<string>(type: "text", nullable: false),
                    rutaArchivo = table.Column<string>(type: "text", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentacionEnvio", x => x.documentacionID);
                    table.ForeignKey(
                        name: "FK_DocumentacionEnvio_OrdenesEnvio_ordenEnvioID",
                        column: x => x.ordenEnvioID,
                        principalTable: "OrdenesEnvio",
                        principalColumn: "ordenEnvioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ruta",
                columns: table => new
                {
                    rutaID = table.Column<Guid>(type: "uuid", nullable: false),
                    ordenEnvioID = table.Column<Guid>(type: "uuid", nullable: false),
                    puntoSalida = table.Column<string>(type: "text", nullable: false),
                    puntoDestino = table.Column<string>(type: "text", nullable: false),
                    distancia = table.Column<decimal>(type: "numeric", nullable: false),
                    tiempoEstimado = table.Column<string>(type: "text", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruta", x => x.rutaID);
                    table.ForeignKey(
                        name: "FK_Ruta_OrdenesEnvio_ordenEnvioID",
                        column: x => x.ordenEnvioID,
                        principalTable: "OrdenesEnvio",
                        principalColumn: "ordenEnvioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeguimientoEnvio",
                columns: table => new
                {
                    seguimientoID = table.Column<Guid>(type: "uuid", nullable: false),
                    ordenEnvioID = table.Column<Guid>(type: "uuid", nullable: false),
                    fechaRegistro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    estado = table.Column<string>(type: "text", nullable: false),
                    ubicacionActual = table.Column<string>(type: "text", nullable: false),
                    comentarios = table.Column<string>(type: "text", nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeguimientoEnvio", x => x.seguimientoID);
                    table.ForeignKey(
                        name: "FK_SeguimientoEnvio_OrdenesEnvio_ordenEnvioID",
                        column: x => x.ordenEnvioID,
                        principalTable: "OrdenesEnvio",
                        principalColumn: "ordenEnvioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemsRecepcion",
                columns: table => new
                {
                    recepccionItemID = table.Column<Guid>(type: "uuid", nullable: false),
                    recepcionID = table.Column<Guid>(type: "uuid", nullable: false),
                    productoID = table.Column<Guid>(type: "uuid", nullable: false),
                    cantidadRecibida = table.Column<int>(type: "integer", nullable: false),
                    condicion = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    comentarios = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsRecepcion", x => x.recepccionItemID);
                    table.ForeignKey(
                        name: "FK_ItemsRecepcion_Producto_productoID",
                        column: x => x.productoID,
                        principalTable: "Producto",
                        principalColumn: "productoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemsRecepcion_Recepciones_recepcionID",
                        column: x => x.recepcionID,
                        principalTable: "Recepciones",
                        principalColumn: "recepcion_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CostosEnvio_ordenEnvioID",
                table: "CostosEnvio",
                column: "ordenEnvioID");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDevolucion_devolucionID",
                table: "DetallesDevolucion",
                column: "devolucionID");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesDevolucion_productoID",
                table: "DetallesDevolucion",
                column: "productoID");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesOrdenCompra_ordenCompraID",
                table: "DetallesOrdenCompra",
                column: "ordenCompraID");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesOrdenCompra_productoID",
                table: "DetallesOrdenCompra",
                column: "productoID");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPedido_pedidoID",
                table: "DetallesPedido",
                column: "pedidoID");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPedido_productoID",
                table: "DetallesPedido",
                column: "productoID");

            migrationBuilder.CreateIndex(
                name: "IX_Devoluciones_pedidoID",
                table: "Devoluciones",
                column: "pedidoID");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentacionEnvio_ordenEnvioID",
                table: "DocumentacionEnvio",
                column: "ordenEnvioID");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialEstadoDevolucion_devolucionID",
                table: "HistorialEstadoDevolucion",
                column: "devolucionID");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialEstadoPedido_pedidoID",
                table: "HistorialEstadoPedido",
                column: "pedidoID");

            migrationBuilder.CreateIndex(
                name: "IX_HistorialProveedor_proveedorID",
                table: "HistorialProveedor",
                column: "proveedorID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_almacen_id",
                table: "Inventarios",
                column: "almacen_id");

            migrationBuilder.CreateIndex(
                name: "IX_Inventarios_producto_id",
                table: "Inventarios",
                column: "producto_id");

            migrationBuilder.CreateIndex(
                name: "IX_InventarioUbicaciones_productoID",
                table: "InventarioUbicaciones",
                column: "productoID");

            migrationBuilder.CreateIndex(
                name: "IX_InventarioUbicaciones_ubicacionID",
                table: "InventarioUbicaciones",
                column: "ubicacionID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDeOrdenDeCompra_ordenDeCompraID",
                table: "ItemDeOrdenDeCompra",
                column: "ordenDeCompraID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDeOrdenDeCompra_producto_id",
                table: "ItemDeOrdenDeCompra",
                column: "producto_id");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsRecepcion_productoID",
                table: "ItemsRecepcion",
                column: "productoID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsRecepcion_recepcionID",
                table: "ItemsRecepcion",
                column: "recepcionID");

            migrationBuilder.CreateIndex(
                name: "IX_movimientosAlmacen_productoID",
                table: "movimientosAlmacen",
                column: "productoID");

            migrationBuilder.CreateIndex(
                name: "IX_movimientosAlmacen_ubicacionDestinoID",
                table: "movimientosAlmacen",
                column: "ubicacionDestinoID");

            migrationBuilder.CreateIndex(
                name: "IX_movimientosAlmacen_ubicacionOrigenID",
                table: "movimientosAlmacen",
                column: "ubicacionOrigenID");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientosInventario_almacenID",
                table: "MovimientosInventario",
                column: "almacenID");

            migrationBuilder.CreateIndex(
                name: "IX_MovimientosInventario_productoID",
                table: "MovimientosInventario",
                column: "productoID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesCompra_proveedorID",
                table: "OrdenesCompra",
                column: "proveedorID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesEnvio_pedidoID",
                table: "OrdenesEnvio",
                column: "pedidoID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesEnvio_transportistaID",
                table: "OrdenesEnvio",
                column: "transportistaID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesTransferenciaInterna_almacenDestinoID",
                table: "OrdenesTransferenciaInterna",
                column: "almacenDestinoID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesTransferenciaInterna_almacenOrigenID",
                table: "OrdenesTransferenciaInterna",
                column: "almacenOrigenID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenesTransferenciaInterna_productoID",
                table: "OrdenesTransferenciaInterna",
                column: "productoID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_pedidoID",
                table: "Pagos",
                column: "pedidoID");

            migrationBuilder.CreateIndex(
                name: "IX_PagosDevoluciones_devolucionID",
                table: "PagosDevoluciones",
                column: "devolucionID");

            migrationBuilder.CreateIndex(
                name: "IX_PagosProveedores_proveedorID",
                table: "PagosProveedores",
                column: "proveedorID");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteID",
                table: "Pedido",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Recepciones_orden_de_compra_id",
                table: "Recepciones",
                column: "orden_de_compra_id");

            migrationBuilder.CreateIndex(
                name: "IX_Ruta_ordenEnvioID",
                table: "Ruta",
                column: "ordenEnvioID");

            migrationBuilder.CreateIndex(
                name: "IX_SeguimientoEnvio_ordenEnvioID",
                table: "SeguimientoEnvio",
                column: "ordenEnvioID");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicaciones_almacenID",
                table: "Ubicaciones",
                column: "almacenID");

            migrationBuilder.CreateIndex(
                name: "IX_ZonasAlmacen_almacenID",
                table: "ZonasAlmacen",
                column: "almacenID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostosEnvio");

            migrationBuilder.DropTable(
                name: "DetallesDevolucion");

            migrationBuilder.DropTable(
                name: "DetallesOrdenCompra");

            migrationBuilder.DropTable(
                name: "DetallesPedido");

            migrationBuilder.DropTable(
                name: "DocumentacionEnvio");

            migrationBuilder.DropTable(
                name: "HistorialEstadoDevolucion");

            migrationBuilder.DropTable(
                name: "HistorialEstadoPedido");

            migrationBuilder.DropTable(
                name: "HistorialProveedor");

            migrationBuilder.DropTable(
                name: "Inventarios");

            migrationBuilder.DropTable(
                name: "InventarioUbicaciones");

            migrationBuilder.DropTable(
                name: "ItemDeOrdenDeCompra");

            migrationBuilder.DropTable(
                name: "ItemsRecepcion");

            migrationBuilder.DropTable(
                name: "movimientosAlmacen");

            migrationBuilder.DropTable(
                name: "MovimientosInventario");

            migrationBuilder.DropTable(
                name: "OrdenesTransferenciaInterna");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "PagosDevoluciones");

            migrationBuilder.DropTable(
                name: "PagosProveedores");

            migrationBuilder.DropTable(
                name: "Ruta");

            migrationBuilder.DropTable(
                name: "SeguimientoEnvio");

            migrationBuilder.DropTable(
                name: "ZonasAlmacen");

            migrationBuilder.DropTable(
                name: "Recepciones");

            migrationBuilder.DropTable(
                name: "Ubicaciones");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Devoluciones");

            migrationBuilder.DropTable(
                name: "OrdenesEnvio");

            migrationBuilder.DropTable(
                name: "OrdenesCompra");

            migrationBuilder.DropTable(
                name: "Almacenes");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Transportista");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
