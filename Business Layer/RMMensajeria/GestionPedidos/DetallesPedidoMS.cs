namespace RMMensajeria.GestionPedidos;

public class DetallesPedidoMS
{
    public Guid DetalleID { get; set; }
    public Guid PedidoID { get; set; }
    public Guid ProductoID { get; set; }
    public decimal Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }
    public decimal Subtotal { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public DetallesPedidoMS(Guid detalleID, Guid pedidoID, Guid productoID, decimal cantidad, decimal precioUnitario, decimal subtotal, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        DetalleID = detalleID;
        PedidoID = pedidoID;
        ProductoID = productoID;
        Cantidad = cantidad;
        PrecioUnitario = precioUnitario;
        Subtotal = subtotal;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public DetallesPedidoMS()
    {
    }
}
