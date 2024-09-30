using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDevoluciones.Entidad;

[Table("DetallesDevolucion", Schema = "GestionDevoluciones")]
public class DetallesDevolucion
{
    [Key]
    [Column("detalleDevolucionID")]
    public Guid DetalleDevolucionID { get; set; }  // Clave primaria del detalle de devolución

    [Column("devolucionID")]
    [Required]
    public Guid DevolucionID { get; set; }  // Clave foránea que referencia a la tabla Devoluciones

    [Column("productoID")]
    [Required]
    public Guid ProductoID { get; set; }  // Clave foránea que referencia a la tabla Productos

    [Column("cantidad")]
    [Required]
    [Precision(18, 2)]
    public decimal Cantidad { get; set; }  // Cantidad del producto devuelto

    [Column("estadoProducto")]
    [StringLength(50)]
    public string EstadoProducto { get; set; }  // Estado del producto devuelto

    [Column("fechaCreacion")]
    [Required]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;  // Fecha de creación del detalle de devolución

    [Column("fechaActualizacion")]
    [Required]
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;  // Fecha de la última actualización

    public DetallesDevolucion(Guid detalleDevolucionID, Guid devolucionID, Guid productoID, decimal cantidad, string estadoProducto, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        DetalleDevolucionID = detalleDevolucionID;
        DevolucionID = devolucionID;
        ProductoID = productoID;
        Cantidad = cantidad;
        EstadoProducto = estadoProducto;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }

    public DetallesDevolucion()
    {
    }
}