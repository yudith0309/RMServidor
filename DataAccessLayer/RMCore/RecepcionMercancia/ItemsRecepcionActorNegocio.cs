using RecepcionMercancia.Entidad;

namespace RecepcionMercancia;

public partial class ItemsRecepcionActor
{
    public void ProcesaInsertar(ItemRecepcion producto)
    {
        _repository.Agregar(producto);

    }

    public void ProcesaEliminar(ItemRecepcion producto)
    {
        _repository.Eliminar(producto);
    }
}
