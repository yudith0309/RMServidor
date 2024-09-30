namespace RMMensajeria.GestionCompras;

public class ItemDeOrdenDeCompraME
{
    public Guid ItemDeOrdenDeCompraID { get; set; }
    public Guid OrdenDeCompraID { get; set; }
    public Guid ProductoID { get; set; }
    public int CantidadOrdenada { get; set; }
    public decimal PrecioUnitario { get; set; }

    public ItemDeOrdenDeCompraME(Guid itemDeOrdenDeCompraID, Guid ordenDeCompraID, Guid productoID, int cantidadOrdenada, decimal precioUnitario)
    {
        ItemDeOrdenDeCompraID = itemDeOrdenDeCompraID;
        OrdenDeCompraID = ordenDeCompraID;
        ProductoID = productoID;
        CantidadOrdenada = cantidadOrdenada;
        PrecioUnitario = precioUnitario;
    }
    public ItemDeOrdenDeCompraME()
    {
    }
}
