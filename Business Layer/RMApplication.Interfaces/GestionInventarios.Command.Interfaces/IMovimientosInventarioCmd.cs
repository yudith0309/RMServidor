using RMMensajeria.GestionInventarios;

namespace GestionInventarios.Command.Interfaces;

public interface IMovimientosInventarioCmd
{
    MovimientosInventarioMS NuevoMovimientosInventario(MovimientosInventarioME mensajeEntrada);
    MovimientosInventarioMS EliminarMovimientosInventario(MovimientosInventarioME mensajeEntrada);
}
