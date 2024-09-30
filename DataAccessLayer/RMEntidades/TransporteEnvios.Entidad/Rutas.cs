using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransporteEnvios.Entidad;

[Table("Rutas", Schema = "TransporteEnvios")]
public class Ruta
{
    [Key]
    [Column("rutaID")]
    public Guid RutaID { get; set; }  // Clave primaria de la ruta

    [Column("ordenEnvioID")]
    public Guid OrdenEnvioID { get; set; }  // Clave foránea que referencia a OrdenesEnvio

    [Column("puntoSalida")]
    [Required]
    public string PuntoSalida { get; set; }  // Punto de salida de la ruta

    [Column("puntoDestino")]
    [Required]
    public string PuntoDestino { get; set; }  // Punto de destino de la ruta

    [Column("distancia")]
    [Required]
    public decimal Distancia { get; set; }  // Distancia total de la ruta en kilómetros

    [Column("tiempoEstimado")]
    [Required]
    public string TiempoEstimado { get; set; }  // Tiempo estimado de viaje

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;  // Fecha de creación del registro

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;  // Fecha de última actualización

    public Ruta(Guid rutaID, Guid ordenEnvioID, string puntoSalida, string puntoDestino, decimal distancia, string tiempoEstimado, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        RutaID = rutaID;
        OrdenEnvioID = ordenEnvioID;
        PuntoSalida = puntoSalida;
        PuntoDestino = puntoDestino;
        Distancia = distancia;
        TiempoEstimado = tiempoEstimado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }

    public Ruta()
    {
    }
}