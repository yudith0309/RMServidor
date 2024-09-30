using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionPedidos.Entidad;

[Table("HistorialEstadoPedido", Schema = "GestionPedidos")]
public class HistorialEstadoPedido
{
    [Key]
    [Column("historialID")]
    public Guid HistorialID { get; set; }  // Clave primaria del historial

    [Column("pedidoID")]
    [Required]
    public Guid PedidoID { get; set; }  // Clave foránea que referencia a la tabla Pedidos

    [Column("estadoAnterior")]
    [StringLength(50)]
    public string EstadoAnterior { get; set; }  // Estado anterior del pedido

    [Column("estadoNuevo")]
    [StringLength(50)]
    public string EstadoNuevo { get; set; }  // Nuevo estado del pedido

    [Column("fechaCambio")]
    [Required]
    public DateTime FechaCambio { get; set; }  // Fecha del cambio de estado

    [Column("usuarioResponsable")]
    [StringLength(100)]
    public string UsuarioResponsable { get; set; }  // Usuario que realizó el cambio

    public HistorialEstadoPedido(Guid historialID, Guid pedidoID, string estadoAnterior, string estadoNuevo, DateTime fechaCambio, string usuarioResponsable)
    {
        HistorialID = historialID;
        PedidoID = pedidoID;
        EstadoAnterior = estadoAnterior;
        EstadoNuevo = estadoNuevo;
        FechaCambio = fechaCambio;
        UsuarioResponsable = usuarioResponsable;
    }
    public HistorialEstadoPedido()
    {
    }
}