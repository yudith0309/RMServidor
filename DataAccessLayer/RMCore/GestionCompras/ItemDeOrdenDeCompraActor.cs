using AccesDataBase.Repository;
using GestionCompras.Entidad;
using GestionCompras.Interfaces;
using Utilidades;

namespace GestionCompras;

public partial class ItemDeOrdenDeCompraActor: IItemDeOrdenDeCompraActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public ItemDeOrdenDeCompraActor(IRepository itemDeOrdenDeCompraRepository, IGestorId gestorId)
    {
        _repository = itemDeOrdenDeCompraRepository;
        _gestorId = gestorId;
    }
    public ItemDeOrdenDeCompra ObtenerItemDeOrdenDeCompraPorId(Guid id)
    {
        return _repository.ObtenerPorId<ItemDeOrdenDeCompra>(id);
    }

    public List<ItemDeOrdenDeCompra> ObtenerListaItemDeOrdenDeCompra()
    {
        var listaItemDeOrdenDeCompra = _repository.ObtenerTodos<ItemDeOrdenDeCompra>();
        return listaItemDeOrdenDeCompra;
    }
}
