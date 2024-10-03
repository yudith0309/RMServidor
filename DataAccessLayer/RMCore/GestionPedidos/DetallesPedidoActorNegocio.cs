using GestionPedidos.Entidad;

namespace GestionPedidos;

public partial class DetallesPedidoActor
{
    public void ProcesaInsertar(DetallesPedido detallesPedido)
    {
        _repository.Agregar(detallesPedido);

    }
    public void ProcesaEliminar(DetallesPedido detallesPedido)
    {
        _repository.Eliminar(detallesPedido);
    }
}
