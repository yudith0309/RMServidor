using AccesDataBase.Repository;
using RecepcionMercancia.Entidad;
using RecepcionMercancia.Interfaces;
using Utilidades;

namespace RecepcionMercancia;

public partial class RecepcionActor : IRecepcionActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public RecepcionActor(IRepository recepcionRepository, IGestorId gestorId)
    {
        _repository = recepcionRepository;
        _gestorId = gestorId;
    }
    public Recepcion ObtenerRecepcionPorId(Guid id)
    {
        return _repository.ObtenerPorId<Recepcion>(id);
    }

    public List<Recepcion> ObtenerListaRecepcion()
    {
        var listaRecepcion = _repository.ObtenerTodos<Recepcion>();
        return listaRecepcion;
    }
}
