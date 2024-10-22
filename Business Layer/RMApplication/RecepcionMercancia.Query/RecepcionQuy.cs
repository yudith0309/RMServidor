using RecepcionMercancia.Interfaces;
using RecepcionMercancia.Query.Interfaces;
using RMMensajeria.RecepcionMercancia;
using Utilidades;

namespace RecepcionMercancia.Query;

public class RecepcionQuy : IRecepcionQuy
{
    private readonly IGestorId _gestorId;
    public RecepcionQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public RecepcionesMS DevuelveRecepcion(RecepcionesME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IRecepcionActor>().ObtenerRecepcionPorId(mensajeEntrada.RecepcionID);
        return new RecepcionesMS
        {
            RecepcionID = salida.RecepcionID,
            OrdenDeCompraID = salida.OrdenDeCompraID,
            FechaRecepcion = salida.FechaRecepcion,
            RecibidoPor = salida.RecibidoPor,
            Estado = salida.Estado,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public RecepcionesMSLista DevuelveTodosRecepciones(RecepcionesME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IRecepcionActor>().ObtenerListaRecepcion();
        var listaMS =
            lista.Transformar(recepcion =>
            new RecepcionesMS(recepcion.RecepcionID,
                              recepcion.OrdenDeCompraID,
                              recepcion.FechaRecepcion,
                              recepcion.RecibidoPor,
                              recepcion.Estado,
                              recepcion.FechaActualizacion,
                              recepcion.FechaCreacion));
        return new RecepcionesMSLista(listaMS.ToArray());

    }
}
