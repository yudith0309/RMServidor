namespace RMMensajeria.TransporteEnvios;

public class RutasMS
{
    public Guid RutaID { get; set; }
    public Guid OrdenEnvioID { get; set; }
    public string PuntoSalida { get; set; }
    public string PuntoDestino { get; set; }
    public decimal Distancia { get; set; }
    public string TiempoEstimado { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;

    public RutasMS(Guid rutaID, Guid ordenEnvioID, string puntoSalida, string puntoDestino, decimal distancia, string tiempoEstimado, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        RutaID = rutaID;
        OrdenEnvioID = ordenEnvioID;
        PuntoSalida = puntoSalida;
        PuntoDestino = puntoDestino;
        Distancia = distancia;
        TiempoEstimado = tiempoEstimado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public RutasMS()
    {
    }
}
