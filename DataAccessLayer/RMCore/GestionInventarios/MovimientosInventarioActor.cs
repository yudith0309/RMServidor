using AccesDataBase.Repository;
using GestionInventarios.Entidad;
using GestionInventarios.Interfaces;
using Utilidades;

namespace GestionInventarios;

public partial class MovimientosInventarioActor: IMovimientosInventarioActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public MovimientosInventarioActor(IRepository movimientosInventarioRepository, IGestorId gestorId)
    {
        _repository = movimientosInventarioRepository;
        _gestorId = gestorId;
    }
    public MovimientoInventario ObtenerMovimientosInventarioPorId(Guid id)
    {
        return _repository.ObtenerPorId<MovimientoInventario>(id);
    }

    public List<MovimientoInventario> ObtenerListaMovimientoInventario()
    {
        var listaMovimientoInventario = _repository.ObtenerTodos<MovimientoInventario>();
        return listaMovimientoInventario;
    }
}
