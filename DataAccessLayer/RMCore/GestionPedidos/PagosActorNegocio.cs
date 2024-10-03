using GestionPedidos.Entidad;

namespace GestionPedidos;

public partial class PagosActor
{
    public void ProcesaInsertar(Pagos pagos)
    {
        _repository.Agregar(pagos);

    }
    public void ProcesaEliminar(Pagos pagos)
    {
        _repository.Eliminar(pagos);
    }
}
