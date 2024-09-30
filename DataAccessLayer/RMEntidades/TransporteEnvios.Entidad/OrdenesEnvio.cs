using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransporteEnvios.Entidad;

[Table("OrdenesEnvio", Schema = "TransporteEnvios")]
public class OrdenesEnvio
{
    [Key]
    [Column("ordenEnvioID")]
    public Guid OrdenEnvioID { get; set; }  // Clave primaria de la orden de envío

    [Column("pedidoID")]
    [Required]
    public Guid PedidoID { get; set; }  // Clave foránea que referencia a la tabla Pedidos

    [Column("transportistaID")]
    [Required]
    public Guid TransportistaID { get; set; }  // Clave foránea que referencia a la tabla Transportistas

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;  // Fecha de creación de la orden de envío

    [Column("estado")]
    [Required]
    public string Estado { get; set; }  // Estado de la orden de envío

    [Column("fechaEnvio")]
    public DateTime? FechaEnvio { get; set; }  // Fecha en que se envió la orden

    [Column("fechaEntregaEstimada")]
    public DateTime? FechaEntregaEstimada { get; set; }  // Fecha estimada de entrega

    [Column("costoEnvio")]
    [Required]
    public decimal CostoEnvio { get; set; }  // Costo asociado al envío

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;  // Fecha de última actualización

    public OrdenesEnvio(Guid ordenEnvioID, Guid pedidoID, Guid transportistaID, DateTime fechaCreacion, string estado, DateTime? fechaEnvio, DateTime? fechaEntregaEstimada, decimal costoEnvio, DateTime fechaActualizacion)
    {
        OrdenEnvioID = ordenEnvioID;
        PedidoID = pedidoID;
        TransportistaID = transportistaID;
        FechaCreacion = fechaCreacion;
        Estado = estado;
        FechaEnvio = fechaEnvio;
        FechaEntregaEstimada = fechaEntregaEstimada;
        CostoEnvio = costoEnvio;
        FechaActualizacion = fechaActualizacion;
    }
    public OrdenesEnvio()
    {
    }
}