namespace RMMensajeria.GestionInventarios;

public class InventarioUbicacionesME
{
    public Guid InventarioUbicacionID { get; set; }
    public Guid UbicacionID { get; set; }
    public Guid ProductoID { get; set; }
    public decimal CantidadDisponible { get; set; }
    public decimal CantidadReservada { get; set; }
    public DateTime FechaUltimaActualizacion { get; set; }

    public InventarioUbicacionesME(Guid inventarioUbicacionID, Guid ubicacionID, Guid productoID, decimal cantidadDisponible, decimal cantidadReservada, DateTime fechaUltimaActualizacion)
    {
        InventarioUbicacionID = inventarioUbicacionID;
        UbicacionID = ubicacionID;
        ProductoID = productoID;
        CantidadDisponible = cantidadDisponible;
        CantidadReservada = cantidadReservada;
        FechaUltimaActualizacion = fechaUltimaActualizacion;
    }
    public InventarioUbicacionesME()
    {
    }
}
