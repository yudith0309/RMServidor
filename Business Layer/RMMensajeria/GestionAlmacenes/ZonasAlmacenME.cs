namespace RMMensajeria.GestionAlmacenes;

public class ZonasAlmacenME
{
    public Guid ZonaID { get; set; }
    public Guid AlmacenID { get; set; }
    public string NombreZona { get; set; }
    public string TipoZona { get; set; }
    public decimal CapacidadZona { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public ZonasAlmacenME(Guid zonaID, Guid almacenID, string nombreZona, string tipoZona, decimal capacidadZona, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        ZonaID = zonaID;
        AlmacenID = almacenID;
        NombreZona = nombreZona;
        TipoZona = tipoZona;
        CapacidadZona = capacidadZona;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public ZonasAlmacenME()
    {
    }
}
