using AccesDataBase.Repository;
using GestionDevoluciones.Entidad;
using GestionDevoluciones.Interfaces;
using Utilidades;

namespace GestionDevoluciones;

public partial class DetallesDevolucionActor: IDetallesDevolucionActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public DetallesDevolucionActor(IRepository detallesDevolucionRepository, IGestorId gestorId)
    {
        _repository = detallesDevolucionRepository;
        _gestorId = gestorId;
    }
    public DetallesDevolucion ObtenerDetallesDevolucionPorId(Guid id)
    {
        return _repository.ObtenerPorId<DetallesDevolucion>(id);
    }

    public List<DetallesDevolucion> ObtenerListaDetallesDevolucion()
    {
        var listaDetallesDevolucion = _repository.ObtenerTodos<DetallesDevolucion>();
        return listaDetallesDevolucion;
    }
}
