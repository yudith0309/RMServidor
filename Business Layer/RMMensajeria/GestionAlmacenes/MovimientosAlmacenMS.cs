namespace RMMensajeria.GestionAlmacenes;

public class MovimientosAlmacenMS
{
    public Guid MovimientoID { get; set; }
    public Guid ProductoID { get; set; }
    public Guid UbicacionOrigenID { get; set; }
    public Guid UbicacionDestinoID { get; set; }
    public string TipoMovimiento { get; set; }
    public decimal CantidadMovida { get; set; }
    public DateTime FechaMovimiento { get; set; }
    public string DocumentoRelacionado { get; set; }
    public string UsuarioResponsable { get; set; }

    public MovimientosAlmacenMS(Guid movimientoID, Guid productoID, Guid ubicacionOrigenID, Guid ubicacionDestinoID, string tipoMovimiento, decimal cantidadMovida, DateTime fechaMovimiento, string documentoRelacionado, string usuarioResponsable)
    {
        MovimientoID = movimientoID;
        ProductoID = productoID;
        UbicacionOrigenID = ubicacionOrigenID;
        UbicacionDestinoID = ubicacionDestinoID;
        TipoMovimiento = tipoMovimiento;
        CantidadMovida = cantidadMovida;
        FechaMovimiento = fechaMovimiento;
        DocumentoRelacionado = documentoRelacionado;
        UsuarioResponsable = usuarioResponsable;
    }
    public MovimientosAlmacenMS()
    {
    }
}
