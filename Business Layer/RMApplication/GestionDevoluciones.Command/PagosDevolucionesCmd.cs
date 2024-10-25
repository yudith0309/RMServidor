using GestionDevoluciones.Command.Interfaces;
using GestionDevoluciones.Entidad;
using GestionDevoluciones.Interfaces;
using RMMensajeria.GestionDevoluciones;
using Utilidades;

namespace GestionDevoluciones.Command;

public class PagosDevolucionesCmd : IPagosDevolucionesCmd
{
    private readonly IGestorId _gestorId;
    public PagosDevolucionesCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public PagosDevolucionesMS NuevoPagosDevoluciones(PagosDevolucionesME mensajeEntrada)
    {
        var nuevoPagosDevoluciones =
            new PagosDevoluciones(
                mensajeEntrada.PagoDevolucionID,
                mensajeEntrada.DevolucionID,
                mensajeEntrada.MontoReembolsado,
                mensajeEntrada.FechaReembolso,
                mensajeEntrada.MetodoPago,
                mensajeEntrada.EstadoReembolso,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IPagosDevolucionesActor>().ProcesaInsertar(nuevoPagosDevoluciones);

        return new PagosDevolucionesMS
               (nuevoPagosDevoluciones.PagoDevolucionID,
                nuevoPagosDevoluciones.DevolucionID,
                nuevoPagosDevoluciones.MontoReembolsado,
                nuevoPagosDevoluciones.FechaReembolso,
                nuevoPagosDevoluciones.MetodoPago,
                nuevoPagosDevoluciones.EstadoReembolso,
                nuevoPagosDevoluciones.FechaCreacion,
                nuevoPagosDevoluciones.FechaActualizacion);
    }
    public PagosDevolucionesMS EliminarPagosDevoluciones(PagosDevolucionesME mensajeEntrada)
    {
        var pagosDevolucionesActor = _gestorId.Resuelve<IPagosDevolucionesActor>();
        var pagosDevoluciones = _gestorId.Resuelve<IPagosDevolucionesActor>().ObtenerPagosDevolucionesPorId(mensajeEntrada.DevolucionID);

        pagosDevolucionesActor.ProcesaEliminar(pagosDevoluciones);

        return new PagosDevolucionesMS();
    }
}
