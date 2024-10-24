using GestionPedidos.Command.Interfaces;
using GestionPedidos.Entidad;
using GestionPedidos.Interfaces;
using RMMensajeria.GestionPedidos;
using Utilidades;

namespace GestionPedidos.Command;

public class PagosCmd: IPagosCmd
{
    private readonly IGestorId _gestorId;
    public PagosCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public PagosMS NuevoPagos(PagosME mensajeEntrada)
    {

        var nuevoPagos =
            new Pagos(
                mensajeEntrada.PagoID,
                mensajeEntrada.PedidoID,
                mensajeEntrada.Monto,
                mensajeEntrada.FechaPago,
                mensajeEntrada.MetodoPago,
                mensajeEntrada.EstadoPago,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);       

        _gestorId.Resuelve<IPagosActor>().ProcesaInsertar(nuevoPagos);

        return new PagosMS
               (nuevoPagos.PagoID,
                nuevoPagos.PedidoID,
                nuevoPagos.Monto,
                nuevoPagos.FechaPago,
                nuevoPagos.MetodoPago,
                nuevoPagos.EstadoPago,
                nuevoPagos.FechaCreacion,
                nuevoPagos.FechaActualizacion);
    }

    public PagosMS EliminarPagos(PagosME mensajeEntrada)
    {
        var pagosActor = _gestorId.Resuelve<IPagosActor>();
        var pagos = _gestorId.Resuelve<IPagosActor>().ObtenerPagosPorId(mensajeEntrada.PagoID);

        pagosActor.ProcesaEliminar(pagos);

        return new PagosMS();
    }
}
