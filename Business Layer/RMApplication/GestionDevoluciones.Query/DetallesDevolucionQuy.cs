using GestionDevoluciones.Interfaces;
using GestionDevoluciones.Query.Interfaces;
using RMMensajeria.GestionDevoluciones;
using Utilidades;

namespace GestionDevoluciones.Query;

public class DetallesDevolucionQuy: IDetallesDevolucionQuy
{
    private readonly IGestorId _gestorId;
    public DetallesDevolucionQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public DetallesDevolucionMS DevuelveDetallesDevolucion(DetallesDevolucionME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IDetallesDevolucionActor>().ObtenerDetallesDevolucionPorId(mensajeEntrada.DetalleDevolucionID);
        return new DetallesDevolucionMS
        {
            DetalleDevolucionID = salida.DetalleDevolucionID,
            DevolucionID = salida.DevolucionID,
            ProductoID = salida.ProductoID,
            Cantidad = salida.Cantidad,
            EstadoProducto = salida.EstadoProducto,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public DetallesDevolucionMSLista DevuelveTodosDetallesDevoluciones(DetallesDevolucionME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IDetallesDevolucionActor>().ObtenerListaDetallesDevolucion();
        var listaMS =
            lista.Transformar(detallesDevolucion =>
            new DetallesDevolucionMS(detallesDevolucion.DetalleDevolucionID,
                                     detallesDevolucion.DevolucionID,
                                     detallesDevolucion.ProductoID,
                                     detallesDevolucion.Cantidad,
                                     detallesDevolucion.EstadoProducto,
                                     detallesDevolucion.FechaCreacion,
                                     detallesDevolucion.FechaActualizacion));
        return new DetallesDevolucionMSLista(listaMS.ToArray());
    }
}
