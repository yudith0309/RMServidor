using RMMensajeria.GestionPedidos;

namespace GestionPedidos.Command.Interfaces;

public interface IDetallesPedidoCmd
{
    DetallesPedidoMS NuevoDetallesPedido(DetallesPedidoME mensajeEntrada);
    DetallesPedidoMS EliminarDetallesPedido(DetallesPedidoME mensajeEntrada);
}
