using RMMensajeria.GestionPedidos;

namespace GestionPedidos.Query.Interfaces;

public interface IPedidoQuy
{
    PedidoMS DevuelvePedido(PedidoME mensajeEntrada);
    PedidoMSLista DevuelveTodosPedidoes(PedidoME mensajeEntrada);
}
