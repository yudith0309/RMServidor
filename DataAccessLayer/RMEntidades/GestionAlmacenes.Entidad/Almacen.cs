using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionAlmacenes.Entidad;

[Table("Almacenes", Schema = "GestionAlmacenes")]
public class Almacen
{
    [Key]
    [Column("almacen_id")]
    public Guid AlmacenID { get; set; }  // Clave primaria

    [Column("nombre_almacen")]
    [Required]
    [StringLength(100)]
    public string NombreAlmacen { get; set; }  // Nombre del almacén

    [Column("ubicacion")]
    [StringLength(255)]
    public string Ubicacion { get; set; }  // Ubicación del almacén

    [Column("fecha_creacion")]
    public DateTime FechaCreacion { get; set; }  // Fecha de creación

    [Column("fecha_actualizacion")]
    public DateTime FechaActualizacion { get; set; }  // Fecha de actualización

    public Almacen(Guid almacenID, string nombreAlmacen, string ubicacion, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        AlmacenID = almacenID;
        NombreAlmacen = nombreAlmacen;
        Ubicacion = ubicacion;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }

    public Almacen()
    {
    }
}
