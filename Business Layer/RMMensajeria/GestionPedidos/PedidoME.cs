namespace RMMensajeria.GestionPedidos;

public class PedidoME
{
    public Guid PedidoID { get; set; }
    public Guid ClienteID { get; set; }
    public DateTime FechaPedido { get; set; }
    public string EstadoPedido { get; set; }
    public decimal Total { get; set; }
    public string MetodoPago { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public PedidoME(Guid pedidoID, Guid clienteID, DateTime fechaPedido, string estadoPedido, decimal total, string metodoPago, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        PedidoID = pedidoID;
        ClienteID = clienteID;
        FechaPedido = fechaPedido;
        EstadoPedido = estadoPedido;
        Total = total;
        MetodoPago = metodoPago;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public PedidoME()
    {
    }
}
