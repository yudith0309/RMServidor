namespace RMMensajeria.GestionPedidos;

public class PagosME
{
    public Guid PagoID { get; set; }
    public Guid PedidoID { get; set; }
    public decimal Monto { get; set; }
    public DateTime FechaPago { get; set; }
    public string MetodoPago { get; set; }
    public string EstadoPago { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public PagosME(Guid pagoID, Guid pedidoID, decimal monto, DateTime fechaPago, string metodoPago, string estadoPago, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        PagoID = pagoID;
        PedidoID = pedidoID;
        Monto = monto;
        FechaPago = fechaPago;
        MetodoPago = metodoPago;
        EstadoPago = estadoPago;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public PagosME()
    {
    }
}
