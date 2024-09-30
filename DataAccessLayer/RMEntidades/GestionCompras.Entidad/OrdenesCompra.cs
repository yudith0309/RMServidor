using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionCompras.Entidad;

[Table("OrdenesCompra", Schema = "GestionCompras")]
public class OrdenesCompra
{
    [Key]
    [Column("ordenCompraID")]
    public Guid OrdenCompraID { get; set; }  // Clave primaria de la orden de compra

    [Column("proveedorID")]
    [Required]
    public Guid ProveedorID { get; set; }  // Clave foránea que referencia a la tabla Proveedores

    [Column("fechaOrden")]
    [Required]
    public DateTime FechaOrden { get; set; }  // Fecha en que se creó la orden de compra

    [Column("fechaEntregaEstimada")]
    public DateTime? FechaEntregaEstimada { get; set; }  // Fecha estimada de entrega

    [Column("total")]
    [Required]
    public decimal Total { get; set; }  // Monto total de la orden de compra

    [Column("estado")]
    [StringLength(50)]
    public string Estado { get; set; }  // Estado de la orden de compra

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;  // Fecha de creación del registro

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;  // Fecha de última actualización

    public OrdenesCompra(Guid ordenCompraID, Guid proveedorID, DateTime fechaOrden, DateTime? fechaEntregaEstimada, decimal total, string estado, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        OrdenCompraID = ordenCompraID;
        ProveedorID = proveedorID;
        FechaOrden = fechaOrden;
        FechaEntregaEstimada = fechaEntregaEstimada;
        Total = total;
        Estado = estado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public OrdenesCompra()
    {
    }
}
