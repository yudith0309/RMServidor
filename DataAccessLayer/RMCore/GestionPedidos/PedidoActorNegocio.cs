using GestionPedidos.Entidad;
using RecepcionMercancia.Entidad;
using RecepcionMercancia.Interfaces;

namespace GestionPedidos;

public partial class PedidoActor
{
    public void ProcesaInsertar(Pedido pedido)
    {
        _repository.Agregar(pedido);

    }
    
    public void ProcesaEliminar(Pedido pedido)
    {
        _repository.Eliminar(pedido);
    }
}
