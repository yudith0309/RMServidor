namespace RMMensajeria.TransporteEnvios;

public class OrdenesEnvioMS
{
    public Guid OrdenEnvioID { get; set; }
    public Guid PedidoID { get; set; }
    public Guid TransportistaID { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public string Estado { get; set; }
    public DateTime? FechaEnvio { get; set; }
    public DateTime? FechaEntregaEstimada { get; set; }
    public decimal CostoEnvio { get; set; }
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;

    public OrdenesEnvioMS(Guid ordenEnvioID, Guid pedidoID, Guid transportistaID, DateTime fechaCreacion, string estado, DateTime? fechaEnvio, DateTime? fechaEntregaEstimada, decimal costoEnvio, DateTime fechaActualizacion)
    {
        OrdenEnvioID = ordenEnvioID;
        PedidoID = pedidoID;
        TransportistaID = transportistaID;
        FechaCreacion = fechaCreacion;
        Estado = estado;
        FechaEnvio = fechaEnvio;
        FechaEntregaEstimada = fechaEntregaEstimada;
        CostoEnvio = costoEnvio;
        FechaActualizacion = fechaActualizacion;
    }
    public OrdenesEnvioMS()
    {
    }
}

public class OrdenesEnvioMSLista
{
    public OrdenesEnvioMSLista() { }

    public OrdenesEnvioMSLista(OrdenesEnvioMS[] ordenesEnvioMS)
    {
        OrdenesEnvioMS = ordenesEnvioMS;
    }
    public OrdenesEnvioMS[] OrdenesEnvioMS { get; set; }
}

