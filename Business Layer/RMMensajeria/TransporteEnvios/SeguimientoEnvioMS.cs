namespace RMMensajeria.TransporteEnvios;

public class SeguimientoEnvioMS
{
    public Guid SeguimientoID { get; set; }
    public Guid OrdenEnvioID { get; set; }
    public DateTime FechaRegistro { get; set; }
    public string Estado { get; set; }
    public string UbicacionActual { get; set; }
    public string Comentarios { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;

    public SeguimientoEnvioMS(Guid seguimientoID, Guid ordenEnvioID, DateTime fechaRegistro, string estado, string ubicacionActual, string comentarios, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        SeguimientoID = seguimientoID;
        OrdenEnvioID = ordenEnvioID;
        FechaRegistro = fechaRegistro;
        Estado = estado;
        UbicacionActual = ubicacionActual;
        Comentarios = comentarios;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public SeguimientoEnvioMS()
    {
    }
}
