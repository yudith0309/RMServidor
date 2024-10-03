using GestionAlmacenes.Entidad;

namespace GestionAlmacenes.Interfaces;

public interface IMovimientosAlmacenActor
{
    MovimientosAlmacen ObtenerMovimientosAlmacenPorId(Guid id);
    List<MovimientosAlmacen> ObtenerListaMovimientosAlmacen();
    void ProcesaInsertar(MovimientosAlmacen movimientosAlmacen);
    void ProcesaEliminar(MovimientosAlmacen movimientosAlmacen);
}
