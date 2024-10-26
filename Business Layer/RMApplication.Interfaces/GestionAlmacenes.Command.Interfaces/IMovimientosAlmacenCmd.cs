using RMMensajeria.GestionAlmacenes;

namespace GestionAlmacenes.Command.Interfaces;

public interface IMovimientosAlmacenCmd
{
    MovimientosAlmacenMS NuevoMovimientosAlmacen(MovimientosAlmacenME mensajeEntrada);
    MovimientosAlmacenMS EliminarMovimientosAlmacen(MovimientosAlmacenME mensajeEntrada);
}
