using GestionCompras.Entidad;

namespace GestionCompras.Interfaces;

public interface IItemDeOrdenDeCompraActor
{
    ItemDeOrdenDeCompra ObtenerItemDeOrdenDeCompraPorId(Guid id);
    List<ItemDeOrdenDeCompra> ObtenerListaItemDeOrdenDeCompra();
    void ProcesaInsertar(ItemDeOrdenDeCompra itemDeOrdenDeCompra);
    void ProcesaEliminar(ItemDeOrdenDeCompra itemDeOrdenDeCompra);
}
