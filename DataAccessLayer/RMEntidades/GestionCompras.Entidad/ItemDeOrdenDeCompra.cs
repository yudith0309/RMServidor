using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionCompras.Entidad;

[Table("ItemDeOrdenDeCompra", Schema = "GestionCompras")]
public class ItemDeOrdenDeCompra
{
    [Key]
    [Column("itemDeOrdenDeCompraID")]
    public Guid ItemDeOrdenDeCompraID { get; set; }  // Clave primaria

    [Column("ordenDeCompraID")]
    [Required]
    public Guid OrdenDeCompraID { get; set; }  // Clave foránea que referencia a Orden de Compra

    [Column("producto_id")]
    [Required]
    public Guid ProductoID { get; set; }  // Clave foránea que referencia a Producto

    [Column("cantidad_ordenada")]
    [Required]
    public int CantidadOrdenada { get; set; }  // Cantidad ordenada

    [Column("precio_unitario")]
    [Required]
    public decimal PrecioUnitario { get; set; }  // Precio unitario del producto

    public ItemDeOrdenDeCompra(Guid itemDeOrdenDeCompraID, Guid ordenDeCompraID, Guid productoID, int cantidadOrdenada, decimal precioUnitario)
    {
        ItemDeOrdenDeCompraID = itemDeOrdenDeCompraID;
        OrdenDeCompraID = ordenDeCompraID;
        ProductoID = productoID;
        CantidadOrdenada = cantidadOrdenada;
        PrecioUnitario = precioUnitario;
    }
    public ItemDeOrdenDeCompra()
    {
    }
}