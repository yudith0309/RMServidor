using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransporteEnvios.Entidad;

[Table("SeguimientoEnvio", Schema = "TransporteEnvios")]
public class SeguimientoEnvio
{
    [Key]
    [Column("seguimientoID")]
    public Guid SeguimientoID { get; set; }  // Clave primaria del seguimiento

    [Column("ordenEnvioID")]
    public Guid OrdenEnvioID { get; set; }  // Clave foránea que referencia a OrdenesEnvio

    [Column("fechaRegistro")]
    [Required]
    public DateTime FechaRegistro { get; set; }  // Fecha en que se registró el estado

    [Column("estado")]
    [Required]
    public string Estado { get; set; }  // Estado actual del envío

    [Column("ubicacionActual")]
    [Required]
    public string UbicacionActual { get; set; }  // Ubicación actual del envío

    [Column("comentarios")]
    public string Comentarios { get; set; }  // Comentarios adicionales sobre el estado

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;  // Fecha de creación del registro

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;  // Fecha de última actualización
}