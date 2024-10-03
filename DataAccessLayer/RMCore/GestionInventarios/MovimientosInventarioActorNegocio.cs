using GestionInventarios.Entidad;

namespace GestionInventarios;

public partial class MovimientosInventarioActor
{
    public void ProcesaInsertar(MovimientoInventario movimientoInventario)
    {
        _repository.Agregar(movimientoInventario);

    }

    public void ProcesaEliminar(MovimientoInventario movimientoInventario)
    {
        _repository.Eliminar(movimientoInventario);
    }
}
