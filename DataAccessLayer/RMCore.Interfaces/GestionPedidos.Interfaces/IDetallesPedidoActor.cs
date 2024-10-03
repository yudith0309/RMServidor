using GestionPedidos.Entidad;

namespace GestionPedidos.Interfaces;

public interface IDetallesPedidoActor
{
    DetallesPedido ObtenerDetallesPedidoPorId(Guid id);
    List<DetallesPedido> ObtenerListaDetallesPedido();
    void ProcesaInsertar(DetallesPedido detallesPedido);
    void ProcesaEliminar(DetallesPedido detallesPedido);
}
