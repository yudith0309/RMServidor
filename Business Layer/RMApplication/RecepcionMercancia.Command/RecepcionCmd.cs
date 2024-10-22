using RecepcionMercancia.Command.Interfaces;
using RecepcionMercancia.Entidad;
using RecepcionMercancia.Interfaces;
using RMMensajeria.RecepcionMercancia;
using Utilidades;

namespace RecepcionMercancia.Command;

public class RecepcionCmd : IRecepcionCmd
{
    private readonly IGestorId _gestorId;
    public RecepcionCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public RecepcionesMS NuevoRecepcion(RecepcionesME mensajeEntrada)
    {

        var nuevoRecepcion =
            new Recepcion(
                mensajeEntrada.RecepcionID,
                mensajeEntrada.OrdenDeCompraID,
                mensajeEntrada.FechaRecepcion,
                mensajeEntrada.RecibidoPor,
                mensajeEntrada.Estado,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IRecepcionActor>().ProcesaInsertar(nuevoRecepcion);

        return new RecepcionesMS
               (nuevoRecepcion.RecepcionID,
                nuevoRecepcion.OrdenDeCompraID,
                nuevoRecepcion.FechaRecepcion,
                nuevoRecepcion.RecibidoPor,
                nuevoRecepcion.Estado,
                nuevoRecepcion.FechaCreacion,
                nuevoRecepcion.FechaActualizacion);
    }

    public RecepcionesMS EliminarRecepcion(RecepcionesME mensajeEntrada)
    {
        var recepcionActor = _gestorId.Resuelve<IRecepcionActor>();
        var recepcion = _gestorId.Resuelve<IRecepcionActor>().ObtenerRecepcionPorId(mensajeEntrada.RecepcionID);

        recepcionActor.ProcesaEliminar(recepcion);

        return new RecepcionesMS();
    }
}
