using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionInventarios.Entidad;

[Table("InventarioUbicaciones", Schema = "GestionInventarios")]

public class InventarioUbicaciones
{
    [Key]
    [Column("inventarioUbicacionID")]
    public Guid InventarioUbicacionID { get; set; }  // Clave primaria del inventario por ubicación

    [Column("ubicacionID")]
    [Required]
    public Guid UbicacionID { get; set; }  // Clave foránea que referencia a la tabla Ubicaciones

    [Column("productoID")]
    [Required]
    public Guid ProductoID { get; set; }  // Clave foránea que referencia a la tabla Productos

    [Column("cantidadDisponible")]
    [Required]
    [Precision(18, 2)]
    public decimal CantidadDisponible { get; set; }  // Cantidad de productos disponible en esa ubicación

    [Column("cantidadReservada")]
    [Required]
    [Precision(18, 2)]
    public decimal CantidadReservada { get; set; }  // Cantidad de productos reservada

    [Column("fechaUltimaActualizacion")]
    public DateTime FechaUltimaActualizacion { get; set; }  // Fecha de la última actualización del inventario

    public InventarioUbicaciones(Guid inventarioUbicacionID, Guid ubicacionID, Guid productoID, decimal cantidadDisponible, decimal cantidadReservada, DateTime fechaUltimaActualizacion)
    {
        InventarioUbicacionID = inventarioUbicacionID;
        UbicacionID = ubicacionID;
        ProductoID = productoID;
        CantidadDisponible = cantidadDisponible;
        CantidadReservada = cantidadReservada;
        FechaUltimaActualizacion = fechaUltimaActualizacion;
    }
    public InventarioUbicaciones()
    {
    }
}
