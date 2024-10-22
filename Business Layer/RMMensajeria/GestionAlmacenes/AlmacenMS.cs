namespace RMMensajeria.GestionAlmacenes;

public class AlmacenMS
{
    public Guid AlmacenID { get; set; }
    public string NombreAlmacen { get; set; }
    public string Ubicacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public AlmacenMS(Guid almacenID, string nombreAlmacen, string ubicacion, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        AlmacenID = almacenID;
        NombreAlmacen = nombreAlmacen;
        Ubicacion = ubicacion;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public AlmacenMS()
    {
    }
}

public class AlmacenMSLista
{
    public AlmacenMSLista() { }

    public AlmacenMSLista(AlmacenMS[] almacenMS)
    {
        AlmacenMS = almacenMS;
    }
    public AlmacenMS[] AlmacenMS { get; set; }
}
