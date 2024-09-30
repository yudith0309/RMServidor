namespace RMMensajeria.GestionAlmacenes;

public class AlmacenME
{
    public Guid AlmacenID { get; set; }
    public string NombreAlmacen { get; set; }
    public string Ubicacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public AlmacenME(Guid almacenID, string nombreAlmacen, string ubicacion, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        AlmacenID = almacenID;
        NombreAlmacen = nombreAlmacen;
        Ubicacion = ubicacion;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public AlmacenME()
    {
    }
}
