namespace RMMensajeria.GestionInventarios;

public class InventariosME
{
    public Guid InventarioID { get; set; }
    public Guid AlmacenID { get; set; }
    public Guid ProductoID { get; set; }
    public int CantidadDisponible { get; set; }
    public DateTime FechaUltimaActualizacion { get; set; }

    public InventariosME(Guid inventarioID, Guid almacenID, Guid productoID, int cantidadDisponible, DateTime fechaUltimaActualizacion)
    {
        InventarioID = inventarioID;
        AlmacenID = almacenID;
        ProductoID = productoID;
        CantidadDisponible = cantidadDisponible;
        FechaUltimaActualizacion = fechaUltimaActualizacion;
    }
    public InventariosME()
    {
    }
}
