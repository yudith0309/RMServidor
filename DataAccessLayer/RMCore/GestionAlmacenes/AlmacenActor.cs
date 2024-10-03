using AccesDataBase.Repository;
using GestionAlmacenes.Entidad;
using GestionAlmacenes.Interfaces;
using Utilidades;

namespace GestionAlmacenes;

public partial class AlmacenActor: IAlmacenActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public AlmacenActor(IRepository AlmacenRepository, IGestorId gestorId)
    {
        _repository = AlmacenRepository;
        _gestorId = gestorId;
    }
    public Almacen ObtenerAlmacenPorId(Guid id)
    {
        return _repository.ObtenerPorId<Almacen>(id);
    }

    public List<Almacen> ObtenerListaAlmacen()
    {
        var listaAlmacen = _repository.ObtenerTodos<Almacen>();
        return listaAlmacen;
    }
}
