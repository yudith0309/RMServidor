using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionPedidos.Entidad;

[Table("Pedido", Schema = "GestionPedidos")]
public class Pedido
{
    [Key]
    [Column("PedidoID")]
    public int PedidoID { get; set; }  // Clave primaria del pedido

    [Column("ClienteID")]
    [Required]
    public int ClienteID { get; set; }  // Clave foránea que referencia a la tabla Clientes

    [Column("FechaPedido")]
    [Required]
    public DateTime FechaPedido { get; set; }  // Fecha en la que se realizó el pedido

    [Column("EstadoPedido")]
    [Required]
    [StringLength(50)]
    public string EstadoPedido { get; set; }  // Estado del pedido (ej. pendiente, procesando, completado, cancelado)

    [Column("Total")]
    [Required]
    [Precision(18, 2)]
    public decimal Total { get; set; }  // Monto total del pedido

    [Column("MetodoPago")]
    [Required]
    [StringLength(50)]
    public string MetodoPago { get; set; }  // Método de pago utilizado para el pedido

    [Column("FechaCreacion")]
    public DateTime FechaCreacion { get; set; }  // Fecha de creación del pedido

    [Column("FechaActualizacion")]
    public DateTime FechaActualizacion { get; set; }  // Fecha de la última actualización del pedido

    public Pedido(int pedidoID, int clienteID, DateTime fechaPedido, string estadoPedido, decimal total, string metodoPago, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        PedidoID = pedidoID;
        ClienteID = clienteID;
        FechaPedido = fechaPedido;
        EstadoPedido = estadoPedido;
        Total = total;
        MetodoPago = metodoPago;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
}
