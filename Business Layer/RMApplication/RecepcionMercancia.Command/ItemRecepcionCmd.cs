using RecepcionMercancia.Command.Interfaces;
using RecepcionMercancia.Entidad;
using RecepcionMercancia.Interfaces;
using RMMensajeria.RecepcionMercancia;
using Utilidades;

namespace RecepcionMercancia.Command;

public class ItemRecepcionCmd: IItemRecepcionCmd
{
    private readonly IGestorId _gestorId;
    public ItemRecepcionCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public ItemsRecepcionMS NuevoItemRecepcion(ItemsRecepcionME mensajeEntrada)
    {
        var nuevoRecepcion =
            new ItemRecepcion(mensajeEntrada.RecepccionItemID,
                              mensajeEntrada.RecepcionID,
                              mensajeEntrada.ProductoID,
                              mensajeEntrada.CantidadRecibida,
                              mensajeEntrada.Condicion,
                              mensajeEntrada.Comentarios);

        _gestorId.Resuelve<IItemsRecepcionActor>().ProcesaInsertar(nuevoRecepcion);

        return new ItemsRecepcionMS
               (nuevoRecepcion.RecepccionItemID,
                nuevoRecepcion.RecepcionID,
                nuevoRecepcion.ProductoID,
                nuevoRecepcion.CantidadRecibida,
                nuevoRecepcion.Condicion,
                nuevoRecepcion.Comentarios);
    }

    public ItemsRecepcionMS EliminarItemRecepcion(ItemsRecepcionME mensajeEntrada)
    {
        var recepcionActor = _gestorId.Resuelve<IItemsRecepcionActor>();
        var recepcion = _gestorId.Resuelve<IItemsRecepcionActor>().ObtenerItemsRecepcionPorId(mensajeEntrada.RecepccionItemID);

        recepcionActor.ProcesaEliminar(recepcion);

        return new ItemsRecepcionMS();
    }
}
