using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransporteEnvios.Entidad;

[Table("CostosEnvio", Schema = "TransporteEnvios")]
public class CostosEnvio
{
    [Key]
    [Column("costoEnvioID")]
    public Guid CostoEnvioID { get; set; }  // Clave primaria del costo de envío

    [Column("ordenEnvioID")]
    public Guid OrdenEnvioID { get; set; }  // Clave foránea que referencia a OrdenesEnvio

    [Column("costoBase")]
    [Required]
    public decimal CostoBase { get; set; }  // Costo base del envío

    [Column("costoAdicional")]
    public decimal CostoAdicional { get; set; } = 0;  // Costo adicional, por defecto 0

    [Column("descuento")]
    public decimal Descuento { get; set; } = 0;  // Descuento aplicado, por defecto 0

    [Column("costoTotal")]
    [Required]
    public decimal CostoTotal { get; set; }  // Costo total del envío

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;  // Fecha de creación del registro

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;  // Fecha de última actualización

    public CostosEnvio(Guid costoEnvioID, Guid ordenEnvioID, decimal costoBase, decimal costoAdicional, decimal descuento, decimal costoTotal, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        CostoEnvioID = costoEnvioID;
        OrdenEnvioID = ordenEnvioID;
        CostoBase = costoBase;
        CostoAdicional = costoAdicional;
        Descuento = descuento;
        CostoTotal = costoTotal;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public CostosEnvio()
    {
    }
}
