using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionAlmacenes.Entidad;

[Table("OrdenesTransferenciaInterna", Schema = "GestionAlmacenes")]

public class OrdenesTransferenciaInterna
{
    [Key]
    [Column("OrdenTransferenciaID")]
    public int OrdenTransferenciaID { get; set; }  // Clave primaria de la orden de transferencia

    [Column("AlmacenOrigenID")]
    [Required]
    public int AlmacenOrigenID { get; set; }  // Clave foránea que referencia al almacén de origen

    [Column("AlmacenDestinoID")]
    [Required]
    public int AlmacenDestinoID { get; set; }  // Clave foránea que referencia al almacén de destino

    [Column("ProductoID")]
    [Required]
    public int ProductoID { get; set; }  // Clave foránea que referencia a la tabla Productos

    [Column("CantidadTransferida")]
    [Required]
    [Precision(18, 2)]
    public decimal CantidadTransferida { get; set; }  // Cantidad de producto a transferir

    [Column("FechaTransferencia")]
    public DateTime FechaTransferencia { get; set; }  // Fecha en que se realizó la transferencia

    [Column("EstadoTransferencia")]
    [Required]
    [StringLength(50)]
    public string EstadoTransferencia { get; set; }  // Estado de la transferencia (ej. pendiente, completada)

    [Column("UsuarioResponsable")]
    [Required]
    [StringLength(100)]
    public string UsuarioResponsable { get; set; }  // Usuario encargado de la transferencia

}
