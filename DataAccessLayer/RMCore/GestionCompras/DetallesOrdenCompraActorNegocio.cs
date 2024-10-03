using GestionCompras.Entidad;

namespace GestionCompras;

public partial class DetallesOrdenCompraActor
{
    public void ProcesaInsertar(DetallesOrdenCompra detallesOrdenCompra)
    {
        _repository.Agregar(detallesOrdenCompra);

    }
    public void ProcesaEliminar(DetallesOrdenCompra detallesOrdenCompra)
    {
        _repository.Eliminar(detallesOrdenCompra);
    }
}
