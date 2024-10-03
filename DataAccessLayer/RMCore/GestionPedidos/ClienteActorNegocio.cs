using GestionPedidos.Entidad;
using RecepcionMercancia.Entidad;

namespace GestionPedidos;

public partial class ClienteActor
{
    public void ProcesaInsertar(Cliente cliente)
    {
        _repository.Agregar(cliente);

    }
    public void ProcesaEliminar(Cliente cliente)
    {
        _repository.Eliminar(cliente);
    }
}
