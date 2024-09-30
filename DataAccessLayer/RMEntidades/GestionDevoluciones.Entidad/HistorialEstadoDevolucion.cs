using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionDevoluciones.Entidad;

[Table("HistorialEstadoDevolucion", Schema = "GestionDevoluciones")]
public class HistorialEstadoDevolucion
{
    [Key]
    [Column("historialDevolucionID")]
    public Guid HistorialDevolucionID { get; set; }  // Clave primaria del historial de estado de la devolución

    [Column("devolucionID")]
    [Required]
    public Guid DevolucionID { get; set; }  // Clave foránea que referencia a la tabla Devoluciones

    [Column("estadoAnterior")]
    [StringLength(50)]
    public string EstadoAnterior { get; set; }  // Estado anterior de la devolución

    [Column("estadoNuevo")]
    [StringLength(50)]
    public string EstadoNuevo { get; set; }  // Nuevo estado de la devolución

    [Column("fechaCambio")]
    [Required]
    public DateTime FechaCambio { get; set; }  // Fecha del cambio de estado

    [Column("usuarioResponsable")]
    [StringLength(100)]
    public string UsuarioResponsable { get; set; }  // Usuario que realizó el cambio

    public HistorialEstadoDevolucion(Guid historialDevolucionID, Guid devolucionID, string estadoAnterior, string estadoNuevo, DateTime fechaCambio, string usuarioResponsable)
    {
        HistorialDevolucionID = historialDevolucionID;
        DevolucionID = devolucionID;
        EstadoAnterior = estadoAnterior;
        EstadoNuevo = estadoNuevo;
        FechaCambio = fechaCambio;
        UsuarioResponsable = usuarioResponsable;
    }

    public HistorialEstadoDevolucion()
    {
    }
}