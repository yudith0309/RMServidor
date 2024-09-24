using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecepcionMercancia;

[Table("Producto", Schema = "RecepcionMercancia")]
public class Producto
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("ProductoID")]
    public Guid ProductoID { get; set; }

    [Required]
    [MaxLength(100)]
    [Column("CodigoProducto")]
    public string CodigoProducto { get; set; }

    [Required]
    [MaxLength(255)]
    [Column("NombreProducto")]
    public string NombreProducto { get; set; }

    [Column("Descripcion")]
    public string Descripcion { get; set; }

    [MaxLength(50)]
    [Column("UnidadMedida")]
    public string UnidadMedida { get; set; }

    [Column("FechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    [Column("FechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.UtcNow;
}
