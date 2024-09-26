using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionAlmacenes.Entidad;

[Table("ZonasAlmacen", Schema = "GestionAlmacenes")]

public class ZonasAlmacen
{
    [Key]
    [Column("ZonaID")]
    public int ZonaID { get; set; }  // Clave primaria de la zona dentro del almacén

    [Column("AlmacenID")]
    [Required]
    public int AlmacenID { get; set; }  // Clave foránea que referencia a la tabla Almacenes

    [Column("NombreZona")]
    [Required]
    [StringLength(100)]
    public string NombreZona { get; set; }  // Nombre de la zona

    [Column("TipoZona")]
    [Required]
    [StringLength(50)]
    public string TipoZona { get; set; }  // Tipo de zona (ej. recepción, despacho, almacenamiento)

    [Column("CapacidadZona")]
    [Required]
    [Precision(18, 2)]
    public decimal CapacidadZona { get; set; }  // Capacidad total de la zona

    [Column("FechaCreacion")]
    public DateTime FechaCreacion { get; set; }  // Fecha de creación de la zona

    [Column("FechaActualizacion")]
    public DateTime FechaActualizacion { get; set; }  // Fecha de la última actualización de la zona

    public ZonasAlmacen(int zonaID, int almacenID, string nombreZona, string tipoZona, decimal capacidadZona, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        ZonaID = zonaID;
        AlmacenID = almacenID;
        NombreZona = nombreZona;
        TipoZona = tipoZona;
        CapacidadZona = capacidadZona;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
}
