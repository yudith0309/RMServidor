using AccesDataBase.Repository;
using GestionPedidos.Entidad;
using GestionPedidos.Interfaces;
using Utilidades;

namespace GestionPedidos;

public partial class PedidoActor: IPedidoActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public PedidoActor(IRepository pedidoRepository, IGestorId gestorId)
    {
        _repository = pedidoRepository;
        _gestorId = gestorId;
    }
    public Pedido ObtenerPedidoPorId(Guid id)
    {
        return _repository.ObtenerPorId<Pedido>(id);
    }

    public List<Pedido> ObtenerListaPedido()
    {
        var listaPedido = _repository.ObtenerTodos<Pedido>();
        return listaPedido;
    }
}
