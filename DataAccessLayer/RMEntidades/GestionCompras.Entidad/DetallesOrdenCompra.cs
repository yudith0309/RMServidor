using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionCompras.Entidad;

[Table("DetallesOrdenCompra", Schema = "GestionCompras")]
public class DetallesOrdenCompra
{
    [Key]
    [Column("detalleOrdenCompraID")]
    public Guid DetalleOrdenCompraID { get; set; }  // Clave primaria del detalle de la orden de compra

    [Column("ordenCompraID")]
    [Required]
    public Guid OrdenCompraID { get; set; }  // Clave foránea que referencia a la tabla OrdenesCompra

    [Column("productoID")]
    [Required]
    public Guid ProductoID { get; set; }  // Clave foránea que referencia a la tabla Productos

    [Column("cantidad")]
    [Required]
    public decimal Cantidad { get; set; }  // Cantidad del producto solicitado

    [Column("precioUnitario")]
    [Required]
    public decimal PrecioUnitario { get; set; }  // Precio unitario del producto

    [Column("subtotal")]
    [Required]
    public decimal Subtotal { get; set; }  // Subtotal por este detalle

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;  // Fecha de creación del registro

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;  // Fecha de última actualización

    public DetallesOrdenCompra(Guid detalleOrdenCompraID, Guid ordenCompraID, Guid productoID, decimal cantidad, decimal precioUnitario, decimal subtotal, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        DetalleOrdenCompraID = detalleOrdenCompraID;
        OrdenCompraID = ordenCompraID;
        ProductoID = productoID;
        Cantidad = cantidad;
        PrecioUnitario = precioUnitario;
        Subtotal = subtotal;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public DetallesOrdenCompra()
    {
    }
}