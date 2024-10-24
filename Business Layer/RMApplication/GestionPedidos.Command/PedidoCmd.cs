using GestionPedidos.Command.Interfaces;
using GestionPedidos.Entidad;
using GestionPedidos.Interfaces;
using RMMensajeria.GestionPedidos;
using Utilidades;

namespace GestionPedidos.Command;

public class PedidoCmd: IPedidoCmd
{
    private readonly IGestorId _gestorId;
    public PedidoCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public PedidoMS NuevoPedido(PedidoME mensajeEntrada)
    {

        var nuevoPedido =
            new Pedido(
                mensajeEntrada.PedidoID,
                mensajeEntrada.ClienteID,
                mensajeEntrada.FechaPedido,
                mensajeEntrada.EstadoPedido,
                mensajeEntrada.Total,
                mensajeEntrada.MetodoPago,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);       

        _gestorId.Resuelve<IPedidoActor>().ProcesaInsertar(nuevoPedido);

        return new PedidoMS
               (nuevoPedido.PedidoID,
                nuevoPedido.ClienteID,
                nuevoPedido.FechaPedido,
                nuevoPedido.EstadoPedido,
                nuevoPedido.Total,
                nuevoPedido.MetodoPago,
                nuevoPedido.FechaCreacion,
                nuevoPedido.FechaActualizacion);
    }

    public PedidoMS EliminarPedido(PedidoME mensajeEntrada)
    {
        var PedidoActor = _gestorId.Resuelve<IPedidoActor>();
        var Pedido = _gestorId.Resuelve<IPedidoActor>().ObtenerPedidoPorId(mensajeEntrada.PedidoID);

        PedidoActor.ProcesaEliminar(Pedido);

        return new PedidoMS();
    }
}
