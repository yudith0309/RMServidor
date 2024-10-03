using AccesDataBase.Repository;
using GestionDevoluciones.Entidad;
using GestionDevoluciones.Interfaces;
using Utilidades;

namespace GestionDevoluciones;

public partial class DevolucionesActor: IDevolucionesActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public DevolucionesActor(IRepository devolucionesRepository, IGestorId gestorId)
    {
        _repository = devolucionesRepository;
        _gestorId = gestorId;
    }
    public Devoluciones ObtenerDevolucionesPorId(Guid id)
    {
        return _repository.ObtenerPorId<Devoluciones>(id);
    }

    public List<Devoluciones> ObtenerListaDevoluciones()
    {
        var listaDevoluciones = _repository.ObtenerTodos<Devoluciones>();
        return listaDevoluciones;
    }
}
