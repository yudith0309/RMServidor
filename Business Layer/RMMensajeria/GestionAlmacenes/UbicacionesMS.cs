namespace RMMensajeria.GestionAlmacenes;

public class UbicacionesMS
{
    public Guid UbicacionID { get; set; }
    public Guid AlmacenID { get; set; }
    public string CodigoUbicacion { get; set; }
    public string TipoUbicacion { get; set; }
    public decimal CapacidadUbicacion { get; set; }
    public bool Ocupado { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public UbicacionesMS(Guid ubicacionID, Guid almacenID, string codigoUbicacion, string tipoUbicacion, decimal capacidadUbicacion, bool ocupado, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        UbicacionID = ubicacionID;
        AlmacenID = almacenID;
        CodigoUbicacion = codigoUbicacion;
        TipoUbicacion = tipoUbicacion;
        CapacidadUbicacion = capacidadUbicacion;
        Ocupado = ocupado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public UbicacionesMS()
    {
    }
}

public class UbicacionesMSLista
{
    public UbicacionesMSLista() { }

    public UbicacionesMSLista(UbicacionesMS[] ubicacionesMS)
    {
        UbicacionesMS = UbicacionesMS;
    }
    public UbicacionesMS[] UbicacionesMS { get; set; }
}
