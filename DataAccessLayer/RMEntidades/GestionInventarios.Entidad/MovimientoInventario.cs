using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionInventarios.Entidad;

[Table("MovimientosInventario", Schema = "GestionInventarios")]
public class MovimientoInventario
{
    [Key]
    [Column("movimientoID")]
    public Guid MovimientoID { get; set; }  // Clave primaria del movimiento de inventario

    [Column("productoID")]
    [Required]
    public Guid ProductoID { get; set; }  // Clave foránea que referencia a la tabla Productos

    [Column("almacenID")]
    [Required]
    public Guid AlmacenID { get; set; }  // Clave foránea que referencia a la tabla Almacenes

    [Column("tipoMovimiento")]
    [Required]
    [StringLength(50)]
    public string TipoMovimiento { get; set; }  // Tipo de movimiento: entrada, salida, transferencia

    [Column("cantidad")]
    [Required]
    [Precision(18, 2)]
    public decimal Cantidad { get; set; }  // Cantidad de producto movida

    [Column("fechaMovimiento")]
    [Required]
    public DateTime FechaMovimiento { get; set; }  // Fecha del movimiento de inventario

    [Column("documentoRelacionado")]
    [StringLength(100)]
    public string DocumentoRelacionado { get; set; }  // Referencia a la orden de compra, venta u otro documento

    [Column("creadoPor")]
    [StringLength(100)]
    public string CreadoPor { get; set; }  // Usuario que realizó el movimiento

    public MovimientoInventario()
    {
    }

    public MovimientoInventario(Guid movimientoID, Guid productoID, Guid almacenID, string tipoMovimiento, decimal cantidad, DateTime fechaMovimiento, string documentoRelacionado, string creadoPor)
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