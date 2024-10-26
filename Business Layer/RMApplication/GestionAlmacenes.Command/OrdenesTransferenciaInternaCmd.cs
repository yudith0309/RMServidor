using GestionAlmacenes.Command.Interfaces;
using GestionAlmacenes.Entidad;
using GestionAlmacenes.Interfaces;
using RMMensajeria.GestionAlmacenes;
using Utilidades;

namespace GestionAlmacenes.Command;

public class OrdenesTransferenciaInternaCmd : IOrdenesTransferenciaInternaCmd
{
    private readonly IGestorId _gestorId;
    public OrdenesTransferenciaInternaCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public OrdenesTransferenciaInternaMS NuevoOrdenesTransferenciaInterna(OrdenesTransferenciaInternaME mensajeEntrada)
    {
        var nuevoOrdenesTransferenciaInterna =
            new OrdenesTransferenciaInterna(mensajeEntrada.OrdenTransferenciaID,
                                            mensajeEntrada.AlmacenOrigenID,
                                            mensajeEntrada.AlmacenDestinoID,
                                            mensajeEntrada.ProductoID,
                                            mensajeEntrada.CantidadTransferida,
                                            mensajeEntrada.FechaTransferencia,
                                            mensajeEntrada.EstadoTransferencia,
                                            mensajeEntrada.UsuarioResponsable);

        _gestorId.Resuelve<IOrdenesTransferenciaInternaActor>().ProcesaInsertar(nuevoOrdenesTransferenciaInterna);

        return new OrdenesTransferenciaInternaMS
               (nuevoOrdenesTransferenciaInterna.OrdenTransferenciaID,
                nuevoOrdenesTransferenciaInterna.AlmacenOrigenID,
                nuevoOrdenesTransferenciaInterna.AlmacenDestinoID,
                nuevoOrdenesTransferenciaInterna.ProductoID,
                nuevoOrdenesTransferenciaInterna.CantidadTransferida,
                nuevoOrdenesTransferenciaInterna.FechaTransferencia,
                nuevoOrdenesTransferenciaInterna.EstadoTransferencia,
                nuevoOrdenesTransferenciaInterna.UsuarioResponsable);
    }
    public OrdenesTransferenciaInternaMS EliminarOrdenesTransferenciaInterna(OrdenesTransferenciaInternaME mensajeEntrada)
    {
        var ordenesTransferenciaInternaActor = _gestorId.Resuelve<IOrdenesTransferenciaInternaActor>();
        var ordenesTransferenciaInterna = _gestorId.Resuelve<IOrdenesTransferenciaInternaActor>().ObtenerOrdenesTransferenciaPorId(mensajeEntrada.OrdenTransferenciaID);

        ordenesTransferenciaInternaActor.ProcesaEliminar(ordenesTransferenciaInterna);

        return new OrdenesTransferenciaInternaMS();
    }
}
