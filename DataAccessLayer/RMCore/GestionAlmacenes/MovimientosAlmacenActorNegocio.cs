using GestionAlmacenes.Entidad;

namespace GestionAlmacenes;

public partial class MovimientosAlmacenActor
{
    public void ProcesaInsertar(MovimientosAlmacen movimientosAlmacen)
    {
        _repository.Agregar(movimientosAlmacen);

    }
    public void ProcesaEliminar(MovimientosAlmacen movimientosAlmacen)
    {
        _repository.Eliminar(movimientosAlmacen);
    }
}
