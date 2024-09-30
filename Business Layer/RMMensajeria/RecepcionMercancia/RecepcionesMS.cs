namespace RMMensajeria.RecepcionMercancia;

public class RecepcionesMS
{
    public Guid RecepcionID { get; set; }
    public Guid OrdenDeCompraID { get; set; }
    public DateTime FechaRecepcion { get; set; }
    public string RecibidoPor { get; set; }
    public string Estado { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public RecepcionesMS(Guid recepcionID, Guid ordenDeCompraID, DateTime fechaRecepcion, string recibidoPor, string estado, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        RecepcionID = recepcionID;
        OrdenDeCompraID = ordenDeCompraID;
        FechaRecepcion = fechaRecepcion;
        RecibidoPor = recibidoPor;
        Estado = estado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public RecepcionesMS()
    {
    }
}
