using RMMensajeria.GestionPedidos;

namespace GestionPedidos.Query.Interfaces;

public interface IDetallesPedidoQuy
{
    DetallesPedidoMS DevuelveDetallesPedido(DetallesPedidoME mensajeEntrada);
    DetallesPedidoMSLista DevuelveTodosDetallesPedidoes(DetallesPedidoME mensajeEntrada);
}
