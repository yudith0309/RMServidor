using RMMensajeria.GestionInventarios;

namespace GestionInventarios.Query.Interfaces;

public interface IMovimientosInventarioQuy
{
    MovimientosInventarioMS DevuelveMovimientosInventario(MovimientosInventarioME mensajeEntrada);
    MovimientosInventarioMSLista DevuelveTodosMovimientosInventarioes(MovimientosInventarioME mensajeEntrada);
}
