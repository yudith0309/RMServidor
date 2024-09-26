using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionInventarios.Entidad;

[Table("InventarioUbicaciones", Schema = "GestionInventarios")]

public class InventarioUbicaciones
{
    [Key]
    [Column("InventarioUbicacionID")]
    public int InventarioUbicacionID { get; set; }  // Clave primaria del inventario por ubicación

    [Column("UbicacionID")]
    [Required]
    public int UbicacionID { get; set; }  // Clave foránea que referencia a la tabla Ubicaciones

    [Column("ProductoID")]
    [Required]
    public int ProductoID { get; set; }  // Clave foránea que referencia a la tabla Productos

    [Column("CantidadDisponible")]
    [Required]
    [Precision(18, 2)]
    public decimal CantidadDisponible { get; set; }  // Cantidad de productos disponible en esa ubicación

    [Column("CantidadReservada")]
    [Required]
    [Precision(18, 2)]
    public decimal CantidadReservada { get; set; }  // Cantidad de productos reservada

    [Column("FechaUltimaActualizacion")]
    public DateTime FechaUltimaActualizacion { get; set; }  // Fecha de la última actualización del inventario

}
