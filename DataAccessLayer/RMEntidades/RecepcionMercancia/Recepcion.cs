using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecepcionMercancia.Entidad;

[Table("Recepciones", Schema = "RecepcionMercancia")]
public class Recepcion
{
    [Key]
    [Column("recepcion_id")]
    public Guid RecepcionID { get; set; }  // Clave primaria

    [Column("orden_de_compra_id")]
    [Required]
    public Guid OrdenDeCompraID { get; set; }  // Clave foránea que referencia a OrdenDeCompra

    [Column("fecha_recepcion")]
    public DateTime FechaRecepcion { get; set; }  // Fecha en la que se recibe la orden

    [Column("recibido_por")]
    [StringLength(100)]
    public string RecibidoPor { get; set; }  // Usuario o empleado que gestionó la recepción

    [Column("estado")]
    [Required]
    [StringLength(50)]
    public string Estado { get; set; }  // Estado de la recepción

    [Column("fecha_creacion")]
    public DateTime FechaCreacion { get; set; }  // Fecha de creación

    [Column("fecha_actualizacion")]
    public DateTime FechaActualizacion { get; set; }  // Fecha de actualización

    public Recepcion(Guid recepcionID, Guid ordenDeCompraID, DateTime fechaRecepcion, string recibidoPor, string estado, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        RecepcionID = recepcionID;
        OrdenDeCompraID = ordenDeCompraID;
        FechaRecepcion = fechaRecepcion;
        RecibidoPor = recibidoPor;
        Estado = estado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public Recepcion()
    {
    }
}