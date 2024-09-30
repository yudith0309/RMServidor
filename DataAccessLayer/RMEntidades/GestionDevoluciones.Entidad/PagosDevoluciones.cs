using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDevoluciones.Entidad;

[Table("PagosDevoluciones", Schema = "GestionDevoluciones")]
public class PagosDevoluciones
{
    [Key]
    [Column("pagoDevolucionID")]
    public Guid PagoDevolucionID { get; set; }  // Clave primaria del pago de la devolución

    [Column("devolucionID")]
    [Required]
    public Guid DevolucionID { get; set; }  // Clave foránea que referencia a la tabla Devoluciones

    [Column("montoReembolsado")]
    [Required]
    public decimal MontoReembolsado { get; set; }  // Monto del reembolso realizado

    [Column("fechaReembolso")]
    [Required]
    public DateTime FechaReembolso { get; set; }  // Fecha en que se realizó el reembolso

    [Column("metodoPago")]
    [StringLength(50)]
    public string MetodoPago { get; set; }  // Método de pago utilizado para el reembolso

    [Column("estadoReembolso")]
    [StringLength(50)]
    public string EstadoReembolso { get; set; }  // Estado del reembolso

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;  // Fecha de creación del registro

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;  // Fecha de última actualización

    public PagosDevoluciones(Guid pagoDevolucionID, Guid devolucionID, decimal montoReembolsado, DateTime fechaReembolso, string metodoPago, string estadoReembolso, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        PagoDevolucionID = pagoDevolucionID;
        DevolucionID = devolucionID;
        MontoReembolsado = montoReembolsado;
        FechaReembolso = fechaReembolso;
        MetodoPago = metodoPago;
        EstadoReembolso = estadoReembolso;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }

    public PagosDevoluciones()
    {
    }
}