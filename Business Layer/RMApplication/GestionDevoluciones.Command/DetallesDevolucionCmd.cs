using GestionDevoluciones.Command.Interfaces;
using GestionDevoluciones.Entidad;
using GestionDevoluciones.Interfaces;
using RMMensajeria.GestionDevoluciones;
using Utilidades;

namespace GestionDevoluciones.Command;

public class DetallesDevolucionCmd : IDetallesDevolucionCmd
{
    private readonly IGestorId _gestorId;
    public DetallesDevolucionCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public DetallesDevolucionMS NuevoDetallesDevolucion(DetallesDevolucionME mensajeEntrada)
    {
        var nuevoDetallesDevolucion =
            new DetallesDevolucion(
                mensajeEntrada.DetalleDevolucionID,
                mensajeEntrada.DevolucionID,
                mensajeEntrada.ProductoID,
                mensajeEntrada.Cantidad,
                mensajeEntrada.EstadoProducto,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IDetallesDevolucionActor>().ProcesaInsertar(nuevoDetallesDevolucion);

        return new DetallesDevolucionMS
               (nuevoDetallesDevolucion.DetalleDevolucionID,
                nuevoDetallesDevolucion.DevolucionID,
                nuevoDetallesDevolucion.ProductoID,
                nuevoDetallesDevolucion.Cantidad,
                nuevoDetallesDevolucion.EstadoProducto,
                nuevoDetallesDevolucion.FechaCreacion,
                nuevoDetallesDevolucion.FechaActualizacion);
    }

    public DetallesDevolucionMS EliminarDetallesDevolucion(DetallesDevolucionME mensajeEntrada)
    {
        var detallesDevolucionActor = _gestorId.Resuelve<IDetallesDevolucionActor>();
        var detallesDevolucion = _gestorId.Resuelve<IDetallesDevolucionActor>().ObtenerDetallesDevolucionPorId(mensajeEntrada.DetalleDevolucionID);

        detallesDevolucionActor.ProcesaEliminar(detallesDevolucion);

        return new DetallesDevolucionMS();
    }
}
