using GestionDevoluciones.Interfaces;
using GestionDevoluciones.Query.Interfaces;
using RMMensajeria.GestionDevoluciones;
using Utilidades;

namespace GestionDevoluciones.Query;

public class DevolucionesQuy: IDevolucionesQuy
{
    private readonly IGestorId _gestorId;
    public DevolucionesQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public DevolucionesMS DevuelveDevoluciones(DevolucionesME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IDevolucionesActor>().ObtenerDevolucionesPorId(mensajeEntrada.DevolucionID);
        return new DevolucionesMS
        {
            DevolucionID = salida.DevolucionID,
            PedidoID = salida.PedidoID,
            FechaDevolucion = salida.FechaDevolucion,
            Motivo = salida.Motivo,
            EstadoDevolucion = salida.EstadoDevolucion,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public DevolucionesMSLista DevuelveTodosDevolucioneses(DevolucionesME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IDevolucionesActor>().ObtenerListaDevoluciones();
        var listaMS =
            lista.Transformar(devoluciones =>
            new DevolucionesMS(devoluciones.DevolucionID,
                               devoluciones.PedidoID,
                               devoluciones.FechaDevolucion,
                               devoluciones.Motivo,
                               devoluciones.EstadoDevolucion,
                               devoluciones.FechaCreacion,
                               devoluciones.FechaActualizacion));
        return new DevolucionesMSLista(listaMS.ToArray());
    }
}
