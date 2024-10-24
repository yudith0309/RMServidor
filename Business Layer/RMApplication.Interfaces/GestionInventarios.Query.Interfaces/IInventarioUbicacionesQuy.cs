using RMMensajeria.GestionInventarios;
using RMMensajeria.GestionInventarioUbicaciones;

namespace GestionInventarios.Query.Interfaces;

public interface IInventarioUbicacionesQuy
{
    InventarioUbicacionesMS DevuelveInventarioUbicaciones(InventarioUbicacionesME mensajeEntrada);
    InventarioUbicacionesMSLista DevuelveTodosInventarioUbicacioneses(InventarioUbicacionesME mensajeEntrada);
}
