using GestionPedidos.Command.Interfaces;
using GestionPedidos.Entidad;
using GestionPedidos.Interfaces;
using RMMensajeria.GestionPedidos;
using Utilidades;

namespace GestionPedidos.Command;

public class DetallesPedidoCmd: IDetallesPedidoCmd
{
    private readonly IGestorId _gestorId;
    public DetallesPedidoCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public DetallesPedidoMS NuevoDetallesPedido(DetallesPedidoME mensajeEntrada)
    {

        var nuevoDetallesPedido =
            new DetallesPedido(
                mensajeEntrada.DetalleID,
                mensajeEntrada.PedidoID,
                mensajeEntrada.ProductoID,
                mensajeEntrada.Cantidad,
                mensajeEntrada.PrecioUnitario,
                mensajeEntrada.Subtotal,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IDetallesPedidoActor>().ProcesaInsertar(nuevoDetallesPedido);

        return new DetallesPedidoMS
               (nuevoDetallesPedido.DetalleID,
                nuevoDetallesPedido.PedidoID,
                nuevoDetallesPedido.ProductoID,
                nuevoDetallesPedido.Cantidad,
                nuevoDetallesPedido.PrecioUnitario,
                nuevoDetallesPedido.Subtotal,
                nuevoDetallesPedido.FechaCreacion,
                nuevoDetallesPedido.FechaActualizacion);
    }

    public DetallesPedidoMS EliminarDetallesPedido(DetallesPedidoME mensajeEntrada)
    {
        var detallesPedidoActor = _gestorId.Resuelve<IDetallesPedidoActor>();
        var detallesPedido = _gestorId.Resuelve<IDetallesPedidoActor>().ObtenerDetallesPedidoPorId(mensajeEntrada.DetalleID);

        detallesPedidoActor.ProcesaEliminar(detallesPedido);

        return new DetallesPedidoMS();
    }
}
