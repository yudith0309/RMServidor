using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionInventarios.Entidad;

[Table("Inventarios", Schema = "GestionInventarios")]
public class Inventario
{
    [Key]
    [Column("inventario_id")]
    public Guid InventarioID { get; set; }  // Clave primaria

    [Column("almacen_id")]
    [Required]
    public Guid AlmacenID { get; set; }  // Clave foránea que referencia a Almacen

    [Column("producto_id")]
    [Required]
    public Guid ProductoID { get; set; }  // Clave foránea que referencia a Producto

    [Column("cantidad_disponible")]
    public int CantidadDisponible { get; set; }  // Cantidad disponible en stock

    [Column("fecha_ultima_actualizacion")]
    public DateTime FechaUltimaActualizacion { get; set; }  // Fecha de la última actualización

    public Inventario(Guid inventarioID, Guid almacenID, Guid productoID, int cantidadDisponible, DateTime fechaUltimaActualizacion)
    {
        InventarioID = inventarioID;
        AlmacenID = almacenID;
        ProductoID = productoID;
        CantidadDisponible = cantidadDisponible;
        FechaUltimaActualizacion = fechaUltimaActualizacion;
    }

    public Inventario()
    {
    }
}
