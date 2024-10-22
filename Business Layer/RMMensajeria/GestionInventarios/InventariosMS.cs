namespace RMMensajeria.GestionInventarios;

public class InventariosMS
{
    public Guid InventarioID { get; set; }
    public Guid AlmacenID { get; set; }
    public Guid ProductoID { get; set; }
    public int CantidadDisponible { get; set; }
    public DateTime FechaUltimaActualizacion { get; set; }

    public InventariosMS(Guid inventarioID, Guid almacenID, Guid productoID, int cantidadDisponible, DateTime fechaUltimaActualizacion)
    {
        InventarioID = inventarioID;
        AlmacenID = almacenID;
        ProductoID = productoID;
        CantidadDisponible = cantidadDisponible;
        FechaUltimaActualizacion = fechaUltimaActualizacion;
    }
    public InventariosMS()
    {
    }
}

public class InventariosMSLista
{
    public InventariosMSLista() { }

    public InventariosMSLista(InventariosMS[] inventariosMS)
    {
        InventariosMS = inventariosMS;
    }
    public InventariosMS[] InventariosMS { get; set; }
}
