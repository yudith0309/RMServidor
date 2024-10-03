using RecepcionMercancia.Entidad;

namespace RecepcionMercancia.Interfaces;

public interface IItemsRecepcionActor
{
    ItemRecepcion ObtenerItemsRecepcionPorId(Guid id);
    List<ItemRecepcion> ObtenerListaItemsRecepcion();
    void ProcesaInsertar(ItemRecepcion producto);
    void ProcesaEliminar(ItemRecepcion producto);
}
