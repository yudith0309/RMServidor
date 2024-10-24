using RMMensajeria.GestionPedidos;

namespace GestionPedidos.Command.Interfaces;

public interface IPedidoCmd
{
    PedidoMS NuevoPedido(PedidoME mensajeEntrada);
    PedidoMS EliminarPedido(PedidoME mensajeEntrada);
}
