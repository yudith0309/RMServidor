using GestionCompras.Entidad;

namespace GestionCompras;

public partial class ItemDeOrdenDeCompraActor
{
    public void ProcesaInsertar(ItemDeOrdenDeCompra itemDeOrdenDeCompra)
    {
        _repository.Agregar(itemDeOrdenDeCompra);

    }
    public void ProcesaEliminar(ItemDeOrdenDeCompra itemDeOrdenDeCompra)
    {
        _repository.Eliminar(itemDeOrdenDeCompra);
    }
}
