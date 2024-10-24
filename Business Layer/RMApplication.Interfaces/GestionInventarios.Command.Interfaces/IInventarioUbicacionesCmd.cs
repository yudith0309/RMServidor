using RMMensajeria.GestionInventarios;
using RMMensajeria.GestionInventarioUbicaciones;

namespace GestionInventarios.Command.Interfaces;

public interface IInventarioUbicacionesCmd
{
    InventarioUbicacionesMS NuevoInventarioUbicaciones(InventarioUbicacionesME mensajeEntrada);
    InventarioUbicacionesMS EliminarInventarioUbicaciones(InventarioUbicacionesME mensajeEntrada);
}
