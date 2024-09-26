using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecepcionMercancia.Entidad;

[Table("Producto", Schema = "RecepcionMercancia")]
public class Producto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("productoID")]
    public Guid ProductoID { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("codigoProducto")]
    public string CodigoProducto { get; set; }

    [Required]
    [MaxLength(255)]
    [Column("nombreProducto")]
    public string NombreProducto { get; set; }

    [Column("descripcion")]
    public string Descripcion { get; set; }

    [MaxLength(50)]
    [Column("unidadMedida")]
    public string UnidadMedida { get; set; }

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.UtcNow;

    public Producto(Guid productoID, string codigoProducto, string nombreProducto, string descripcion, string unidadMedida, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        ProductoID = productoID;
        CodigoProducto = codigoProducto;
        NombreProducto = nombreProducto;
        Descripcion = descripcion;
        UnidadMedida = unidadMedida;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
}
