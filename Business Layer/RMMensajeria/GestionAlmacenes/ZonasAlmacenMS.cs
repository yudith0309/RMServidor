namespace RMMensajeria.GestionAlmacenes;

public class ZonasAlmacenMS
{
    public Guid ZonaID { get; set; }
    public Guid AlmacenID { get; set; }
    public string NombreZona { get; set; }
    public string TipoZona { get; set; }
    public decimal CapacidadZona { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public ZonasAlmacenMS(Guid zonaID, Guid almacenID, string nombreZona, string tipoZona, decimal capacidadZona, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        ZonaID = zonaID;
        AlmacenID = almacenID;
        NombreZona = nombreZona;
        TipoZona = tipoZona;
        CapacidadZona = capacidadZona;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public ZonasAlmacenMS()
    {
    }
}

public class ZonasAlmacenMSLista
{
    public ZonasAlmacenMSLista() { }

    public ZonasAlmacenMSLista(ZonasAlmacenMS[] zonasAlmacenMS)
    {
        ZonasAlmacenMS = zonasAlmacenMS;
    }
    public ZonasAlmacenMS[] ZonasAlmacenMS { get; set; }
}
