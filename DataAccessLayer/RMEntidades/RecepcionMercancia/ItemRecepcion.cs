using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecepcionMercancia.Entidad;

[Table("Items_recepcion", Schema = "RecepcionMercancia")]
public class ItemRecepcion
{
    [Key]
    [Column("recepccion_item_id")]
    public Guid RecepccionItemID { get; set; }  // Clave primaria

    [Column("recepcion_id")]
    [Required]
    public Guid RecepcionID { get; set; }  // Clave foránea que referencia a Recepción

    [Column("producto_id")]
    [Required]
    public Guid ProductoID { get; set; }  // Clave foránea que referencia a Producto

    [Column("cantidad_recibida")]
    [Required]
    public int CantidadRecibida { get; set; }  // Cantidad de producto recibido

    [Column("condicion")]
    [StringLength(50)]
    public string Condicion { get; set; }  // Condición del producto

    [Column("comentarios")]
    public string Comentarios { get; set; }  // Comentarios adicionales

    public ItemRecepcion(Guid receptionItemID, Guid recepcionID, Guid productoID, int cantidadRecibida, string condicion, string comentarios)
    {
        RecepccionItemID = receptionItemID;
        RecepcionID = recepcionID;
        ProductoID = productoID;
        CantidadRecibida = cantidadRecibida;
        Condicion = condicion;
        Comentarios = comentarios;
    }
}