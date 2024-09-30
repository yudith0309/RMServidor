namespace RMMensajeria.GestionInventarios;

public class MovimientosInventarioMS
{
    public Guid MovimientoID { get; set; }
    public Guid ProductoID { get; set; }
    public Guid AlmacenID { get; set; }
    public string TipoMovimiento { get; set; }
    public decimal Cantidad { get; set; }
    public DateTime FechaMovimiento { get; set; }
    public string DocumentoRelacionado { get; set; }
    public string CreadoPor { get; set; }

    public MovimientosInventarioMS(Guid movimientoID, Guid productoID, Guid almacenID, string tipoMovimiento, decimal cantidad, DateTime fechaMovimiento, string documentoRelacionado, string creadoPor)
    {
        MovimientoID = movimientoID;
        ProductoID = productoID;
        AlmacenID = almacenID;
        TipoMovimiento = tipoMovimiento;
        Cantidad = cantidad;
        FechaMovimiento = fechaMovimiento;
        DocumentoRelacionado = documentoRelacionado;
        CreadoPor = creadoPor;
    }
    public MovimientosInventarioMS()
    {
    }
}
