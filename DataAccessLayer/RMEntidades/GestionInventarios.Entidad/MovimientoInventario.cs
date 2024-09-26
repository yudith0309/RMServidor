using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionInventarios.Entidad;

[Table("movimientos_inventario", Schema = "GestionInventarios")]
public class MovimientoInventario
{
    [Key]
    [Column("MovimientoID")]
    public int MovimientoID { get; set; }  // Clave primaria del movimiento de inventario

    [Column("ProductoID")]
    [Required]
    public int ProductoID { get; set; }  // Clave foránea que referencia a la tabla Productos

    [Column("AlmacenID")]
    [Required]
    public int AlmacenID { get; set; }  // Clave foránea que referencia a la tabla Almacenes

    [Column("TipoMovimiento")]
    [Required]
    [StringLength(50)]
    public string TipoMovimiento { get; set; }  // Tipo de movimiento: entrada, salida, transferencia

    [Column("Cantidad")]
    [Required]
    [Precision(18, 2)]
    public decimal Cantidad { get; set; }  // Cantidad de producto movida

    [Column("FechaMovimiento")]
    [Required]
    public DateTime FechaMovimiento { get; set; }  // Fecha del movimiento de inventario

    [Column("DocumentoRelacionado")]
    [StringLength(100)]
    public string DocumentoRelacionado { get; set; }  // Referencia a la orden de compra, venta u otro documento

    [Column("CreadoPor")]
    [StringLength(100)]
    public string CreadoPor { get; set; }  // Usuario que realizó el movimiento

    public MovimientoInventario(int movimientoID, int productoID, int almacenID, string tipoMovimiento, decimal cantidad, DateTime fechaMovimiento, string documentoRelacionado, string creadoPor)
    {
        MovimientoID = movimientoID;
        ProductoID = productoID;
        AlmacenID = almacenID;
        TipoMovimiento = tipoMovimiento;
        Cantidad = cantidad;
        FechaMovimiento = fechaMovimiento;
        DocumentoRelacionado = documentoRelacionado;
        CreadoPor = creadoPor;
    }
}