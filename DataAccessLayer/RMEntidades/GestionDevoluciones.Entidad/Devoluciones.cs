
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDevoluciones.Entidad;

[Table("Devoluciones", Schema = "GestionDevoluciones")]
public class Devoluciones
{
    [Key]
    [Column("devolucionID")]
    public Guid DevolucionID { get; set; }  // Clave primaria de la devolución

    [Column("pedidoID")]
    [Required]
    public Guid PedidoID { get; set; }  // Clave foránea que referencia a la tabla Pedidos

    [Column("fechaDevolucion")]
    public DateTime FechaDevolucion { get; set; }  // Fecha en que se realizó la devolución

    [Column("motivo")]
    [MaxLength(255)]
    public string Motivo { get; set; }  // Motivo de la devolución

    [Column("estadoDevolucion")]
    [Required]
    [MaxLength(50)]
    public string EstadoDevolucion { get; set; }  // Estado de la devolución

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; }  // Fecha de creación del registro de devolución

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; }  // Fecha de la última actualización de la devolución

    public Devoluciones(Guid devolucionID, Guid pedidoID, DateTime fechaDevolucion, string motivo, string estadoDevolucion, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        DevolucionID = devolucionID;
        PedidoID = pedidoID;
        FechaDevolucion = fechaDevolucion;
        Motivo = motivo;
        EstadoDevolucion = estadoDevolucion;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }

    public Devoluciones()
    {
    }
}