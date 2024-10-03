using AccesDataBase.Repository;
using GestionInventarios.Entidad;
using GestionInventarios.Interfaces;
using Utilidades;

namespace GestionInventarios;

public partial class InventarioUbicacionesActor: IInventarioUbicacionesActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public InventarioUbicacionesActor(IRepository inventarioUbicacionesRepository, IGestorId gestorId)
    {
        _repository = inventarioUbicacionesRepository;
        _gestorId = gestorId;
    }
    public InventarioUbicaciones ObtenerInventarioUbicacionesPorId(Guid id)
    {
        return _repository.ObtenerPorId<InventarioUbicaciones>(id);
    }

    public List<InventarioUbicaciones> ObtenerListaInventarioUbicaciones()
    {
        var listaInventarioUbicaciones = _repository.ObtenerTodos<InventarioUbicaciones>();
        return listaInventarioUbicaciones;
    }
}
