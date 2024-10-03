using GestionPedidos.Entidad;

namespace GestionPedidos.Interfaces;

public interface IPedidoActor
{
    Pedido ObtenerPedidoPorId(Guid id);
    List<Pedido> ObtenerListaPedido();
    void ProcesaInsertar(Pedido pedido);
    void ProcesaEliminar(Pedido pedido);
}
