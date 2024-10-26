using RMMensajeria.GestionAlmacenes;

namespace GestionAlmacenes.Query.Interfaces;

public interface IMovimientosAlmacenQuy
{
    MovimientosAlmacenMS DevuelveMovimientosAlmacen(MovimientosAlmacenME mensajeEntrada);
    MovimientosAlmacenMSLista DevuelveTodosMovimientosAlmacenAlmacenes(AlmacenME mensajeEntrada);
}
