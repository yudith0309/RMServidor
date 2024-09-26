using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RecepcionMercancia.Entidad;

[Table("ItemDeOrdenDeCompra", Schema = "RecepcionMercancia")]
public class ItemDeOrdenDeCompra
{
    [Key]
    [Column("item_de_orden_de_compra_id")]
    public Guid ItemDeOrdenDeCompraID { get; set; }  // Clave primaria

    [Column("orden_de_compra_id")]
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

    [Column("precio_total")]
    public decimal PrecioTotal => CantidadOrdenada * PrecioUnitario;  // Precio total calculado

    // Relaciones con otras entidades
    [ForeignKey("OrdenDeCompraID")]
    public OrdenDeCompra OrdenDeCompra { get; set; }  // Navegación a la entidad Orden de Compra

    [ForeignKey("ProductoID")]
    public Producto Producto { get; set; }  // Navegación a la entidad Producto

    public ItemDeOrdenDeCompra(Guid itemDeOrdenDeCompraID, Guid ordenDeCompraID, Guid productoID, int cantidadOrdenada, decimal precioUnitario, OrdenDeCompra ordenDeCompra, Producto producto)
    {
        ItemDeOrdenDeCompraID = itemDeOrdenDeCompraID;
        OrdenDeCompraID = ordenDeCompraID;
        ProductoID = productoID;
        CantidadOrdenada = cantidadOrdenada;
        PrecioUnitario = precioUnitario;
        OrdenDeCompra = ordenDeCompra;
        Producto = producto;
    }
}