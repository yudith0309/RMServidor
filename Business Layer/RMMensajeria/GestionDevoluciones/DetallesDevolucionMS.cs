namespace RMMensajeria.GestionDevoluciones;

public class DetallesDevolucionMS
{
    public Guid DetalleDevolucionID { get; set; }
    public Guid DevolucionID { get; set; }
    public Guid ProductoID { get; set; }
    public decimal Cantidad { get; set; }
    public string EstadoProducto { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;

    public DetallesDevolucionMS(Guid detalleDevolucionID, Guid devolucionID, Guid productoID, decimal cantidad, string estadoProducto, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        DetalleDevolucionID = detalleDevolucionID;
        DevolucionID = devolucionID;
        ProductoID = productoID;
        Cantidad = cantidad;
        EstadoProducto = estadoProducto;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public DetallesDevolucionMS()
    {
    }
}
