using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionPedidos.Entidad;

[Table("Pagos", Schema = "GestionPedidos")]
public class Pagos
{
    [Key]
    [Column("pagoID")]
    public Guid PagoID { get; set; }  // Clave primaria del pago

    [Column("pedidoID")]
    [Required]
    public Guid PedidoID { get; set; }  // Clave foránea que referencia a la tabla Pedidos

    [Column("monto")]
    [Required]
    [Precision(18, 2)]
    public decimal Monto { get; set; }  // Monto del pago realizado

    [Column("fechaPago")]
    public DateTime FechaPago { get; set; }  // Fecha en que se realizó el pago

    [Column("metodoPago")]
    [Required]
    [MaxLength(50)]
    public string MetodoPago { get; set; }  // Método de pago utilizado

    [Column("estadoPago")]
    [Required]
    [MaxLength(50)]
    public string EstadoPago { get; set; }  // Estado del pago

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; }  // Fecha de creación del registro de pago

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; }  // Fecha de la última actualización del pago

    public Pagos(Guid pagoID, Guid pedidoID, decimal monto, DateTime fechaPago, string metodoPago, string estadoPago, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        PagoID = pagoID;
        PedidoID = pedidoID;
        Monto = monto;
        FechaPago = fechaPago;
        MetodoPago = metodoPago;
        EstadoPago = estadoPago;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public Pagos()
    {
    }
}