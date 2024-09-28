using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionAlmacenes.Entidad;

[Table("OrdenesTransferenciaInterna", Schema = "GestionAlmacenes")]

public class OrdenesTransferenciaInterna
{
    [Key]
    [Column("ordenTransferenciaID")]
    public Guid OrdenTransferenciaID { get; set; }  // Clave primaria de la orden de transferencia

    [Column("almacenOrigenID")]
    [Required]
    public Guid AlmacenOrigenID { get; set; }  // Clave foránea que referencia al almacén de origen

    [Column("almacenDestinoID")]
    [Required]
    public Guid AlmacenDestinoID { get; set; }  // Clave foránea que referencia al almacén de destino

    [Column("productoID")]
    [Required]
    public Guid ProductoID { get; set; }  // Clave foránea que referencia a la tabla Productos

    [Column("cantidadTransferida")]
    [Required]
    [Precision(18, 2)]
    public decimal CantidadTransferida { get; set; }  // Cantidad de producto a transferir

    [Column("fechaTransferencia")]
    public DateTime FechaTransferencia { get; set; }  // Fecha en que se realizó la transferencia

    [Column("estadoTransferencia")]
    [Required]
    [StringLength(50)]
    public string EstadoTransferencia { get; set; }  // Estado de la transferencia (ej. pendiente, completada)

    [Column("usuarioResponsable")]
    [Required]
    [StringLength(100)]
    public string UsuarioResponsable { get; set; }  // Usuario encargado de la transferencia

    public OrdenesTransferenciaInterna(Guid ordenTransferenciaID, Guid almacenOrigenID, Guid almacenDestinoID, Guid productoID, decimal cantidadTransferida, DateTime fechaTransferencia, string estadoTransferencia, string usuarioResponsable)
    {
        OrdenTransferenciaID = ordenTransferenciaID;
        AlmacenOrigenID = almacenOrigenID;
        AlmacenDestinoID = almacenDestinoID;
        ProductoID = productoID;
        CantidadTransferida = cantidadTransferida;
        FechaTransferencia = fechaTransferencia;
        EstadoTransferencia = estadoTransferencia;
        UsuarioResponsable = usuarioResponsable;
    }
    public OrdenesTransferenciaInterna()
    {
    }
}
