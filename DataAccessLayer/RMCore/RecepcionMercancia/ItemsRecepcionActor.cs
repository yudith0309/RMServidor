using AccesDataBase.Repository;
using RecepcionMercancia.Entidad;
using RecepcionMercancia.Interfaces;
using Utilidades;

namespace RecepcionMercancia;

public partial class ItemsRecepcionActor : IItemsRecepcionActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public ItemsRecepcionActor(IRepository itemsRecepcionRepository, IGestorId gestorId)
    {
        _repository = itemsRecepcionRepository;
        _gestorId = gestorId;
    }
    public ItemRecepcion ObtenerItemsRecepcionPorId(Guid id)
    {
        return _repository.ObtenerPorId<ItemRecepcion>(id);
    }

    public List<ItemRecepcion> ObtenerListaItemsRecepcion()
    {
        var listaItemsRecepcion = _repository.ObtenerTodos<ItemRecepcion>();
        return listaItemsRecepcion;
    }
}
