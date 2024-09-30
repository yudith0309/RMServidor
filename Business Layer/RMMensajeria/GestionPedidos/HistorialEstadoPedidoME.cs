namespace RMMensajeria.GestionPedidos;

public class HistorialEstadoPedidoME
{
    public Guid HistorialID { get; set; }
    public Guid PedidoID { get; set; }
    public string EstadoAnterior { get; set; }
    public string EstadoNuevo { get; set; }
    public DateTime FechaCambio { get; set; }
    public string UsuarioResponsable { get; set; }

    public HistorialEstadoPedidoME(Guid historialID, Guid pedidoID, string estadoAnterior, string estadoNuevo, DateTime fechaCambio, string usuarioResponsable)
    {
        HistorialID = historialID;
        PedidoID = pedidoID;
        EstadoAnterior = estadoAnterior;
        EstadoNuevo = estadoNuevo;
        FechaCambio = fechaCambio;
        UsuarioResponsable = usuarioResponsable;
    }
    public HistorialEstadoPedidoME()
    {
    }
}
