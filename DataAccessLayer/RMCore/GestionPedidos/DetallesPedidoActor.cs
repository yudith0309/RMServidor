using AccesDataBase.Repository;
using GestionPedidos.Entidad;
using GestionPedidos.Interfaces;
using Utilidades;

namespace GestionPedidos;

public partial class DetallesPedidoActor : IDetallesPedidoActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public DetallesPedidoActor(IRepository detallesPedidoRepository, IGestorId gestorId)
    {
        _repository = detallesPedidoRepository;
        _gestorId = gestorId;
    }
    public DetallesPedido ObtenerDetallesPedidoPorId(Guid id)
    {
        return _repository.ObtenerPorId<DetallesPedido>(id);
    }

    public List<DetallesPedido> ObtenerListaDetallesPedido()
    {
        var listaDetallesPedido = _repository.ObtenerTodos<DetallesPedido>();
        return listaDetallesPedido;
    }
}
