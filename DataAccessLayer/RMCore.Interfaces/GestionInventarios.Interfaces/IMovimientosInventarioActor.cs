using GestionInventarios.Entidad;

namespace GestionInventarios.Interfaces;

public interface IMovimientosInventarioActor
{
    MovimientoInventario ObtenerMovimientosInventarioPorId(Guid id);
    List<MovimientoInventario> ObtenerListaMovimientoInventario();
    void ProcesaInsertar(MovimientoInventario movimientoInventario);
    void ProcesaEliminar(MovimientoInventario movimientoInventario);
}
