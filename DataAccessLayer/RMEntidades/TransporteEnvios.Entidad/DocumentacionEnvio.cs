using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransporteEnvios.Entidad;

[Table("DocumentacionEnvio", Schema = "TransporteEnvios")]
public class DocumentacionEnvio
{
    [Key]
    [Column("documentacionID")]
    public Guid DocumentacionID { get; set; }  // Clave primaria de la documentación

    [Column("ordenEnvioID")]
    public Guid OrdenEnvioID { get; set; }  // Clave foránea que referencia a OrdenesEnvio

    [Column("tipoDocumento")]
    [Required]
    public string TipoDocumento { get; set; }  // Tipo de documento, requerido

    [Column("rutaArchivo")]
    [Required]
    public string RutaArchivo { get; set; }  // Ruta donde se almacena el documento

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;  // Fecha de creación del registro

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;  // Fecha de última actualización

    public DocumentacionEnvio(Guid documentacionID, Guid ordenEnvioID, string tipoDocumento, string rutaArchivo, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        DocumentacionID = documentacionID;
        OrdenEnvioID = ordenEnvioID;
        TipoDocumento = tipoDocumento;
        RutaArchivo = rutaArchivo;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public DocumentacionEnvio()
    {
    }
}
