using AccesDataBase.Repository;
using GestionAlmacenes.Entidad;
using GestionAlmacenes.Interfaces;
using Utilidades;

namespace GestionAlmacenes;

public partial class MovimientosAlmacenActor: IMovimientosAlmacenActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public MovimientosAlmacenActor(IRepository movimientosAlmacenRepository, IGestorId gestorId)
    {
        _repository = movimientosAlmacenRepository;
        _gestorId = gestorId;
    }
    public MovimientosAlmacen ObtenerMovimientosAlmacenPorId(Guid id)
    {
        return _repository.ObtenerPorId<MovimientosAlmacen>(id);
    }

    public List<MovimientosAlmacen> ObtenerListaMovimientosAlmacen()
    {
        var listaMovimientosAlmacen = _repository.ObtenerTodos<MovimientosAlmacen>();
        return listaMovimientosAlmacen;
    }
}
