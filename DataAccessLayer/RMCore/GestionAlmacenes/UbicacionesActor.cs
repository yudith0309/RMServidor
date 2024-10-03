using AccesDataBase.Repository;
using GestionAlmacenes.Entidad;
using GestionAlmacenes.Interfaces;
using Utilidades;

namespace GestionAlmacenes;

public partial class UbicacionesActor : IUbicacionesActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public UbicacionesActor(IRepository ubicacionesRepository, IGestorId gestorId)
    {
        _repository = ubicacionesRepository;
        _gestorId = gestorId;
    }
    public Ubicacion ObtenerUbicacionesPorId(Guid id)
    {
        return _repository.ObtenerPorId<Ubicacion>(id);
    }

    public List<Ubicacion> ObtenerListaUbicaciones()
    {
        var listaUbicaciones = _repository.ObtenerTodos<Ubicacion>();
        return listaUbicaciones;
    }
}
