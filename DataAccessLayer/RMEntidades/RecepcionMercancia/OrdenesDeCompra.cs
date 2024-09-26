using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecepcionMercancia.Entidad;

[Table("OrdenDeCompra", Schema = "RecepcionMercancia")]
public class OrdenDeCompra
{
    [Key]
    [Column("orden_de_compra_id")]
    public Guid OrdenDeCompraID { get; set; }  // Clave primaria

    [Column("numero_orden")]
    [Required]
    [StringLength(50)]
    public string NumeroOrden { get; set; }  // Número único de la orden

    [Column("proveedor_id")]
    [Required]
    public Guid ProveedorID { get; set; }  // Clave foránea que referencia a Proveedor

    [Column("fecha_creacion")]
    public DateTime FechaCreacion { get; set; }  // Fecha de creación de la orden

    [Column("fecha_entrega_esperada")]
    public DateTime FechaEntregaEsperada { get; set; }  // Fecha de entrega esperada

    [Column("estado")]
    [Required]
    [StringLength(50)]
    public string Estado { get; set; }  // Estado de la orden

    [Column("fecha_actualizacion")]
    public DateTime FechaActualizacion { get; set; }  // Fecha de actualización

    public OrdenDeCompra(Guid ordenDeCompraID, string numeroOrden, Guid proveedorID, DateTime fechaCreacion, DateTime fechaEntregaEsperada, string estado, DateTime fechaActualizacion)
    {
        OrdenDeCompraID = ordenDeCompraID;
        NumeroOrden = numeroOrden;
        ProveedorID = proveedorID;
        FechaCreacion = fechaCreacion;
        FechaEntregaEsperada = fechaEntregaEsperada;
        Estado = estado;
        FechaActualizacion = fechaActualizacion;
    }
}