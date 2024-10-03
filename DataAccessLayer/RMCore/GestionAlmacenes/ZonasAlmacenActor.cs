using AccesDataBase.Repository;
using GestionAlmacenes.Entidad;
using GestionAlmacenes.Interfaces;
using Utilidades;

namespace GestionAlmacenes;

public partial class ZonasAlmacenActor: IZonasAlmacenActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public ZonasAlmacenActor(IRepository zonasAlmacenRepository, IGestorId gestorId)
    {
        _repository = zonasAlmacenRepository;
        _gestorId = gestorId;
    }
    public ZonasAlmacen ObtenerZonasAlmacenPorId(Guid id)
    {
        return _repository.ObtenerPorId<ZonasAlmacen>(id);
    }

    public List<ZonasAlmacen> ObtenerListaZonasAlmacen()
    {
        var listaZonasAlmacen = _repository.ObtenerTodos<ZonasAlmacen>();
        return listaZonasAlmacen;
    }
}
