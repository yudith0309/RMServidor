using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionProveedores.Entidad;

[Table("PagosProveedores", Schema = "GestionProveedores")]
public class PagosProveedores
{
    [Key]
    [Column("pagoProveedorID")]
    public Guid PagoProveedorID { get; set; }  // Clave primaria del pago a proveedor

    [Column("proveedorID")]
    [Required]
    public Guid ProveedorID { get; set; }  // Clave foránea que referencia a la tabla Proveedores

    [Column("monto")]
    [Required]
    public decimal Monto { get; set; }  // Monto pagado al proveedor

    [Column("fechaPago")]
    public DateTime FechaPago { get; set; } = DateTime.Now;  // Fecha en que se realizó el pago

    [Column("metodoPago")]
    [Required]
    public string MetodoPago { get; set; }  // Método de pago utilizado

    [Column("estadoPago")]
    [Required]
    public string EstadoPago { get; set; }  // Estado del pago

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;  // Fecha de creación del registro

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;  // Fecha de última actualización

    public PagosProveedores(Guid pagoProveedorID, Guid proveedorID, decimal monto, DateTime fechaPago, string metodoPago, string estadoPago, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        PagoProveedorID = pagoProveedorID;
        ProveedorID = proveedorID;
        Monto = monto;
        FechaPago = fechaPago;
        MetodoPago = metodoPago;
        EstadoPago = estadoPago;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public PagosProveedores()
    {
    }
}