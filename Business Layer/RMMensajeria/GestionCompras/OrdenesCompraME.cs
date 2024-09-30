namespace RMMensajeria.GestionCompras;

public class OrdenesCompraME
{
    public Guid OrdenCompraID { get; set; }
    public Guid ProveedorID { get; set; }
    public DateTime FechaOrden { get; set; }
    public DateTime? FechaEntregaEstimada { get; set; }
    public decimal Total { get; set; }
    public string Estado { get; set; }

    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;

    public OrdenesCompraME(Guid ordenCompraID, Guid proveedorID, DateTime fechaOrden, DateTime? fechaEntregaEstimada, decimal total, string estado, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        OrdenCompraID = ordenCompraID;
        ProveedorID = proveedorID;
        FechaOrden = fechaOrden;
        FechaEntregaEstimada = fechaEntregaEstimada;
        Total = total;
        Estado = estado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public OrdenesCompraME()
    {
    }
}
