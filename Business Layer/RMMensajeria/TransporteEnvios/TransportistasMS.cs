namespace RMMensajeria.TransporteEnvios;

public class TransportistasMS
{
    public Guid TransportistaID { get; set; }
    public string NombreTransportista { get; set; }
    public string Telefono { get; set; }
    public string Email { get; set; }
    public string Direccion { get; set; }
    public decimal TarifaBase { get; set; }
    public string Estado { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;

    public TransportistasMS(Guid transportistaID, string nombreTransportista, string telefono, string email, string direccion, decimal tarifaBase, string estado, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        TransportistaID = transportistaID;
        NombreTransportista = nombreTransportista;
        Telefono = telefono;
        Email = email;
        Direccion = direccion;
        TarifaBase = tarifaBase;
        Estado = estado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public TransportistasMS()
    {
    }
}
