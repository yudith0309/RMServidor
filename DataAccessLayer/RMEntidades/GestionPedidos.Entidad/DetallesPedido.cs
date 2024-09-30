using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionPedidos.Entidad;

[Table("DetallesPedido", Schema = "GestionPedidos")]
public class DetallesPedido
{
    [Key]
    [Column("detalleID")]
    public Guid DetalleID { get; set; }  // Clave primaria del detalle del pedido

    [Column("pedidoID")]
    [Required]
    public Guid PedidoID { get; set; }  // Clave foránea que referencia a la tabla Pedidos

    [Column("productoID")]
    [Required]
    public Guid ProductoID { get; set; }  // Clave foránea que referencia a la tabla Productos

    [Column("cantidad")]
    [Required]
    [Precision(18, 2)]
    public decimal Cantidad { get; set; }  // Cantidad del producto en el pedido

    [Column("precioUnitario")]
    [Required]
    [Precision(18, 2)]
    public decimal PrecioUnitario { get; set; }  // Precio del producto en el momento del pedido

    [Column("subtotal")]
    [Required]
    [Precision(18, 2)]
    public decimal Subtotal { get; set; }  // Subtotal del detalle

    [Column("fechaCreacion")]
    [Required]
    public DateTime FechaCreacion { get; set; }  // Fecha de creación del detalle del pedido

    [Column("fechaActualizacion")]
    [Required]
    public DateTime FechaActualizacion { get; set; }  // Fecha de la última actualización del detalle

    public DetallesPedido(Guid detalleID, Guid pedidoID, Guid productoID, decimal cantidad, decimal precioUnitario, decimal subtotal, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        DetalleID = detalleID;
        PedidoID = pedidoID;
        ProductoID = productoID;
        Cantidad = cantidad;
        PrecioUnitario = precioUnitario;
        Subtotal = subtotal;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }

    public DetallesPedido()
    {
    }
}
