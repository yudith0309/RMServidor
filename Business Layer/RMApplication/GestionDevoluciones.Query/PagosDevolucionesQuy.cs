using GestionDevoluciones.Interfaces;
using GestionDevoluciones.Query.Interfaces;
using RMMensajeria.GestionDevoluciones;
using Utilidades;

namespace GestionDevoluciones.Query;

public class PagosDevolucionesQuy : IPagosDevolucionesQuy
{
    private readonly IGestorId _gestorId;
    public PagosDevolucionesQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public PagosDevolucionesMS DevuelvePagosDevoluciones(PagosDevolucionesME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IPagosDevolucionesActor>().ObtenerPagosDevolucionesPorId(mensajeEntrada.DevolucionID);
        return new PagosDevolucionesMS
        {
            PagoDevolucionID = salida.PagoDevolucionID,
            DevolucionID = salida.DevolucionID,
            MontoReembolsado = salida.MontoReembolsado,
            FechaReembolso = salida.FechaReembolso,
            MetodoPago = salida.MetodoPago,
            EstadoReembolso = salida.EstadoReembolso,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public PagosDevolucionesMSLista DevuelveTodosPagosDevolucioneses(PagosDevolucionesME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IPagosDevolucionesActor>().ObtenerListaPagosDevoluciones();
        var listaMS =
            lista.Transformar(pagosDevoluciones =>
            new PagosDevolucionesMS(pagosDevoluciones.PagoDevolucionID,
                                    pagosDevoluciones.DevolucionID,
                                    pagosDevoluciones.MontoReembolsado,
                                    pagosDevoluciones.FechaReembolso,
                                    pagosDevoluciones.MetodoPago,
                                    pagosDevoluciones.EstadoReembolso,
                                    pagosDevoluciones.FechaCreacion,
                                    pagosDevoluciones.FechaActualizacion));
        return new PagosDevolucionesMSLista(listaMS.ToArray());
    }
}
