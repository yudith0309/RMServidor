namespace RMMensajeria.GestionCompras;

public class DetallesOrdenCompraME
{
    public Guid DetalleOrdenCompraID { get; set; }
    public Guid OrdenCompraID { get; set; }
    public Guid ProductoID { get; set; }
    public decimal Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal Subtotal { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;

    public DetallesOrdenCompraME(Guid detalleOrdenCompraID, Guid ordenCompraID, Guid productoID, decimal cantidad, decimal precioUnitario, decimal subtotal, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        DetalleOrdenCompraID = detalleOrdenCompraID;
        OrdenCompraID = ordenCompraID;
        ProductoID = productoID;
        Cantidad = cantidad;
        PrecioUnitario = precioUnitario;
        Subtotal = subtotal;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public DetallesOrdenCompraME()
    {
    }
}
