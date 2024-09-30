namespace RMMensajeria.GestionProveedores;

public class PagosProveedoresMS
{
    public Guid PagoProveedorID { get; set; }
    public Guid ProveedorID { get; set; }
    public decimal Monto { get; set; }
    public DateTime FechaPago { get; set; } = DateTime.Now;
    public string MetodoPago { get; set; }
    public string EstadoPago { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;

    public PagosProveedoresMS(Guid pagoProveedorID, Guid proveedorID, decimal monto, DateTime fechaPago, string metodoPago, string estadoPago, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        PagoProveedorID = pagoProveedorID;
        ProveedorID = proveedorID;
        Monto = monto;
        FechaPago = fechaPago;
        MetodoPago = metodoPago;
        EstadoPago = estadoPago;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public PagosProveedoresMS()
    {
    }
}
