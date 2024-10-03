using AccesDataBase.Repository;
using GestionPedidos.Entidad;
using GestionPedidos.Interfaces;
using Utilidades;

namespace GestionPedidos;

public partial class ClienteActor: IClienteActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public ClienteActor(IRepository ClienteRepository, IGestorId gestorId)
    {
        _repository = ClienteRepository;
        _gestorId = gestorId;
    }
    public Cliente ObtenerClientePorId(Guid id)
    {
        return _repository.ObtenerPorId<Cliente>(id);
    }

    public List<Cliente> ObtenerListaCliente()
    {
        var listaProducto = _repository.ObtenerTodos<Cliente>();
        return listaProducto;
    }
}
