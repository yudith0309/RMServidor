using GestionPedidos.Entidad;

namespace GestionPedidos.Interfaces;

public interface IClienteActor
{
    Cliente ObtenerClientePorId(Guid id);
    List<Cliente> ObtenerListaCliente();
    void ProcesaInsertar(Cliente cliente);
    void ProcesaEliminar(Cliente cliente);
}
