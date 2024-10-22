namespace RMMensajeria.GestionInventarioUbicaciones;

public class InventarioUbicacionesMS
{
    public Guid InventarioUbicacionID { get; set; }
    public Guid UbicacionID { get; set; }
    public Guid ProductoID { get; set; }
    public decimal CantidadDisponible { get; set; }
    public decimal CantidadReservada { get; set; }
    public DateTime FechaUltimaActualizacion { get; set; }

    public InventarioUbicacionesMS(Guid inventarioUbicacionID, Guid ubicacionID, Guid productoID, decimal cantidadDisponible, decimal cantidadReservada, DateTime fechaUltimaActualizacion)
    {
        InventarioUbicacionID = inventarioUbicacionID;
        UbicacionID = ubicacionID;
        ProductoID = productoID;
        CantidadDisponible = cantidadDisponible;
        CantidadReservada = cantidadReservada;
        FechaUltimaActualizacion = fechaUltimaActualizacion;
    }

    public InventarioUbicacionesMS()
    {
    }
}

public class InventarioUbicacionesMSLista
{
    public InventarioUbicacionesMSLista() { }

    public InventarioUbicacionesMSLista(InventarioUbicacionesMS[] inventarioUbicacionesMS)
    {
        InventarioUbicacionesMS = inventarioUbicacionesMS;
    }
    public InventarioUbicacionesMS[] InventarioUbicacionesMS { get; set; }
}

