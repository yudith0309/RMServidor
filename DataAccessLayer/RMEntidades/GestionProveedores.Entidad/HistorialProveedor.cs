using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionProveedores.Entidad;

[Table("HistorialProveedor", Schema = "GestionProveedores")]
public class HistorialProveedor
{
    [Key]
    [Column("historialProveedorID")]
    public Guid HistorialProveedorID { get; set; }  // Clave primaria del historial del proveedor

    [Column("proveedorID")]
    [Required]
    public Guid ProveedorID { get; set; }  // Clave foránea que referencia a la tabla Proveedores

    [Column("fechaEvaluacion")]
    public DateTime FechaEvaluacion { get; set; } = DateTime.Now;  // Fecha en que se realizó la evaluación

    [Column("calificacion")]
    [Required]
    public int Calificacion { get; set; }  // Calificación otorgada al proveedor

    [Column("comentarios")]
    public string Comentarios { get; set; }  // Comentarios sobre el proveedor

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;  // Fecha de creación del registro

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;  // Fecha de última actualización

    public HistorialProveedor(Guid historialProveedorID, Guid proveedorID, DateTime fechaEvaluacion, int calificacion, string comentarios, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        HistorialProveedorID = historialProveedorID;
        ProveedorID = proveedorID;
        FechaEvaluacion = fechaEvaluacion;
        Calificacion = calificacion;
        Comentarios = comentarios;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public HistorialProveedor()
    {
    }
}