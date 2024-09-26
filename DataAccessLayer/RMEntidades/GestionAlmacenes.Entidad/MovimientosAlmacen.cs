using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionAlmacenes.Entidad;

[Table("Movimientos_almacen", Schema = "GestionAlmacenes")]
public class MovimientosAlmacen
{
    [Key]
    [Column("MovimientoID")]
    public int MovimientoID { get; set; }  // Clave primaria del movimiento

    [Column("ProductoID")]
    [Required]
    public int ProductoID { get; set; }  // Clave foránea que referencia a la tabla Productos

    [Column("UbicacionOrigenID")]
    [Required]
    public int UbicacionOrigenID { get; set; }  // Clave foránea de la ubicación de origen

    [Column("UbicacionDestinoID")]
    [Required]
    public int UbicacionDestinoID { get; set; }  // Clave foránea de la ubicación de destino

    [Column("TipoMovimiento")]
    [Required]
    [StringLength(50)]
    public string TipoMovimiento { get; set; }  // Tipo de movimiento: entrada, salida, transferencia

    [Column("CantidadMovida")]
    [Precision(18, 2)]
    public decimal CantidadMovida { get; set; }  // Cantidad de producto movida

    [Column("FechaMovimiento")]
    public DateTime FechaMovimiento { get; set; }  // Fecha en la que se realizó el movimiento

    [Column("DocumentoRelacionado")]
    [StringLength(100)]
    public string DocumentoRelacionado { get; set; }  // Referencia a órdenes de compra, venta o documento interno

    [Column("UsuarioResponsable")]
    [StringLength(100)]
    public string UsuarioResponsable { get; set; }

    public MovimientosAlmacen(int movimientoID, int productoID, int ubicacionOrigenID, int ubicacionDestinoID, string tipoMovimiento, decimal cantidadMovida, DateTime fechaMovimiento, string documentoRelacionado, string usuarioResponsable)
    {
        MovimientoID = movimientoID;
        ProductoID = productoID;
        UbicacionOrigenID = ubicacionOrigenID;
        UbicacionDestinoID = ubicacionDestinoID;
        TipoMovimiento = tipoMovimiento;
        CantidadMovida = cantidadMovida;
        FechaMovimiento = fechaMovimiento;
        DocumentoRelacionado = documentoRelacionado;
        UsuarioResponsable = usuarioResponsable;
    }
}
