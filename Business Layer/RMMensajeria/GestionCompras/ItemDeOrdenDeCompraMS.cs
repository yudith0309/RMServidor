namespace RMMensajeria.GestionCompras;

public class ItemDeOrdenDeCompraMS
{
    public Guid ItemDeOrdenDeCompraID { get; set; }
    public Guid OrdenDeCompraID { get; set; }
    public Guid ProductoID { get; set; }
    public int CantidadOrdenada { get; set; }
    public decimal PrecioUnitario { get; set; }

    public ItemDeOrdenDeCompraMS(Guid itemDeOrdenDeCompraID, Guid ordenDeCompraID, Guid productoID, int cantidadOrdenada, decimal precioUnitario, decimal precioTotal)
    {
        ItemDeOrdenDeCompraID = itemDeOrdenDeCompraID;
        OrdenDeCompraID = ordenDeCompraID;
        ProductoID = productoID;
        CantidadOrdenada = cantidadOrdenada;
        PrecioUnitario = precioUnitario;
    }
    public ItemDeOrdenDeCompraMS()
    {
    }
}

public class ItemDeOrdenDeCompraMSLista
{
    public ItemDeOrdenDeCompraMSLista() { }

    public ItemDeOrdenDeCompraMSLista(ItemDeOrdenDeCompraMS[] itemDeOrdenDeCompraMS)
    {
        ItemDeOrdenDeCompraMS = itemDeOrdenDeCompraMS;
    }
    public ItemDeOrdenDeCompraMS[] ItemDeOrdenDeCompraMS { get; set; }
}
