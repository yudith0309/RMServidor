namespace RMMensajeria.GestionAlmacenes;

public class OrdenesTransferenciaInternaMS
{
    public Guid OrdenTransferenciaID { get; set; }
    public Guid AlmacenOrigenID { get; set; }
    public Guid AlmacenDestinoID { get; set; }
    public Guid ProductoID { get; set; }
    public decimal CantidadTransferida { get; set; }
    public DateTime FechaTransferencia { get; set; }
    public string EstadoTransferencia { get; set; }
    public string UsuarioResponsable { get; set; }

    public OrdenesTransferenciaInternaMS(Guid ordenTransferenciaID, Guid almacenOrigenID, Guid almacenDestinoID, Guid productoID, decimal cantidadTransferida, DateTime fechaTransferencia, string estadoTransferencia, string usuarioResponsable)
    {
        OrdenTransferenciaID = ordenTransferenciaID;
        AlmacenOrigenID = almacenOrigenID;
        AlmacenDestinoID = almacenDestinoID;
        ProductoID = productoID;
        CantidadTransferida = cantidadTransferida;
        FechaTransferencia = fechaTransferencia;
        EstadoTransferencia = estadoTransferencia;
        UsuarioResponsable = usuarioResponsable;
    }
    public OrdenesTransferenciaInternaMS()
    {
    }
}
