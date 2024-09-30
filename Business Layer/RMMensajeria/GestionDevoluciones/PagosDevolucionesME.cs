namespace RMMensajeria.GestionDevoluciones;

public class PagosDevolucionesME
{
    public Guid PagoDevolucionID { get; set; }
    public Guid DevolucionID { get; set; }
    public decimal MontoReembolsado { get; set; }
    public DateTime FechaReembolso { get; set; }
    public string MetodoPago { get; set; }
    public string EstadoReembolso { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;

    public PagosDevolucionesME(Guid pagoDevolucionID, Guid devolucionID, decimal montoReembolsado, DateTime fechaReembolso, string metodoPago, string estadoReembolso, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        PagoDevolucionID = pagoDevolucionID;
        DevolucionID = devolucionID;
        MontoReembolsado = montoReembolsado;
        FechaReembolso = fechaReembolso;
        MetodoPago = metodoPago;
        EstadoReembolso = estadoReembolso;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public PagosDevolucionesME()
    {
    }
}
