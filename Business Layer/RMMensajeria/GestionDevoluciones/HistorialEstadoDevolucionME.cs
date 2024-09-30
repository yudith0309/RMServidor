namespace RMMensajeria.GestionDevoluciones;

public class HistorialEstadoDevolucionME
{
    public Guid HistorialDevolucionID { get; set; }
    public Guid DevolucionID { get; set; }
    public string EstadoAnterior { get; set; }
    public string EstadoNuevo { get; set; }
    public DateTime FechaCambio { get; set; }
    public string UsuarioResponsable { get; set; }

    public HistorialEstadoDevolucionME(Guid historialDevolucionID, Guid devolucionID, string estadoAnterior, string estadoNuevo, DateTime fechaCambio, string usuarioResponsable)
    {
        HistorialDevolucionID = historialDevolucionID;
        DevolucionID = devolucionID;
        EstadoAnterior = estadoAnterior;
        EstadoNuevo = estadoNuevo;
        FechaCambio = fechaCambio;
        UsuarioResponsable = usuarioResponsable;
    }
    public HistorialEstadoDevolucionME()
    {
    }
}
