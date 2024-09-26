using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionAlmacenes.Entidad;

[Table("Ubicaciones", Schema = "GestionAlmacenes")]
public class Ubicacion
{
    [Key]
    [Column("UbicacionID")]
    public int UbicacionID { get; set; }  // Clave primaria de la ubicación dentro del almacén

    [Column("AlmacenID")]
    [Required]
    public int AlmacenID { get; set; }  // Clave foránea que referencia a la tabla Almacenes

    [Column("CodigoUbicacion")]
    [Required]
    [StringLength(50)]
    public string CodigoUbicacion { get; set; }  // Código único que identifica la ubicación

    [Column("TipoUbicacion")]
    [Required]
    [StringLength(50)]
    public string TipoUbicacion { get; set; }  // Tipo de ubicación: picking, almacenamiento, zona de devoluciones

    [Column("CapacidadUbicacion")]
    [Precision(18, 2)]
    public decimal CapacidadUbicacion { get; set; }  // Capacidad máxima de la ubicación

    [Column("Ocupado")]
    public bool Ocupado { get; set; }  // Indica si la ubicación está ocupada

    [Column("FechaCreacion")]
    public DateTime FechaCreacion { get; set; }  // Fecha de creación de la ubicación

    [Column("FechaActualizacion")]
    public DateTime FechaActualizacion { get; set; }  // Fecha de la última actualización de la ubicación

    public Ubicacion(int ubicacionID, int almacenID, string codigoUbicacion, string tipoUbicacion, decimal capacidadUbicacion, bool ocupado, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        UbicacionID = ubicacionID;
        AlmacenID = almacenID;
        CodigoUbicacion = codigoUbicacion;
        TipoUbicacion = tipoUbicacion;
        CapacidadUbicacion = capacidadUbicacion;
        Ocupado = ocupado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
}
